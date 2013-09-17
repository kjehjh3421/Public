/*
 * HttpCommunicationService.cpp
 *
 *  Created on: Jul 3, 2013
 *      Author: Minjun
 */

#include "HttpCommunicationService.h"

using namespace Tizen::Base::Utility;
using namespace Tizen::Text;
using namespace Tizen::Io;

const String HttpCommunicationService::COOKIE_SEPARATOR 	= L";";
const String HttpCommunicationService::SESSION_ID_KEY 		= L"PHPSESSID=";
const String HttpCommunicationService::GZIP_FILE_NAME		= L"zipped.tmp";
const String HttpCommunicationService::GUNZIP_FILE_NAME		= L"unzipped.tmp";

HttpCommunicationService::HttpCommunicationService()
	: __pHttpSession(null)
	, __isGzip(false)
	, __pErrorCodeStr(null)
	, __pResponseMap(null)
	, __pResponseListener(null)
{
	// TODO Auto-generated constructor stub
	__responseStr = L"";
	__headerStr = L"";
	__currentState = HTTP_STATE_READY;
}

HttpCommunicationService::HttpCommunicationService(IHttpResponseEventListener *pListener)
	: __pHttpSession(null)
	, __isGzip(false)
	, __pErrorCodeStr(null)
	, __pResponseMap(null)
{
	__pResponseListener = pListener;
	__responseStr = L"";
	__headerStr = L"";
	__currentState = HTTP_STATE_READY;
}

HttpCommunicationService::~HttpCommunicationService() {
	// TODO Auto-generated destructor stub
}

void
HttpCommunicationService::setHttpResponseEventListener(IHttpResponseEventListener *pListener)
{
	__pResponseListener = pListener;
}

void
HttpCommunicationService::Initialize(bool sessionReset, IHttpResponseEventListener *pListener)
{
	__isGzip = false;

	if (__pErrorCodeStr != null)
	{
		delete __pErrorCodeStr;
		__pErrorCodeStr = null;
	}

	if (__pResponseMap != null)
	{
		delete __pResponseMap;
		__pResponseMap = null;
	}

	__responseStr = L"";
	__headerStr = L"";
	__currentState = HTTP_STATE_READY;

	if (sessionReset)
	{
		if (__pResponseListener != null)
		{
			delete __pResponseListener;
			__pResponseListener = null;
		}

		if (pListener != null)
			__pResponseListener = pListener;

		if (__pHttpSession != null)
		{
			__pHttpSession->CloseAllTransactions();

			delete __pHttpSession;
			__pHttpSession = null;
		}
	}
}

void
HttpCommunicationService::postRequest(HashMap* requestParam, App* context, String userAgent)
{
	AppLog("postRequest with 3 params");

	if (__currentState != HTTP_STATE_READY)
	{
		AppLog("There is another request transaction");
		return;
	}

	if (__pResponseListener == null)
	{
		AppLog("The HTTP response event listener must be set");
		return;
	}

	postRequest(requestParam, false, context, userAgent);
}

void
HttpCommunicationService::postRequest(HashMap* requestParam,
		bool isGzip, App* context, String userAgent)
{
	AppLog("postRequest with 4 params");

	if (__pResponseListener == null)
	{
		AppLog("The HTTP response event listener must be set");
		return;
	}

	if (!requestParam->ContainsKey(String(URI)))
	{
		AppLog("requestParam must be set the 'URI' field");
		return;				// HOW: Alarm to user
	}

	__currentState = HTTP_STATE_POST_REQUEST;

	postRequest(createHttpPost(requestParam, isGzip, context, userAgent));
}

