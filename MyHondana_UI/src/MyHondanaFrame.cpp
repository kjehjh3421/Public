#include "MyHondanaFrame.h"
#include "SceneRegister.h"
#include <FNet.h>
#include <FIo.h>
#include <FApp.h>


using namespace Tizen::Base;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Ui::Scenes;
using namespace Tizen::Net::Http;
using namespace Tizen::Io;
using namespace Tizen::App;

namespace
{
	enum
	{
		STATUS_LOGIN = 100,
		STATUS_LOGOUT = 101
	};

int mLoginMode = STATUS_LOGIN;
}

MyHondanaFrame::MyHondanaFrame(void)
{
}

MyHondanaFrame::~MyHondanaFrame(void)
{
}

result
MyHondanaFrame::OnInitializing(void)
{
//	HttpSession* pSession = null;
//	HttpCookieStorageManager* pCookieStorageManager = null;
//	String cookie = findSessionId(cookies);

	CheckLogin();



	// Prepare Scene management.
	SceneRegister::RegisterAllScenes();
	SceneManager* pSceneManager = SceneManager::GetInstance();
	result r;
	AppAssert(pSceneManager);

//	String cookie = HttpCommunicationService::findSessionId(cookies);
//	pSession = new HttpSession();
//	pCookieStorageManager = pSession->GetCookieStorageManager();
//	pCookieStorageManager->GetCookies()
//
	// Go to the scene.
	if(mLoginMode==STATUS_LOGOUT)
	{
//		r = pSceneManager->GoForward(ForwardSceneTransition(SCENE_LOGIN));
		r = pSceneManager->GoForward(ForwardSceneTransition(SCENE_MAIN));
//		mLoginMode=STATUS_LOGIN;
	}
	else if(mLoginMode==STATUS_LOGIN)
	{
		r = pSceneManager->GoForward(ForwardSceneTransition(SCENE_MAIN));
	}
	TryReturn(!IsFailed(r), r, "%s", GetErrorMessage(r));

	// TODO: Add your initialization code here
	return r;
}

result
MyHondanaFrame::OnTerminating(void)
{
	result r = E_SUCCESS;

	// TODO:
	// Add your termination code here
	return r;
}

void
MyHondanaFrame::CheckLogin(void)
{
	Registry reg;
	String regPathName(L"MyhondanaReg.ini");

	// Section name
	String sect_UserMyId(L"UserMyId");

	// Entry name
	String entry_UserID(L"UserID");
	String entry_SessionID(L"SessionID");

	int iVal = null;
	result r;

	r = reg.Construct(App::GetInstance()->GetAppDataPath() + regPathName, "a+");

    // Get value: section1 { entry1 = ? }
	r = reg.GetValue(sect_UserMyId, entry_UserID, iVal);

	if(IsFailed(r))
	{
		mLoginMode = STATUS_LOGOUT;
	}
	else
	{
		if(iVal == null)
			mLoginMode = STATUS_LOGOUT; //STATUS_LOGIN;
		else
			mLoginMode = STATUS_LOGIN;
//			mLoginMode = STATUS_LOGOUT;
	}


/*
	char buf[1];
	char chkChar;
	File file;
	String filePath = App::GetInstance()->GetAppDataPath() + L"LoginCheck.txt";

	//Read File Content into buffer
	result r = file.Construct(filePath, L"w+");

	if(IsFailed(r))
	{
		mLoginMode = STATUS_LOGOUT;
	}
	else
	{
		FileAttributes att;
		r = File::GetAttributes(filePath, att);

		long long size = att.GetFileSize();


		chkChar = buf[0];

		if(chkChar)
			mLoginMode = STATUS_LOGOUT; //STATUS_LOGIN;
		else
			mLoginMode = STATUS_LOGOUT;
	}
*/
}

