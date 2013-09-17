/*
 * MyHondanaLoginForm.cpp
 *
 *  Created on: Jun 18, 2013
 *      Author: sihong
 */

#include <FBase.h>
#include <FIo.h>
#include <FApp.h>
#include <FSysPowerManager.h>
#include "SceneRegister.h"
#include "MyHondanaLoginForm.h"

using namespace Tizen::Base;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Web;
using namespace Tizen::Web::Controls;
using namespace Tizen::Web::Json;
using namespace Tizen::Graphics;
using namespace Tizen::Ui::Scenes;
using namespace Tizen::Io;
using namespace Tizen::App;

//const wchar_t* USER_AGENT = L"Mozilla/5.0 (Linux; Tizen 2.2; SEC-SC-001) AppleWebKit/537.3 (KHTML, like Gecko) Version/2.2 Mobile Safari/537.3";
const String USER_AGENT = L"Mozilla/5.0 (Linux; Tizen 2.2; SEC-SC-001) AppleWebKit/537.3 (KHTML, like Gecko) Version/2.2 Mobile Safari/537.3";
const String IMEI = L"351990050045845";

MyHondanaLoginForm::MyHondanaLoginForm(void)
{
}


MyHondanaLoginForm::~MyHondanaLoginForm(void)
{
}

bool
MyHondanaLoginForm::Initialize()
{
    // Construct an XML form
    Construct(L"IDF_MY_HONDANA_LOGIN_FORM");
//	SetOrientation(ORIENTATION_LANDSCAPE);

//	this->Construct(L"IDF_MY_HONDANA_LOGIN_FORM", FORM_STYLE_NORMAL);

    return true;
}

result
MyHondanaLoginForm::OnInitializing(void)
{

	AppLog("MyHondanaLoginForm::OnInitializing()");
	// Create footer
	Footer * pFooter = GetFooter();
	if (pFooter != null) {
		pFooter->SetStyle(FOOTER_STYLE_BUTTON_ICON);
		pFooter->SetBackButton();
	}
	SetFormBackEventListener(this);
    result r = E_SUCCESS;

    loadURLPage();

    // Get a button via resource ID
//    pWeb = new Web();
//    pWeb->Construct(Rectangle(0, 0, this->GetWidth(), this->GetHeight()));
//
//    AddControl(*pWeb);
//    String url("http://stg.book.dmkt-sp.jp/api/user/login");
//
//    WebSetting setting;
//
//    setting.SetUserAgent(USER_AGENT);
//    mAuthenticationChallenge.Process("sol", "sol01");
//    AuthenticationChallenge mAuthenticationChallenge;
//    pWeb->LoadUrl(url);

    return r;
}

result
MyHondanaLoginForm::OnTerminating(void)
{
    result r = E_SUCCESS;

    return r;
}

void
MyHondanaLoginForm::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{

}

void
MyHondanaLoginForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	pSceneManager->GoBackward(BackwardSceneTransition());
}

void MyHondanaLoginForm::OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId,
									const Tizen::Ui::Scenes::SceneId& nextSceneId)
{
}

void
MyHondanaLoginForm::OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId, const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs)
{
}

void
MyHondanaLoginForm::loadURLPage(void)
{
	AppLog("MyHondanaLoginForm::loadURLPage()");

    pWeb = new Web();

    pWeb->Construct(Rectangle(0, 0, this->GetWidth(), this->GetHeight()));
    pWeb->SetLoadingListener(this);
    pWeb->SetCookieEnabled(true);

    AddControl(*pWeb);
    String url("http://stg.book.dmkt-sp.jp/api/user/login");

    WebSetting setting;
//    AuthenticationChallenge mAuthenticationChallenge;

    setting.SetUserAgent(USER_AGENT);
    setting.SetJavascriptEnabled(true);

//    mAuthenticationChallenge.Process("sol", "sol01");


    pWeb->LoadUrl(url);

//	if(pWeb->IsLoading())
//    {
//    Tizen::Base::String  mGetURL = pWeb->GetUrl();

//   	AppLog("loadURLPage() mGetURL = %S", (char*)mGetURL.GetPointer());
//
//    	if(mGetURL == "http://stg.book.dmkt-sp.jp/api/user/loginresult")
//    	{
//    		AppLog("MyHondanaLoginForm::loadURLPage()");
//
//    	}
//    }

//    pWeb->EvaluateJavascriptN();


//    pWeb->LoadUrlWithPostRequest(url, "", null);

}