HttpTransaction*
HttpCommunicationService::createHttpPost(HashMap* requestParam,
		bool isGzip, App* context, String userAgent)
{
	AppLog("createHttpPost");
	result r = E_SUCCESS;

//	bool 							isValidCookie 				= true;
	bool 							isValidCookie 				= false;
	HttpTransaction 				*pHttpTransaction 			= null;
	HttpUrlEncodedEntity 			*pHttpUrlEncodedEntity 		= null;
	HttpCookieStorageManager 		*pCookieStorageManager 		= null;
	HttpRequest 					*pRequest 					= null;
	HttpHeader						*pHeader					= null;
	//HttpAuthentication				*pAuth						= null;
	String							cookies;

	String *uri = dynamic_cast<String *>(requestParam->GetValue(String(URI)));
	// Must be added to check USE_STAGING_SERVER flag
	requestParam->Remove(String(URI));

	// Create an HTTP session
	if (__pHttpSession == null)
	{
		__pHttpSession = new (std::nothrow) HttpSession();
		r = __pHttpSession->Construct(NET_HTTP_SESSION_MODE_NORMAL, null,
				HTTP_CLIENT_HOST_ADDRESS, null, NET_HTTP_COOKIE_FLAG_ALWAYS_AUTOMATIC);

		if (IsFailed(r))
		{
			delete __pHttpSession;
			__pHttpSession = null;
			AppLogException("Failed to create the HTTP session");
			__currentState = HTTP_STATE_READY;
			return null;
		}

		r = __pHttpSession->SetAutoRedirectionEnabled(true);
		TryCatch(r == E_SUCCESS, , "Failed to set redirection automatically");
	}

	// Open a new transaction
	pHttpTransaction = __pHttpSession->OpenTransactionN();
	r = GetLastResult();
	TryCatch(r == E_SUCCESS, , "Failed to open the HTTP Transaction");

	// Authentication 130712
	/*pAuth = pHttpTransaction->OpenAuthenticationInfoN();

	String basicName(L"sol");
	String basicPass(L"sol01");
	HttpCredentials* pCredential = new HttpCredentials(basicName, basicPass);

	//String *pRealm = pAuth->GetRealmN();
	//NetHttpAuthScheme scheme = pAuth->GetAuthScheme();

	pHttpTransaction = pAuth->SetCredentials(*pCredential);*/

	// Add a listener
	r = pHttpTransaction->AddHttpTransactionListener(*this);
	TryCatch(r == E_SUCCESS, , "Failed to add the HTTPTransactionEventListener");

	// Get the HTTP request
	pRequest = const_cast<HttpRequest*>(pHttpTransaction->GetRequest());
	pHeader = pRequest->GetHeader();

	// Set a cookie
	pCookieStorageManager = __pHttpSession->GetCookieStorageManager();
	r = pCookieStorageManager->GetCookies(*uri, cookies);
	if (r != E_SUCCESS)
	{
		isValidCookie = false;
	}
	else
	{
		String cookie1 = findSessionId(cookies);

		AppRegistry* pAppRegistry = context->GetAppRegistry();
		String regcookie;
		r = pAppRegistry->Get(L"", regcookie);
		if (IsFailed(r))
		{
			regcookie = L"";
		}

		String cookie2 = findSessionId(regcookie);
		if (!cookie1.Equals(cookie2))
		{
			isValidCookie = false;
		}
	}

// ----------------------------------
	if(isValidCookie)
		AppLog("createHttpPost() isValidCookie is true");
	else
		AppLog("createHttpPost() isValidCookie is false");
// ----------------------------------


	if (!isValidCookie)
	{
		AppLog("createHttpPost() if (!isValidCookie)");

		AppRegistry* pAppRegistry = context->GetAppRegistry();
		String sessionId;
		pAppRegistry->Get(L"SessionID", sessionId);

		if (sessionId.GetLength() > 0)
		{
			StringTokenizer token(sessionId, COOKIE_SEPARATOR);
			String tokenStr;
			int keyIndex;
			while(token.HasMoreTokens())
			{
				token.GetNextToken(tokenStr);
				tokenStr.IndexOf(SESSION_ID_KEY, 0, keyIndex);

				if (keyIndex >= 0)
				{
					String sessionStr = findSessionId(tokenStr);
					r = pCookieStorageManager->GetCookies(*uri, cookies);

					if (r != E_SUCCESS)
					{
						SetSessionIdToCookies(sessionStr, &cookies);
						pRequest->SetCookie(cookies);
						AppLog("createHttpPost() cookies = %S", cookies.GetPointer());
					}
				}
			}
		}
		else
		{
			AppLog("createHttpPost() if (!isValidCookie) else");
			r = pCookieStorageManager->GetCookies(*uri, cookies);

			if (r != E_SUCCESS)
			{
				pRequest->SetCookie(cookies);
				AppLog("createHttpPost() cookies = %S", cookies.GetPointer());
			}
		}
	}

	// Set the Accept encoding option
	if (isGzip)
	{
		pRequest->SetAcceptEncoding(L"gzip, deflate");
	}

	// Set the user agent option
	if (userAgent.GetLength() > 0)
	{
		pHeader->AddField(L"User-Agent", userAgent);
	}

	// Set the HTTP method and URI
	r = pRequest->SetUri(HTTP_CLIENT_HOST_ADDRESS + *uri);
	TryCatch(r == E_SUCCESS, , "Failed to set the uri");

	r = pRequest->SetMethod(NET_HTTP_METHOD_POST);
	TryCatch(r == E_SUCCESS, , "Failed to set the POST method");

	// Set extra parameters
	pHttpUrlEncodedEntity = new (std::nothrow) HttpUrlEncodedEntity();
	r = pHttpUrlEncodedEntity->Construct();
	TryCatch(r == E_SUCCESS, , "Failed to construct the HttpUrlEncodedEntity");

	if (requestParam->GetCount() > 0)
	{
		AppLog("createHttpPost() if (requestParam->GetCount() > 0)");

		IMapEnumerator *pMapEnum = requestParam->GetMapEnumeratorN();
		String *key, *value;
		while (pMapEnum->MoveNext() == E_SUCCESS)
		{
			key = static_cast<String *>(pMapEnum->GetKey());
			value = static_cast<String *>(pMapEnum->GetValue());

			if (key->Equals(String(CONNECTION_TIME_OUT)))
			{
				int time;
				r = Integer::Parse(*value, time);
				pHttpTransaction->SetTimeout(time);
			}
//			else if (key->Equals(String(SO_TIME_OUT)))
//			{
//				// HOW: Set the SO time out
//			}
			else
			{
				r = pHttpUrlEncodedEntity->AddParameter(*key, *value);
			}
			TryCatch(r == E_SUCCESS, , "Failed to add a parameter to the HttpUrlEncodedEntity");
		}
	}

	if (requestParam->ContainsKey(String(CONNECTION_TIME_OUT)))
	{
		r = pHttpTransaction->SetTimeout(DEFAULT_CONNECTION_TIME_OUT_SEC);
	}

	if (requestParam->ContainsKey(String(SO_TIME_OUT)))
	{
		// HOW : Set the SO time out
		r = pHttpUrlEncodedEntity->AddParameter(SO_TIME_OUT, DEFAULT_SO_TIME_OUT_SEC);
	}

	r = pRequest->SetEntity(*pHttpUrlEncodedEntity);
	TryCatch(r == E_SUCCESS, , "Failed to set the extra entity");

	return pHttpTransaction;

CATCH:
	if (pHttpTransaction != null)
	{
		__pHttpSession->CloseTransaction(*pHttpTransaction);
		pHttpTransaction = null;
	}

	__currentState = HTTP_STATE_READY;
	return null;
}

