//
// Tizen C++ SDK
// Copyright (c) 2012 Samsung Electronics Co., Ltd.
//
// Licensed under the Flora License, Version 1.0 (the License);
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://floralicense.org/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an AS IS BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

#include "SceneRegister.h"
#include "MyHondanaFormFactory.h"
#include "MyHondanaPanelFactory.h"

#include <FUi.h>

using namespace Tizen::Ui::Scenes;


// Definitions of extern.
const wchar_t* SCENE_MAIN = L"ScnMain";
const wchar_t* SCENE_DETAIL = L"ScnDetail";
const wchar_t* SCENE_MARKET = L"ScnMarket";
const wchar_t* SCENE_DELETE = L"ScnDelete";
const wchar_t* SCENE_SETTING = L"ScnSetting";
const wchar_t* SCENE_LOGIN = L"ScnLogin";
const wchar_t* SCENE_VIEWER = L"ScnViewer";
const wchar_t* SCENE_VIEWERMOVE = L"ScnViewerMove";
const wchar_t* SCENE_HELP = L"ScnHelp";


SceneRegister::SceneRegister(void)
{
}

SceneRegister::~SceneRegister(void)
{
}

void
SceneRegister::RegisterAllScenes(void)
{
	static const wchar_t* PANEL_BLANK = L"";
	static MyHondanaFormFactory formFactory;
	static MyHondanaPanelFactory panelFactory;

	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	pSceneManager->RegisterFormFactory(formFactory);
	pSceneManager->RegisterPanelFactory(panelFactory);

	pSceneManager->RegisterScene(SCENE_MAIN, FORM_MAIN, PANEL_BLANK);
	pSceneManager->RegisterScene(SCENE_DETAIL, FORM_DETAIL, PANEL_BLANK);
	pSceneManager->RegisterScene(SCENE_MARKET, FORM_MARKET, PANEL_BLANK);
	pSceneManager->RegisterScene(SCENE_DELETE, FORM_DELETE, PANEL_BLANK);
	pSceneManager->RegisterScene(SCENE_SETTING, FORM_SETTING, PANEL_BLANK);
	pSceneManager->RegisterScene(SCENE_LOGIN, FORM_LOGIN, PANEL_BLANK);
	pSceneManager->RegisterScene(SCENE_VIEWER, FORM_VIEWER, PANEL_BLANK);
	pSceneManager->RegisterScene(SCENE_VIEWERMOVE, FORM_VIEWERMOVE, PANEL_BLANK);
	pSceneManager->RegisterScene(SCENE_HELP, FORM_HELP, PANEL_BLANK);

}