void MyHondanaLoginForm::HandleJavaScriptRequestN(IJsonValue *pArg)
{
       AppLog("GetThe resp..");
       result r = E_SUCCESS;
       JsonObject *pJsonObject = static_cast<JsonObject*>(pArg);
       IJsonValue *pValue = null;
       JsonString *pJsonStringValue = null;
       String key(L"name");
       r = pJsonObject->GetValue(&key, pValue);
       pJsonStringValue = static_cast<JsonString*>(pValue);
       AppLog("data: %S\n", pJsonStringValue->GetPointer());
}


bool
MyHondanaLoginForm::OnHttpAuthenticationRequestedN(const Tizen::Base::String& host, const Tizen::Base::String& realm, const Tizen::Web::Controls::AuthenticationChallenge& authentication)
{
	return false;
}

void
MyHondanaLoginForm::OnHttpAuthenticationCanceled(void)
{
}

void
MyHondanaLoginForm::OnLoadingStarted(void)
{
//	SetButtonCancelImage();
}

void
MyHondanaLoginForm::OnLoadingCanceled(void)
{
//	SetButtonGotoImage();
}

void
MyHondanaLoginForm::OnLoadingErrorOccurred(LoadingErrorType error, const String& reason)
{
	Tizen::Ui::Controls::MessageBox msgBox;
	int modalresult = 0;
	Tizen::Base::String errReason;

	switch (error)
	{
	case WEB_REQUEST_TIMEOUT:
	{
		errReason = Tizen::Base::String(L"Request timeout");
	}
	break;

	case WEB_NO_CONNECTION:
	{
		errReason = Tizen::Base::String(L"Network is not in service");
	}
	break;

	case WEB_MIME_NOT_SUPPORTED:
	{
		errReason = Tizen::Base::String(L"The content type is not supported");
	}
	break;

	case WEB_BAD_URL:
	{
		errReason = Tizen::Base::String(L"The url is invalid");
	}
	break;

	case WEB_HTTP_RESPONSE:
	{
		errReason = Tizen::Base::String(L"HTTP response");
	}
	break;

	case WEB_OUT_OF_MEMORY:
	{
		errReason = Tizen::Base::String(L"Page Too Large");
	}
	break;

	case WEB_REQUEST_MAX_EXCEEDED:
	{
		errReason = Tizen::Base::String(L"Request Max Exceeded");
	}
	break;

	case WEB_ERROR_UNKNOWN:
	default:
	{
		errReason = Tizen::Base::String(L"An Unknown error");
	}
	break;
	}

	msgBox.Construct(L"LOADING ERROR TYPE", errReason, MSGBOX_STYLE_NONE, 3000);
	msgBox.ShowAndWait(modalresult);
//	SetButtonGotoImage();
}

void
MyHondanaLoginForm::OnLoadingCompleted(void)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

//	SetUrl(__pWeb->GetUrl());
//	SetButtonGotoImage();
    Tizen::Base::String  mGetURL = pWeb->GetUrl();
   	AppLog("OnLoadingCompleted() mGetURL = %S", (char*)mGetURL.GetPointer());

   	if(mGetURL == "http://stg.book.dmkt-sp.jp/api/user/loginresult")
   	{
//   		pWeb->LoadData("", "" , "");


   		SetLogin();

//   		Tizen::Base::Collection::HashMap* map = new Tizen::Base::Collection::HashMap();
//   		map->Construct();
//   		map->Add(new String(L"offset"),new String(L"0"));
//   		map->Add(new String(L"IMEI"),new String(L"351990050045845"));
//
//   		map->Add(new String(URI),new String(L"http://stg.book.dmkt-sp.jp/api/bookshelf/sync"));
//
//   		String mUserAgent = L"Mozilla/5.0 (Linux; Tizen 2.2; SEC-SC-001) AppleWebKit/537.3 (KHTML, like Gecko) Version/2.2 Mobile Safari/537.3";
//
//   		__pHttpService->postRequest(map, App::GetInstance(), mUserAgent);



//   		pWeb->StopLoading();
//   		pWeb->Destroy();
//		pSceneManager->GoForward(ForwardSceneTransition(SCENE_MAIN));
   	}
}