String
HttpCommunicationService::findSessionId(String value)
{
	AppLog("(-)findSessionId");
	if (value == null || value.GetLength() < 1)
	{
		return null;
	}

	if (value.Contains(L" "))
	{
		value.Replace(L" ", L"");
	}

	int keyIndex;
	String foundValue;

	if (value.Contains(COOKIE_SEPARATOR))
	{
		StringTokenizer strTok(value.GetPointer(), COOKIE_SEPARATOR);
		String token;

		while(strTok.HasMoreTokens())
		{
			strTok.GetNextToken(token);
			token.IndexOf(SESSION_ID_KEY,0, keyIndex);
			if(keyIndex == 0)
			{
				keyIndex += String(SESSION_ID_KEY).GetLength();
				token.SubString(keyIndex,token.GetLength() - keyIndex,foundValue);
				return foundValue;
			}
		}
	}
	else
	{
		value.IndexOf(SESSION_ID_KEY,0 ,keyIndex);
		if(keyIndex == 0)
		{
			keyIndex += String(SESSION_ID_KEY).GetLength();
			value.SubString(keyIndex,value.GetLength() - keyIndex,foundValue);
			return foundValue;
		}
	}

	return null;
}

void
HttpCommunicationService::SetSessionIdToCookies(String sessionId, String *cookies)
{
	AppLog("(-)SetSessionIdToCookies");
	if (cookies == null || cookies->GetLength() < 1)
	{
		return ;
	}
	if (cookies->Contains(L" "))
	{
		cookies->Replace(L" ", L"");
	}

	int keyIndex;
	if (cookies->Contains(SESSION_ID_KEY))
	{
		String oldSessionId = findSessionId(*cookies);
		cookies->Replace(oldSessionId , sessionId);
	}
	else
	{
		cookies->IndexOf(COOKIE_SEPARATOR,0, keyIndex);
		cookies->Insert(SESSION_ID_KEY + sessionId + COOKIE_SEPARATOR, keyIndex + 1);
	}
}

