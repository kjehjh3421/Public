/*
 * MyHondanaMarketForm.cpp
 *
 *  Created on: Jun 18, 2013
 *      Author: sihong
 */

#include <FBase.h>
#include <FSysPowerManager.h>
#include "MyHondanaMarketForm.h"
#include "SceneRegister.h"
#include <FNet.h>

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

MyHondanaMarketForm::MyHondanaMarketForm(void)
{
}


MyHondanaMarketForm::~MyHondanaMarketForm(void)
{
}

bool
MyHondanaMarketForm::Initialize()
{
    // Construct an XML form
    Construct(L"IDF_MY_HONDANA_MARKET_FORM");
//	SetOrientation(ORIENTATION_LANDSCAPE);

//	this->Construct(L"IDF_MY_HONDANA_MARKET_FORM", FORM_STYLE_NORMAL | FORM_STYLE_INDICATOR | FORM_STYLE_FOOTER);
//	__pHttpService = new HttpCommunicationService(this);

    return true;
}

result
MyHondanaMarketForm::OnInitializing(void)
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
MyHondanaMarketForm::OnTerminating(void)
{
    result r = E_SUCCESS;

    return r;
}

void
MyHondanaMarketForm::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{

}

void
MyHondanaMarketForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	pSceneManager->GoBackward(BackwardSceneTransition());
}

void MyHondanaMarketForm::OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId,
									const Tizen::Ui::Scenes::SceneId& nextSceneId)
{
}

void
MyHondanaMarketForm::OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId, const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs)
{
}

void
MyHondanaMarketForm::loadURLPage(void)
{
	AppLog("MyHondanaMarketForm::loadURLPage()");
//	Tizen::Net::Http::HttpHeader* pHeader;

//	String mUserID = L"sol";
//	String mPassword = L"sol01";

    pWeb = new Web();

    pWeb->Construct(Rectangle(0, 0, this->GetWidth(), this->GetHeight()));
    AddControl(*pWeb);

    pWeb->SetLoadingListener(this);

    WebSetting setting;

    setting.SetUserAgent(USER_AGENT);
    setting.SetJavascriptEnabled(true);

    String url("http://stg.book.dmkt-sp.jp/top?seed=970&type=81&data=uWVM2Pj0uxBkgngXOUzEScW3e8LASuow%2Bg%2B%2F0m8%2BJcSkXkWtDWGx4vv2Mo7%2BxgiJKuqxP71kvlX6bmg%2BXR6CDLxax0J9riofyDvRrJ9HZgcWrmXn6dTvKBYvdglVn11p05%2FJ6yI%2Fz0I%2BB%2FrNsYxB37j3jVWo1XloCTXZLZEyCwEVq64XPYYDeImuu6oxI1KF7DeMZaXuGTA9cT2gyy08mDVNhZ3LDjV%2Bru8eR6aVauIKpAq7eztEXe7Rw6ijVVXDF7uFtwo4y6TfAa%2F8iOctx2DLB4WFPKj1R1NG1kVEZ8fthAtNmYgWDPgLChkyRgAmBZ8alR%2FIYKLE6fnPoZUBt0DD18PWQh9IkXGTvT5y%2BKm4RymwADjEzBUkq76DSjcdhikTZB%2FAUVJP1rXES%2BqXgIrtN8Q1C9LpSxKgTg55VutsdvPTznT3aw%3D%3D&docomoIdFlg=&utm_source=01app&utm_medium=1&utm_campaign=1");

    pWeb->LoadUrl(url);

    Tizen::Base::String  mGetURL = pWeb->GetUrl();
   	AppLog("loadURLPage() mGetURL = %S", (char*)mGetURL.GetPointer());
}



bool
MyHondanaMarketForm::OnHttpAuthenticationRequestedN(const Tizen::Base::String& host, const Tizen::Base::String& realm, const Tizen::Web::Controls::AuthenticationChallenge& authentication)
{
   	AppLog("OnHttpAuthenticationRequestedN() host = %S", (char*)host.GetPointer());
   	AppLog("OnHttpAuthenticationRequestedN() realm = %S", (char*)realm.GetPointer());
//   	AppLog("OnHttpAuthenticationRequestedN() authentication = %d", &authentication);

	AppLog("OnHttpAuthenticationRequestedN() ");

	pAuthenticationChallenge = (Tizen::Web::Controls::AuthenticationChallenge*)&authentication;
	pAuthenticationChallenge->Process(L"sol", L"sol01");

//	return false;
	return true;
}

