/*
 * MyHondanaHelpForm.cpp
 *
 *  Created on: Jun 18, 2013
 *      Author: sihong
 */

#include <FBase.h>
#include <FSysPowerManager.h>
#include "MyHondanaHelpForm.h"
#include "SceneRegister.h"

using namespace Tizen::Base;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Web;
using namespace Tizen::Web::Controls;
using namespace Tizen::Web::Json;
using namespace Tizen::Graphics;
using namespace Tizen::Ui::Scenes;
using namespace Tizen::Net::Http;

//const wchar_t* USER_AGENT = L"Mozilla/5.0 (Linux; Tizen 2.2; SEC-SC-001) AppleWebKit/537.3 (KHTML, like Gecko) Version/2.2 Mobile Safari/537.3";
const String USER_AGENT = L"Mozilla/5.0 (Linux; Tizen 2.2; SEC-SC-001) AppleWebKit/537.3 (KHTML, like Gecko) Version/2.2 Mobile Safari/537.3";
const String IMEI = L"351990050045845";

MyHondanaHelpForm::MyHondanaHelpForm(void)
{
}


MyHondanaHelpForm::~MyHondanaHelpForm(void)
{
}

bool
MyHondanaHelpForm::Initialize()
{
    // Construct an XML form
    Construct(L"IDF_MY_HONDANA_HELP_FORM");
//	SetOrientation(ORIENTATION_LANDSCAPE);

//	this->Construct(L"IDF_MY_HONDANA_Help_FORM", FORM_STYLE_NORMAL | FORM_STYLE_INDICATOR | FORM_STYLE_FOOTER);

    return true;
}

result
MyHondanaHelpForm::OnInitializing(void)
{
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
/*
    pWeb = new Web();
    pWeb->Construct(Rectangle(0, 0, this->GetWidth(), this->GetHeight()));

    AddControl(*pWeb);
    String url("http://stg.book.dmkt-sp.jp/top?seed=970&type=81&data=uWVM2Pj0uxBkgngXOUzEScW3e8LASuow%2Bg%2B%2F0m8%2BJcSkXkWtDWGx4vv2Mo7%2BxgiJKuqxP71kvlX6bmg%2BXR6CDLxax0J9riofyDvRrJ9HZgcWrmXn6dTvKBYvdglVn11p05%2FJ6yI%2Fz0I%2BB%2FrNsYxB37j3jVWo1XloCTXZLZEyCwEVq64XPYYDeImuu6oxI1KF7DeMZaXuGTA9cT2gyy08mDVNhZ3LDjV%2Bru8eR6aVauIKpAq7eztEXe7Rw6ijVVXDF7uFtwo4y6TfAa%2F8iOctx2DLB4WFPKj1R1NG1kVEZ8fthAtNmYgWDPgLChkyRgAmBZ8alR%2FIYKLE6fnPoZUBt0DD18PWQh9IkXGTvT5y%2BKm4RymwADjEzBUkq76DSjcdhikTZB%2FAUVJP1rXES%2BqXgIrtN8Q1C9LpSxKgTg55VutsdvPTznT3aw%3D%3D&docomoIdFlg=&utm_source=01app&utm_medium=1&utm_campaign=1");

    WebSetting setting;
    setting.SetUserAgent(USER_AGENT);
    pWeb->LoadUrl(url);
*/
    return r;
}

result
MyHondanaHelpForm::OnTerminating(void)
{
    result r = E_SUCCESS;

    return r;
}

void
MyHondanaHelpForm::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{

}

void
MyHondanaHelpForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	pSceneManager->GoBackward(BackwardSceneTransition());
}

void MyHondanaHelpForm::OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId,
									const Tizen::Ui::Scenes::SceneId& nextSceneId)
{
}

void
MyHondanaHelpForm::OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId, const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs)
{
}