void
HttpCommunicationService::postRequest(HttpTransaction* httpTransaction)
{
	AppLog("postRequest");

	if (httpTransaction == null)
		return;

	// Submit the HTTP request message
	result r = httpTransaction->Submit();
	TryCatch(r == E_SUCCESS, , "Failed to submit the request");

	return;

CATCH:
	delete httpTransaction;
	httpTransaction = null;

	__currentState = HTTP_STATE_READY;
	AppLogException("An invalid result is occurred in postRequest");
	// HOW: alarm the exception to an user
}

void
HttpCommunicationService::postRequestAll(HashMap* requestParam, String userAgent)
{
	AppLog("postRequestAll");

	result r;
	HttpTransaction					*pTransaction 				= null;
	HttpRequest						*pRequest					= null;
	HttpHeader						*pHeader					= null;
	HttpUrlEncodedEntity			*pUrlEncodedEntity			= null;
	HttpCookieStorageManager 		*pCookieStorageManager 		= null;
	String							cookies;

	if (__pResponseListener == null)
	{
		AppLog("The HTTP response event listener must be set");
		return;
	}

	if (__currentState != HTTP_STATE_READY)
	{
		AppLog("There is another HTTP request transaction");
		return;
	}

	if (requestParam == null)
	{
		AppLogException("The Request parameter is null");
		return;
	}

	__currentState = HTTP_STATE_POST_REQUEST_ALL;

	String *uri = dynamic_cast<String*>(requestParam->GetValue(String(URI)));
	requestParam->Remove(String(URI));

	// Create an HTTP session
	if (__pHttpSession == null)
	{
		__pHttpSession = new (std::nothrow) HttpSession();
		r = __pHttpSession->Construct(NET_HTTP_SESSION_MODE_NORMAL, null, HTTP_CLIENT_HOST_ADDRESS, null);
		if (IsFailed(r))
		{
			delete __pHttpSession;
			__pHttpSession = null;
			AppLogException("Failed to create the HTTP session");
			__currentState = HTTP_STATE_READY;
			return;
		}

		r = __pHttpSession->SetAutoRedirectionEnabled(true);
		TryCatch(r == E_SUCCESS, , "Failed to set redirection automatically");
	}

	// Open a transaction
	pTransaction = __pHttpSession->OpenTransactionN();
	r = GetLastResult();
	TryCatch(r == E_SUCCESS, , "Failed to open the HTTP transaction");

	// Add a listener
	r = pTransaction->AddHttpTransactionListener(*this);
	TryCatch(r == E_SUCCESS, , "Failed to add the HTTP transaction event listener");

	// Get an HTTP request message
	pRequest = pTransaction->GetRequest();

	// Set the HTTP method and URI
	r = pRequest->SetUri(*uri);
	TryCatch(r == E_SUCCESS, , "Failed to set the URI");

	r = pRequest->SetMethod(NET_HTTP_METHOD_POST);
	TryCatch(r == E_SUCCESS, , "Failed to set the HTTP POST method");

	// Set extra parameters
	pUrlEncodedEntity = new (std::nothrow) HttpUrlEncodedEntity();
	r = pUrlEncodedEntity->Construct();
	TryCatch(r == E_SUCCESS, , "Failed to construct the HttpUrlEncodedEntity");

	if (requestParam->GetCount() > 0)
	{
		IMapEnumerator *pMapEnum = requestParam->GetMapEnumeratorN();
		String *key, *value;
		while (pMapEnum->MoveNext() == E_SUCCESS)
		{
			key = static_cast<String *>(pMapEnum->GetKey());
			value = static_cast<String *>(pMapEnum->GetValue());

			if (key->Equals(String(CONNECTION_TIME_OUT)))
			{
				int time;
				r = Integer::Parse(*value, time);
				pTransaction->SetTimeout(time);
			}
//			else if (key->Equals(String(SO_TIME_OUT)))
//			{
//				// HOW: Set the SO time out
//			}
			else
			{
				r = pUrlEncodedEntity->AddParameter(*key, *value);
			}
			TryCatch(r == E_SUCCESS, , "Failed to add a parameter to the HttpUrlEncodedEntity");
		}
	}

	if (requestParam->ContainsKey(String(CONNECTION_TIME_OUT)))
	{
		r = pTransaction->SetTimeout(DEFAULT_CONNECTION_TIME_OUT_SEC);
	}

	if (requestParam->ContainsKey(String(SO_TIME_OUT)))
	{
		// HOW : Set the SO time out
		r = pUrlEncodedEntity->AddParameter(SO_TIME_OUT, DEFAULT_SO_TIME_OUT_SEC);
	}

	r = pRequest->SetEntity(*pUrlEncodedEntity);
	TryCatch(r == E_SUCCESS, , "Failed to set the extra entity");

	// Set a cookie
	pCookieStorageManager = __pHttpSession->GetCookieStorageManager();
	r = pCookieStorageManager->GetCookies(*uri, cookies);
	if (r == E_SUCCESS)
	{
		r = pRequest->SetCookie(cookies);
		TryCatch(r == E_SUCCESS, , "Failed to set the cookie");
	}

	// Get an HTTP request header
	pHeader = pRequest->GetHeader();
	r = pHeader->AddField(L"UserAgent", userAgent);
	TryCatch(r == E_SUCCESS, , "Failed to set the user agent")

	// Submit the HTTP POST request message
	pTransaction->Submit();

	return;

CATCH:
	if (pTransaction != null)
	{
		delete pTransaction;
		pTransaction = null;
	}

	__currentState = HTTP_STATE_READY;
	AppLogException("An invalid result is occurred in postRequestAll");
	// HOW: alarm the exception to an user
}

