#include "MyHondanaFormFactory.h"
#include "MyHondanaMainForm.h"
#include "MyHondanaDetailForm.h"
#include "MyHondanaMarketForm.h"
#include "MyHondanaDeleteForm.h"
#include "MyHondanaSettingForm.h"
#include "MyHondanaLoginForm.h"
#include "MyHondanaViewerForm.h"
#include "MyHondanaViewerMoveForm.h"
#include "MyHondanaHelpForm.h"

using namespace Tizen::Ui::Scenes;

const wchar_t* FORM_MAIN = L"IDF_MY_HONDANA_MAIN_FORM";
const wchar_t* FORM_DETAIL = L"IDF_MY_HONDANA_DETAIL_FORM";
const wchar_t* FORM_MARKET = L"IDF_MY_HONDANA_MARKET_FORM";
const wchar_t* FORM_DELETE = L"IDF_MY_HONDANA_DELETE_FORM";
const wchar_t* FORM_SETTING = L"IDF_MY_HONDANA_SETTING_FORM";
const wchar_t* FORM_LOGIN = L"IDF_MY_HONDANA_LOGIN_FORM";
const wchar_t* FORM_VIEWER = L"IDF_MY_HONDANA_VIEWER_FORM";
const wchar_t* FORM_VIEWERMOVE = L"IDF_MY_HONDANA_VIEWERMOVE_FORM";
const wchar_t* FORM_HELP = L"IDF_MY_HONDANA_HELP_FORM";

MyHondanaFormFactory::MyHondanaFormFactory(void)
{
}

MyHondanaFormFactory::~MyHondanaFormFactory(void)
{
}

Tizen::Ui::Controls::Form*
MyHondanaFormFactory::CreateFormN(const Tizen::Base::String& formId, const Tizen::Ui::Scenes::SceneId& sceneId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	Tizen::Ui::Controls::Form* pNewForm = null;

	if (formId == FORM_MAIN)
	{
		MyHondanaMainForm* pForm = new (std::nothrow) MyHondanaMainForm();
		pForm->Initialize();
		pNewForm = pForm;
	}
	else if (formId == FORM_LOGIN)
	{
		MyHondanaLoginForm* pLoginForm = new (std::nothrow) MyHondanaLoginForm();
		pLoginForm->Initialize();
		pSceneManager->AddSceneEventListener(sceneId, *pLoginForm);
		pNewForm = pLoginForm;
	}
	else if (formId == FORM_DETAIL)
	{
		MyHondanaDetailForm* pForm = new (std::nothrow) MyHondanaDetailForm();
		pForm->Initialize();
		pSceneManager->AddSceneEventListener(sceneId, *pForm);
		pNewForm = pForm;
	}
	else if (formId == FORM_MARKET)
	{
		MyHondanaMarketForm* pMarketForm = new (std::nothrow) MyHondanaMarketForm();
		pMarketForm->Initialize();
		pSceneManager->AddSceneEventListener(sceneId, *pMarketForm);
		pNewForm = pMarketForm;
	}
	else if (formId == FORM_DELETE)
	{
		MyHondanaDeleteForm* pDeleteForm = new (std::nothrow) MyHondanaDeleteForm();
		pDeleteForm->Initialize();
		pSceneManager->AddSceneEventListener(sceneId, *pDeleteForm);
		pNewForm = pDeleteForm;
	}
	else if (formId == FORM_SETTING)
	{
		MyHondanaSettingForm* pSettingForm = new (std::nothrow) MyHondanaSettingForm();
		pSettingForm->Initialize();
		pSceneManager->AddSceneEventListener(sceneId, *pSettingForm);
		pNewForm = pSettingForm;
	}
	else if (formId == FORM_VIEWER)
	{
		MyHondanaViewerForm* pViewerForm = new (std::nothrow) MyHondanaViewerForm();
		pViewerForm->Initialize();
		pSceneManager->AddSceneEventListener(sceneId, *pViewerForm);
		pNewForm = pViewerForm;
	}
	else if (formId == FORM_VIEWERMOVE)
	{
		MyHondanaViewerMoveForm* pViewerMoveForm = new (std::nothrow) MyHondanaViewerMoveForm();
		pViewerMoveForm->Initialize();
		pSceneManager->AddSceneEventListener(sceneId, *pViewerMoveForm);
		pNewForm = pViewerMoveForm;
	}
	else if (formId == FORM_HELP)
	{
		MyHondanaHelpForm* pHelpForm = new (std::nothrow) MyHondanaHelpForm();
		pHelpForm->Initialize();
		pSceneManager->AddSceneEventListener(sceneId, *pHelpForm);
		pNewForm = pHelpForm;
	}

	return pNewForm;
}