void
MyHondanaHelpForm::loadURLPage(void)
{
	AppLog("MyHondanaLoginForm::loadURLPage()");

    pWeb = new Web();

    pWeb->Construct(Rectangle(0, 0, this->GetWidth(), this->GetHeight()));
    pWeb->SetLoadingListener(this);

    AddControl(*pWeb);
    String url("http://stg.book.dmkt-sp.jp/top?seed=970&type=81&data=uWVM2Pj0uxBkgngXOUzEScW3e8LASuow%2Bg%2B%2F0m8%2BJcSkXkWtDWGx4vv2Mo7%2BxgiJKuqxP71kvlX6bmg%2BXR6CDLxax0J9riofyDvRrJ9HZgcWrmXn6dTvKBYvdglVn11p05%2FJ6yI%2Fz0I%2BB%2FrNsYxB37j3jVWo1XloCTXZLZEyCwEVq64XPYYDeImuu6oxI1KF7DeMZaXuGTA9cT2gyy08mDVNhZ3LDjV%2Bru8eR6aVauIKpAq7eztEXe7Rw6ijVVXDF7uFtwo4y6TfAa%2F8iOctx2DLB4WFPKj1R1NG1kVEZ8fthAtNmYgWDPgLChkyRgAmBZ8alR%2FIYKLE6fnPoZUBt0DD18PWQh9IkXGTvT5y%2BKm4RymwADjEzBUkq76DSjcdhikTZB%2FAUVJP1rXES%2BqXgIrtN8Q1C9LpSxKgTg55VutsdvPTznT3aw%3D%3D&docomoIdFlg=&utm_source=01app&utm_medium=1&utm_campaign=1");

    WebSetting setting;

    setting.SetUserAgent(USER_AGENT);
    setting.SetJavascriptEnabled(true);

//    mAuthenticationChallenge.Process("sol", "sol01");


    pWeb->LoadUrl(url);

    Tizen::Base::String  mGetURL = pWeb->GetUrl();

   	AppLog("loadURLPage() mGetURL = %S", (char*)mGetURL.GetPointer());

}



bool
MyHondanaHelpForm::OnHttpAuthenticationRequestedN(const Tizen::Base::String& host, const Tizen::Base::String& realm, const Tizen::Web::Controls::AuthenticationChallenge& authentication)
{
	return false;
}

void
MyHondanaHelpForm::OnHttpAuthenticationCanceled(void)
{
}

void
MyHondanaHelpForm::OnLoadingStarted(void)
{
//	SetButtonCancelImage();
}

void
MyHondanaHelpForm::OnLoadingCanceled(void)
{
//	SetButtonGotoImage();
}

void
MyHondanaHelpForm::OnLoadingErrorOccurred(LoadingErrorType error, const String& reason)
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
MyHondanaHelpForm::OnLoadingCompleted(void)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

//	SetUrl(__pWeb->GetUrl());
//	SetButtonGotoImage();
    Tizen::Base::String  mGetURL = pWeb->GetUrl();
   	AppLog("OnLoadingCompleted() mGetURL = %S", (char*)mGetURL.GetPointer());

   	if(mGetURL == "http://stg.book.dmkt-sp.jp/api/user/loginresult")
   	{
		pSceneManager->GoForward(ForwardSceneTransition(SCENE_MAIN));
   	}
}

void
MyHondanaHelpForm::OnEstimatedProgress(int progress)
{
}

void
MyHondanaHelpForm::OnPageTitleReceived(const Tizen::Base::String& title)
{
}

bool
MyHondanaHelpForm::OnLoadingRequested(const Tizen::Base::String& url, WebNavigationType type)
{
	AppLog("%S",url.GetPointer());

//	SetUrl(url);
	return false;
}

DecisionPolicy
MyHondanaHelpForm::OnWebDataReceived(const Tizen::Base::String& mime, const Tizen::Net::Http::HttpHeader& header)
{
	return WEB_DECISION_CONTINUE;
}