void
HttpCommunicationService::getRequest(String uri, HashMap* requestParam)
{
	AppLog("getRequest");

	result r = E_SUCCESS;

	HttpTransaction					*pHttpTransaction 			= null;
	HttpRequest						*pRequest					= null;
	HttpUrlEncodedEntity			*pUrlEncodedEntity			= null;

	if (__pResponseListener == null)
	{
		AppLog("The HTTP response event listener must be set");
		return;
	}

	if (__currentState != HTTP_STATE_READY)
	{
		AppLog("There is another HTTP request transaction");
		return;
	}

	__currentState = HTTP_STATE_GET_REQUEST;

	// Construct an HTTP Session
	if (__pHttpSession == null)
	{
		__pHttpSession = new (std::nothrow) HttpSession();
		r = __pHttpSession->Construct(NET_HTTP_SESSION_MODE_NORMAL, null, HTTP_CLIENT_HOST_ADDRESS, null);

		if (IsFailed(r))
		{
			delete __pHttpSession;
			__pHttpSession = null;
			__currentState = HTTP_STATE_READY;
			AppLogException("Failed to create the HTTP session");
			return;
		}

		r = __pHttpSession->SetAutoRedirectionEnabled(true);
		TryCatch(r == E_SUCCESS, , "Failed to set redirection automatically");
	}

	// Open a new transaction
	pHttpTransaction = __pHttpSession->OpenTransactionN();
	r = GetLastResult();
	TryCatch(!IsFailed(r), , "Failed to open the HTTP transaction");

	// Add a listener
	r = pHttpTransaction->AddHttpTransactionListener(*this);
	TryCatch(r == E_SUCCESS, , "Failed to add the HTTP transaction event listener");

	// Get an HTTP request message
	pRequest = const_cast<HttpRequest *>(pHttpTransaction->GetRequest());

	// Set the HTTP method and URI
	r = pRequest->SetUri(uri);
	TryCatch(r == E_SUCCESS, , "Failed to set the URI");

	r = pRequest->SetMethod(NET_HTTP_METHOD_GET);
	TryCatch(r == E_SUCCESS, , "Failed to set the GET method");

	// Set extra parameters
	pUrlEncodedEntity = new (std::nothrow) HttpUrlEncodedEntity();
	r = pUrlEncodedEntity->Construct();
	TryCatch(r == E_SUCCESS, , "Failed to construct the HttpUrlEncodedEntity");

	if (requestParam->GetCount() > 0)
	{
		IMapEnumerator *pMapEnum = requestParam->GetMapEnumeratorN();
		String *key, *value;
		while (pMapEnum->MoveNext() == E_SUCCESS)
		{
			key = static_cast<String *>(pMapEnum->GetKey());
			value = static_cast<String *>(pMapEnum->GetValue());

			if (key->Equals(String(CONNECTION_TIME_OUT)))
			{
				int time;
				r = Integer::Parse(*value, time);
				pHttpTransaction->SetTimeout(time);
			}
//			else if (key->Equals(String(SO_TIME_OUT)))
//			{
//				// HOW: Set the SO time out
//			}
			else
			{
				r = pUrlEncodedEntity->AddParameter(*key, *value);
			}
			TryCatch(r == E_SUCCESS, , "Failed to add a parameter to the HttpUrlEncodedEntity");
		}
	}

	if (requestParam->ContainsKey(String(CONNECTION_TIME_OUT)))
	{
		r = pHttpTransaction->SetTimeout(DEFAULT_CONNECTION_TIME_OUT_SEC);
	}

	if (requestParam->ContainsKey(String(SO_TIME_OUT)))
	{
		// HOW : Set the SO time out
		r = pUrlEncodedEntity->AddParameter(SO_TIME_OUT, DEFAULT_SO_TIME_OUT_SEC);
	}

	r = pRequest->SetEntity(*pUrlEncodedEntity);
	TryCatch(r == E_SUCCESS, , "Failed to set the extra entity");

	// Submit the request
	r = pHttpTransaction->Submit();
	TryCatch(r == E_SUCCESS, , "Failed to submit the request");

	return;

CATCH:
	if (pHttpTransaction != null)
	{
		delete pHttpTransaction;
		pHttpTransaction = null;
	}

	AppLogException("An invalid result is occurred in getRequest");

	__currentState = HTTP_STATE_READY;
	// HOW: alarm the exception to an user
}