void
MyHondanaMarketForm::OnHttpAuthenticationCanceled(void)
{
   	AppLog("OnHttpAuthenticationCanceled() ");
}

void
MyHondanaMarketForm::OnLoadingStarted(void)
{
   	AppLog("OnLoadingStarted() ");
}

void
MyHondanaMarketForm::OnLoadingCanceled(void)
{
   	AppLog("OnLoadingCanceled() ");
}

void
MyHondanaMarketForm::OnLoadingErrorOccurred(LoadingErrorType error, const String& reason)
{
   	AppLog("OnLoadingErrorOccurred() ");
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
}

void
MyHondanaMarketForm::OnLoadingCompleted(void)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

    Tizen::Base::String  mGetURL = pWeb->GetUrl();
   	AppLog("OnLoadingCompleted() mGetURL = %S", (char*)mGetURL.GetPointer());

//   	if(mGetURL == "http://stg.book.dmkt-sp.jp/api/user/loginresult")
//   	{
//		pSceneManager->GoForward(ForwardSceneTransition(SCENE_MAIN));
//   	}
}

void
MyHondanaMarketForm::OnEstimatedProgress(int progress)
{
   	AppLog("OnEstimatedProgress()");
}

void
MyHondanaMarketForm::OnPageTitleReceived(const Tizen::Base::String& title)
{
   	AppLog("OnPageTitleReceived()");
}

bool
MyHondanaMarketForm::OnLoadingRequested(const Tizen::Base::String& url, WebNavigationType type)
{
   	AppLog("OnLoadingRequested()");
	AppLog("%S",url.GetPointer());

	return false;
}

DecisionPolicy
MyHondanaMarketForm::OnWebDataReceived(const Tizen::Base::String& mime, const Tizen::Net::Http::HttpHeader& header)
{
   	AppLog("OnWebDataReceived()");
	return WEB_DECISION_CONTINUE;
//	return WEB_DECISION_IGNORE;
//	return WEB_DECISION_DOWNLOAD;
}

/*
void
MyHondanaMarketForm::OnUserEventReceivedN(RequestId requestId, IList *pArgs)
{

	AppLog ("OnUserEventReceivedN");
	String *pMessage;
	AppLog("2");

	switch(requestId)
	{
		case 100:
			AppLog("3");


			Invalidate(true);
			AppLog("4");
			break;
	}
}

void
MyHondanaMarketForm::OnResponseReceived(const String &responseStr)
{
	AppLog("OnResponseReceived[%d] : %ls", responseStr.GetLength(), responseStr.GetPointer());
}




void
MyHondanaMarketForm::StartConectMarket(void)
{
	HashMap* map = new HashMap();
	map->Construct();
	map->Add(new String(L"offset"),new String(L"0"));

	map->Add(new String(L"IMEI"),new String(L"351990050045845"));

	map->Add(new String(URI), new String(L"http://stg.book.dmkt-sp.jp/top?seed=730&type=232&data=NmO%2Bv82nzmtF28QCnwvFsesrrt9nHV6ur%2Bdz9csu9qe4yrdaqyxpxH5Do%2Bh1RuQecwfcdk7h5fP2kAYWxqKmfRXkOyOBDx3AFCFO5eH003AWAFdcmKyGHFYjO%2Bk2vca%2Bq1NyF1iyUWQjzdOpHCBDkgZgoktPSHlFVM3KbPM3Dwyp7b1u3CvJnc22XgmQ0j7qB3NLtBpto64NUtNf8SUKfOCoS1iSujQWz36cAKdGnkaoOUEaAe%2B5pDX%2FLN%2BOr97nU%2F%2B%2FfZmqgVmG%2B%2Fo7i%2F2l%2FijkNpyopA94dn%2FFwsYMWBSr9nUk113q2yLNUNKho%2B7prk%2FC72wrfNKwnHguBo6nXSwW6m78UicDKU9tggJeALDZ7Blbdk17pCIgLmth%2BzcNmwsOY30mAk%2BFegzjBCP3qxUoIjeCmgO7LkPSFGrIfddQZEdOjZy5%2FvjRZ6Calnnx&docomoIdFlg=&utm_source=01app&utm_medium=1&utm_campaign=1"));

	String mUserAgent = L"Mozilla/5.0 (Linux; Tizen 2.2; SEC-SC-001) AppleWebKit/537.3 (KHTML, like Gecko) Version/2.2 Mobile Safari/537.3";

	__pHttpService->postRequest(map, App::GetInstance(), mUserAgent);
}
*/
