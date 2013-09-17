/*
 * HttpCommunicationService.h
 *
 *  Created on: Jul 3, 2013
 *      Author: Minjun
 */

#ifndef HTTPCOMMUNICATIONSERVICE_H_
#define HTTPCOMMUNICATIONSERVICE_H_

#include <FApp.h>
#include <FBase.h>
#include <FIo.h>
#include <FNet.h>
#include <FText.h>
#include <FUi.h>

#include "HttpCommonResource.h"

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Base::Collection;
using namespace Tizen::Base::Runtime;
using namespace Tizen::Net::Http;

class IHttpResponseEventListener
	: public IEventListener
{
public:
	virtual ~IHttpResponseEventListener(void) {}

	virtual void OnResponseReceived(const String &responseStr) = 0;
};

class HttpCommunicationService
	: public IHttpTransactionEventListener
{
// Methods
public:
	HttpCommunicationService();
	HttpCommunicationService(IHttpResponseEventListener *pListener);
	virtual ~HttpCommunicationService();

	void setHttpResponseEventListener(IHttpResponseEventListener *pListener);

	void postRequest(HashMap* requestParam, App* context, String userAgent);
	void postRequest(HashMap* requestParam, bool isGzip, App* context, String userAgent);
	void postRequestAll(HashMap* requestParam, String userAgent);
	void getRequest(String uri, HashMap* requestParam);

	HttpTransaction* createHttpPost(HashMap* requestParam, bool isGzip, App* context, String userAgentq);

	// IHttpTransactionEventListener
	virtual void OnTransactionAborted(HttpSession& httpSession, HttpTransaction& httpTransaction, result r);
	virtual void OnTransactionCertVerificationRequiredN(HttpSession& httpSession,
			HttpTransaction& httpTransaction, String *pCert);
	virtual void OnTransactionCompleted(HttpSession& httpSession, HttpTransaction& httpTransaction);
	virtual void OnTransactionHeaderCompleted(HttpSession& httpSession,
			HttpTransaction& httpTransaction, int headerLen, bool bAuthRequired);
	virtual void OnTransactionReadyToRead(HttpSession& httpSession, HttpTransaction& httpTransaction,
			int availableBodyLen);
	virtual void OnTransactionReadyToWrite(HttpSession& httpSession, HttpTransaction& httpTransaction,
			int recommendedChunkSize);

private:
	void Initialize(bool sessionReset = false, IHttpResponseEventListener *pListener = null);

	void postRequest(HttpTransaction* httpTransaction);
	String findSessionId(String value);
	void SetSessionIdToCookies(String sessionId, String* cookies);

// Variables
private:
	enum CururrentState {
		HTTP_STATE_READY,
		HTTP_STATE_POST_REQUEST,
		HTTP_STATE_POST_REQUEST_ALL,
		HTTP_STATE_GET_REQUEST
	};

	const static int			DEFAULT_CONNECTION_TIME_OUT_SEC 		= 20;
	const static int			DEFAULT_SO_TIME_OUT_SEC					= 10;

	const static String			SESSION_ID_KEY;
	const static String			COOKIE_SEPARATOR;

	const static String			GZIP_FILE_NAME;
	const static String			GUNZIP_FILE_NAME;

	HttpSession					*__pHttpSession;
	bool						__isGzip;
	String						__responseStr;
	String						__headerStr;
	String						*__pErrorCodeStr;
	HashMap						*__pResponseMap;
	int							__currentState;

	IHttpResponseEventListener	*__pResponseListener;
};

#endif /* HTTPCOMMUNICATIONSERVICE_H_ */