// IHttpTransactionEventListener implementation
void
HttpCommunicationService::OnTransactionReadyToRead(HttpSession& httpSession,
		HttpTransaction& httpTransaction, int availableBodyLen)
{
	AppLog("OnTransactionReadyToRead");

	result 						r				= E_SUCCESS;
	HttpResponse				*pResponse		= null;
	ByteBuffer					*pBody			= null;
	String						*pBodyStr		= null;
	Encoding					*pEnc			= null;

	pResponse = httpTransaction.GetResponse();
	TryCatch(pResponse->GetHttpStatusCode() == HTTP_STATUS_OK, ,
			"An error is occurred during receiving the HTTP response");

	pBody = pResponse->ReadBodyN();

	pEnc = Encoding::GetEncodingN(L"UTF-8");

	switch (__currentState)
	{
		case HTTP_STATE_POST_REQUEST:
		case HTTP_STATE_POST_REQUEST_ALL:
		case HTTP_STATE_GET_REQUEST:
			pBodyStr = new String();

			pEnc->GetString(*pBody, *pBodyStr);
			__responseStr.Append(*pBodyStr);

			break;
	}

	return;

CATCH:
	if (pBodyStr != null)
		delete pBodyStr;

	if (pBody != null)
		delete pBody;

	httpSession.CloseTransaction(httpTransaction);
	__currentState = HTTP_STATE_READY;
}

