/*
 * MyHondanaMarketForm.h
 *
 *  Created on: Jun 18, 2013
 *      Author: sihong
 */

#ifndef MYHONDANAMARKETFORM_H_
#define MYHONDANAMARKETFORM_H_

#include <FBase.h>
#include <FUi.h>
#include <FWeb.h>
#include "MyHondanaMainForm.h"
#include "HttpCommunicationService.h"
#include <FNet.h>


using namespace Tizen::Web;
using namespace Tizen::Web::Controls;
using namespace Tizen::Web::Json;
using namespace Tizen::Net::Http;


class MyHondanaMarketForm
	: public Tizen::Ui::Controls::Form
	, public Tizen::Ui::IActionEventListener
	, public Tizen::Ui::Controls::IFormBackEventListener
	, public Tizen::Web::Controls::ILoadingListener
 	, public Tizen::Ui::Scenes::ISceneEventListener
//	, public IHttpResponseEventListener
{
public:
	MyHondanaMarketForm(void);
	~MyHondanaMarketForm(void);
	bool Initialize(void);

protected:
	Tizen::Web::Controls::Web *pWeb;

public:
    virtual result OnInitializing(void);
    virtual result OnTerminating(void);
	virtual void OnActionPerformed(const Tizen::Ui::Control& source, int actionId);

	virtual void OnFormBackRequested(Tizen::Ui::Controls::Form& source);

	virtual bool OnHttpAuthenticationRequestedN(const Tizen::Base::String& host, const Tizen::Base::String& realm, const Tizen::Web::Controls::AuthenticationChallenge& authentication);
	virtual void OnHttpAuthenticationCanceled(void);
	virtual void OnLoadingStarted(void);
	virtual void OnLoadingCanceled(void);
	virtual void OnLoadingErrorOccurred(Tizen::Web::Controls::LoadingErrorType error, const Tizen::Base::String& reason);
	virtual void OnLoadingCompleted(void);
	virtual void OnEstimatedProgress(int progress);
	virtual void OnPageTitleReceived(const Tizen::Base::String& title);
	virtual bool OnLoadingRequested(const Tizen::Base::String& url, Tizen::Web::Controls::WebNavigationType type);
	virtual Tizen::Web::Controls::DecisionPolicy OnWebDataReceived(const Tizen::Base::String& mime, const Tizen::Net::Http::HttpHeader& header);

	virtual void OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId,
										const Tizen::Ui::Scenes::SceneId& nextSceneId);
	virtual void OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId, const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs);
	void loadURLPage(void);
	void StartConectMarket(void);

	// IHttpResponseEventListener
//	virtual void OnResponseReceived(const Tizen::Base::String &responseStr);
//	virtual void OnUserEventReceivedN(RequestId requestId, Tizen::Base::Collection::IList *pArgs);



private:
	Tizen::Web::Controls::AuthenticationChallenge *pAuthenticationChallenge;
//	HttpCommunicationService			*__pHttpService;
};

#endif /* MYHONDANAMARKETFORM_H_ */