void
MyHondanaLoginForm::OnEstimatedProgress(int progress)
{
}

void
MyHondanaLoginForm::OnPageTitleReceived(const Tizen::Base::String& title)
{
}

bool
MyHondanaLoginForm::OnLoadingRequested(const Tizen::Base::String& url, WebNavigationType type)
{
	AppLog("%S",url.GetPointer());
//	SetUrl(url);
	return false;
}

DecisionPolicy
MyHondanaLoginForm::OnWebDataReceived(const Tizen::Base::String& mime, const Tizen::Net::Http::HttpHeader& header)
{
	return WEB_DECISION_CONTINUE;
}

void
MyHondanaLoginForm::SetLogin(void)
{
	// ---------------------------------------------
//		HttpSession* pHttpSession = new HttpSession;
//		pHttpSession->Construct(NET_HTTP_SESSION_NORMAL, null, hostAddr, pCommonHeader, NET_HTTP_COOKIE_FLAG_ALWAYS_AUTOMATIC);
//
//		String cookies;
//		HttpCookieStorageManager* pCookieMgr = pHttpSession->GetCookieStorageManager();
//		r = pCookieMgr->GetCookies(L"http://localhost/cookie", cookies);
	// ---------------------------------------------

	Registry reg;
	String regPathName(L"MyhondanaReg.ini");

	// Section name
	String sect_UserMyId(L"UserMyId");

	// Entry name
	String entry_UserID(L"UserID");
	String entry_SessionID(L"SessionID");

	int iVal;
	result r;

	r = reg.Construct(App::GetInstance()->GetAppDataPath() + regPathName, "a+");

	// Create sections
	r = reg.AddSection(sect_UserMyId);

	// Add value: section1 { entry1 = 999 }
	r = reg.AddValue(sect_UserMyId, entry_UserID, 777);

	// Change value: section1 { entry1 = 3 }
	r = reg.AddValue(sect_UserMyId, entry_SessionID, 999);

	// Write to the file
	r = reg.Flush();




//	File file;
//	String filePath = App::GetInstance()->GetAppDataPath() + L"MyhondanaReg.ini";
//	char buffer[1];
//	int i = 1;
//	result r = file.Construct(filePath, L"w+");
//
//
//		ed.putString("UserID", responseMap.get("UserNo"));
//		ed.putString("SessionID", cookieManager.getCookie(siteUrl));
//
//
//
//	buffer[0] = (char) i;
//	r = file.Write(buffer, 1);
//	TryReturnVoid(r == E_SUCCESS, "file read failure with [%s]", GetErrorMessage(r));

}

//void
//MyHondanaLoginForm::OnTransactionHeaderCompleted(HttpSession& httpSession, HttpTransaction& httpTransaction, int headerLen, bool bAuthRequired)
//{
//    IList* pCookieList = null;
//    HttpCookie* pCookie = null;
//    HttpTransaction* pTransaction = const_cast<HttpTransaction*>(&(httpTransaction));
//    HttpResponse* pResponse = pTransaction->GetResponse();
//    HttpHeader* pHeader = pResponse->GetHeader();
//
//    String* pRawHeader = null;
//    pRawHeader = pHeader->GetRawHeaderN();
//
//    pCookieList = pResponse->GetCookies();
//    for (int i = 0; i < pCookieList->GetCount(); i++)
//    {
//        pCookie = static_cast<HttpCookie*>(pCookieList->GetAt(i));
//        String domain = pCookie->GetDomain();
//        String version = pCookie->GetVersion();
//        String path = pCookie->GetPath();
//        String expire = pCookie->GetExpires();
//        String cookieName = pCookie->GetCookieName();
//        String cookieValue = pCookie->GetCookieValue();
//    }
//
//    delete pRawHeader;
//}