void
HttpCommunicationService::OnTransactionCompleted(HttpSession& httpSession,
		HttpTransaction& httpTransaction)
{
	AppLog("OnTransactionCompleted");

	result							r					= E_SUCCESS;
	String							*pAppDataPath		= null;

	if (__isGzip)
	{
		// Gunzip processing
		pAppDataPath = new String (App::GetInstance()->GetAppDataPath());

		// Store a zip file
		File file;
		r = file.Construct(*pAppDataPath + GZIP_FILE_NAME, "w+");
		if (IsFailed(r))
		{
			AppLog("Failed to create a temporary file for zip");
		}

		r = file.Write(__responseStr);
		if (IsFailed(r))
		{
			AppLog("Failed to write zipped contents into the file");
		}

		// FileUnzipper
		FileUnzipper unzip;
		//String unzipFilePath = App::GetInstance()->GetAppDataPath() + L"unzipped.uz";
		unzip.Construct(*pAppDataPath + GZIP_FILE_NAME);
		// Store an unzip file
		unzip.UnzipTo(*pAppDataPath + GUNZIP_FILE_NAME);

		// Read the unzipped file
		File readFile;
		r = readFile.Construct(*pAppDataPath + GUNZIP_FILE_NAME, "r");
		if (IsFailed(r))
		{
			AppLog("Failed to create a temporary file for unzip");
		}

		r = readFile.Read(__responseStr);
		if (IsFailed(r))
		{
			AppLog("Failed to read the temporary file");
		}
	}

	switch (__currentState)
	{
		case HTTP_STATE_POST_REQUEST_ALL:
			// return response map
			break;
		case HTTP_STATE_POST_REQUEST:
		case HTTP_STATE_GET_REQUEST:
			__pResponseListener->OnResponseReceived(__responseStr);
			break;
		default:
			break;
	}

	if (__isGzip)
	{
		// Remove temporary files
		File::Remove(*pAppDataPath + GZIP_FILE_NAME);
		File::Remove(*pAppDataPath + GUNZIP_FILE_NAME);

		delete pAppDataPath;

		__isGzip = false;
	}

	httpSession.CloseTransaction(httpTransaction);
}

void
HttpCommunicationService::OnTransactionCertVerificationRequiredN(HttpSession& httpSession,
		HttpTransaction& httpTransaction, String *pCert)
{
	AppLog("OnTransactionCertVerificationRequiredN");

	// Resume the HTTPS transaction
	httpTransaction.Resume();
}

void
HttpCommunicationService::OnTransactionAborted(HttpSession& httpSession,
		HttpTransaction& httpTransaction, result r)
{
	AppLog("OnTransactionAborted: %s", GetErrorMessage(r));

	delete &httpTransaction;
}

