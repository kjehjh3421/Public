/*
 * MyHondanaLoginForm.h
 *
 *  Created on: Jun 18, 2013
 *      Author: sihong
 */

#ifndef MYHONDANALOGINFORM_H_
#define MYHONDANALOGINFORM_H_

#include "HttpCommunicationService.h"
#include <FBase.h>
#include <FUi.h>
#include <FWeb.h>


using namespace Tizen::Web;
using namespace Tizen::Web::Controls;
using namespace Tizen::Web::Json;

class MyHondanaLoginForm
	: public Tizen::Ui::Controls::Form
	, public Tizen::Ui::IActionEventListener
	, public Tizen::Ui::Controls::IFormBackEventListener
	, public Tizen::Web::Controls::ILoadingListener
 	, public Tizen::Ui::Scenes::ISceneEventListener
{
public:
	MyHondanaLoginForm(void);
	~MyHondanaLoginForm(void);
	bool Initialize(void);

protected:
	Tizen::Web::Controls::Web *pWeb;
	const IJavaScriptBridge *JsBridge1;

public:
    virtual result OnInitializing(void);
    virtual result OnTerminating(void);
	virtual void OnActionPerformed(const Tizen::Ui::Control& source, int actionId);
	virtual void HandleJavaScriptRequestN(Tizen::Web::Json::IJsonValue* pArg);

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
	void SetLogin(void);

private:
	HttpCommunicationService			*__pHttpService;
};

#endif /* MYHONDANALOGINFORM_H_ */