void
HttpCommunicationService::OnTransactionHeaderCompleted(HttpSession& httpSession,
		HttpTransaction& httpTransaction, int headerLen, bool bAuthRequired)
{
	AppLog("OnTransactionHeaderCompleted");

	HttpResponse				*pResponse			= null;
	HttpHeader					*pHeader			= null;
	IEnumerator					*pHeaderEnum		= null;
	result						r					= E_SUCCESS;

// ------------------------
	IList* pCookieList = null;
	HttpCookie* pCookie = null;
// ------------------------

	if (bAuthRequired)
	{
		AppLog("Authentication is required");

		HttpTransaction* pTransaction = const_cast<HttpTransaction *>(&httpTransaction);
		HttpAuthentication* pAuth = pTransaction->OpenAuthenticationInfoN();

		String basicName(L"sol");
		String basicPass(L"sol01");
		HttpCredentials* pCredential = new HttpCredentials(basicName, basicPass);

		//String *pRealm = pAuth->GetRealmN();
		//NetHttpAuthScheme scheme = pAuth->GetAuthScheme();
		//if (scheme == NET_HTTP_AUTH_WWW_BASIC && scheme == NET_HTTP_AUTH_PROXY_BASIC)
		//{
			AppLog("Authentication");
			HttpTransaction* pNewTransaction = pAuth->SetCredentials(*pCredential);
			pNewTransaction->Submit();
			return;
		//}
	}

	pResponse = httpTransaction.GetResponse();

// -----------------------------------------------------------------
/*
	pCookieList = pResponse->GetCookies();
	if(pCookieList->GetCount() > 0)
	{
	    for (int i = 0; i < pCookieList->GetCount(); i++)
	    {
	        pCookie = static_cast<HttpCookie*>(pCookieList->GetAt(i));
	        String domain = pCookie->GetDomain();
	        String version = pCookie->GetVersion();
	        String path = pCookie->GetPath();
	        String expire = pCookie->GetExpires();
	        String cookieName = pCookie->GetCookieName();
	        String cookieValue = pCookie->GetCookieValue();
	        AppLog("OnTransactionHeaderCompleted() cookieName = %S", cookieName.GetPointer());
	    }
	}
*/
// -----------------------------------------------------------------
	if (pResponse->GetHttpStatusCode() != HTTP_STATUS_OK)
	{
		//r = GetLastResult();
		AppLogException("HTTP response error: %s", pResponse->GetStatusText().GetPointer());

		goto CATCH;
	}
	//TryCatch(pResponse->GetHttpStatusCode() == HTTP_STATUS_OK, ,
		//	"An error is occurred during receiving the HTTP response");

	if (__currentState == HTTP_STATE_POST_REQUEST || __currentState == HTTP_STATE_POST_REQUEST_ALL)
	{
		pHeader = pResponse->GetHeader();
		// MJKIM: The below must be uncommented when connect the Hondana store sever.
		/*pHeaderEnum = pHeader->GetFieldValuesN(L"Error-code");
		r = GetLastResult();
		TryCatch(r == E_SUCCESS, , "Failed to get values of the 'Error-code' field(s)");

		if (__pErrorCodeStr != null)
		{
			delete __pErrorCodeStr;
			__pErrorCodeStr = null;
		}

		pHeaderEnum->MoveNext();

		__pErrorCodeStr = static_cast<String *>(pHeaderEnum->GetCurrent());
		TryCatch(__pErrorCodeStr->Equals(ERROR_CODE_OK, false), , "Error is occurred during receiving the HTTP header");

		delete pHeaderEnum;
		pHeaderEnum = null;
		*/
		if (__currentState == HTTP_STATE_POST_REQUEST)
		{
			pHeaderEnum = pHeader->GetFieldValuesN(L"Content-Encoding");
			r = GetLastResult();
			while (r == E_SUCCESS && pHeaderEnum->MoveNext())
			{
				String *temp = static_cast<String *>(pHeaderEnum->GetCurrent());
				if (temp->Contains("gzip"))
				{
					__isGzip = true;
					break;
				}

				r = GetLastResult();
			}

			delete pHeaderEnum;
			pHeaderEnum = null;
		}
		else
		{
			if (__pResponseMap != null)
			{
				__pResponseMap->RemoveAll();
				delete __pResponseMap;
				__pResponseMap = null;
			}

			__pResponseMap = new (std::nothrow) HashMap(SingleObjectDeleter);
			r = __pResponseMap->Construct();
			TryCatch(r == E_SUCCESS, ,"Failed to construct the response map");
		}
	}

	__responseStr = L"";

	// Test code
	__headerStr = *(pHeader->GetRawHeaderN());
	__responseStr.Append(__headerStr);
	__responseStr.Append(L"\n\n=======================\n\n\n");

	return;

CATCH:
	if (__pResponseMap != null)
	{
		delete __pResponseMap;
		__pResponseMap = null;
	}

	if (pHeaderEnum != null)
		delete pHeaderEnum;

	if (pHeader != null)
		delete pHeader;

	httpSession.CloseTransaction(httpTransaction);
	__currentState = HTTP_STATE_READY;
}

void
HttpCommunicationService::OnTransactionReadyToWrite(HttpSession& httpSession,
		HttpTransaction& httpTransaction, int recommendedChunkSize)
{
	AppLog("OnTransactionReadyToWrite");
}
