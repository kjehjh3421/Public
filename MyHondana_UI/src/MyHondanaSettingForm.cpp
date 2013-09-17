#include <new>
#include <FApp.h>
#include <FGraphics.h>
#include <FAppUiApp.h>
#include <FBase.h>
#include "MyHondanaSettingForm.h"
#include "SceneRegister.h"
#include "AppResourceId.h"
#include "FUiLayout.h"
#include "FUiRelativeLayout.h"
#include "FMedia.h"

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Graphics;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Media;
using namespace Tizen::Ui::Scenes;
using namespace Tizen::Ui::Animations;
using namespace Tizen::Base::Collection;

const wchar_t LIST_IMAGE_PATH1[] = L"book02.png";
const wchar_t LIST_IMAGE_PATH2[] = L"book02.png";
const wchar_t LIST_IMAGE_PATH3[] = L"list_new_book_icon.png";
const wchar_t LIST_IMAGE_PATH4[] = L"grid_new_book_icon.png";
const wchar_t LIST_IMAGE_PATH5[] = L"list_bottom_text.png";
const wchar_t LIST_IMAGE_PATH6[] = L"grid_bottom_text.png";

const wchar_t HEADER_BACKGROUND[] = L"header_background.png";

namespace
{
	enum
	{
//		THUMBNAIL = 100,
//		LIST = THUMBNAIL + 0x01,

		ID_BUTTON_BASE     = 110,
		ID_BUTTON_COVERFLOW = ID_BUTTON_BASE + 0x00,
		ID_BUTTON_MARKET 	= ID_BUTTON_BASE + 0x01,
		ID_BUTTON_ACTIONBAR = ID_BUTTON_BASE + 0x02,
		ID_BUTTON_OPTION = ID_BUTTON_BASE + 0x03,
		ID_EXIT = ID_BUTTON_BASE + 0x03,
		ID_CONTEXT_OPTION_ITEM1 = ID_BUTTON_BASE + 0x11, // ContextMenu : Option Item1 - Renewal
		ID_CONTEXT_OPTION_ITEM2 = ID_BUTTON_BASE + 0x12, // ContextMenu : Option Item2 - Delete
		ID_CONTEXT_OPTION_ITEM3 = ID_BUTTON_BASE + 0x13, // ContextMenu : Option Item3 - Download
		ID_CONTEXT_OPTION_ITEM4 = ID_BUTTON_BASE + 0x14, // ContextMenu : Option Item4 - Setting
		ID_CONTEXT_OPTION_ITEM5 = ID_BUTTON_BASE + 0x15, // ContextMenu : Option Item5 - help
	};
bool isFirstStart = true;
}

MyHondanaSettingForm::MyHondanaSettingForm(void)
{
}

MyHondanaSettingForm::~MyHondanaSettingForm(void)
{
}

bool
MyHondanaSettingForm::Initialize(void)
{
	RelativeLayout relativeLayout;
	relativeLayout.Construct();
	this->Construct(relativeLayout, FORM_STYLE_NORMAL | FORM_STYLE_INDICATOR | FORM_STYLE_HEADER);

	return true;
}

result
MyHondanaSettingForm::OnInitializing(void)
{
	result r = E_SUCCESS;
	Control::OnInitializing();

	SetOrientation(ORIENTATION_AUTOMATIC);
	AddOrientationEventListener(*this);
	SetFormBackEventListener(this);
	this->SetBackgroundColor(Color::GetColor(COLOR_ID_BLACK));



	SetHeader();
	SetPanel();
	SetButton();
		
	return r;
}

result
MyHondanaSettingForm::OnTerminating(void)
{
	result r = E_SUCCESS;
	return r;
}

void
MyHondanaSettingForm::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
    switch(actionId)
    {
    default:
        break;
    }
}

void
MyHondanaSettingForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	pSceneManager->GoBackward(BackwardSceneTransition());
}

void
MyHondanaSettingForm::SetHeader(void)
{
	AppResource *pAppResource = App::GetInstance()->GetAppResource();

	// Create header
	Header * pHeader = GetHeader();
	if (pHeader != null) {
		ButtonItem  buttonLeftItem;
		buttonLeftItem.Construct(BUTTON_ITEM_STYLE_ICON, ID_BUTTON_MARKET);
		buttonLeftItem.SetIcon(BUTTON_ITEM_STATUS_NORMAL, pAppResource->GetBitmapN(L"btn_market_normal.png"));
		buttonLeftItem.SetIcon(BUTTON_ITEM_STATUS_PRESSED, pAppResource->GetBitmapN(L"btn_market_pressed.png"));

		ButtonItem  buttonRightItem;
		buttonRightItem.Construct(BUTTON_ITEM_STYLE_ICON, ID_BUTTON_ACTIONBAR);
		buttonRightItem.SetIcon(BUTTON_ITEM_STATUS_NORMAL, pAppResource->GetBitmapN(L"btn_actionbar.png"));
		buttonRightItem.SetIcon(BUTTON_ITEM_STATUS_PRESSED, pAppResource->GetBitmapN(L"btn_actionbar_press.png"));

		pHeader->SetStyle(HEADER_STYLE_TITLE);
		pHeader->SetBackgroundBitmap(pAppResource->GetBitmapN(L"header_background.png"));
		pHeader->SetTitleText(L"マイ本棚");
//		pHeader->SetTitleIcon(pAppResource->GetBitmapN(L"icon.png"));

		pHeader->SetTitleTextColor(Color::GetColor(COLOR_ID_WHITE));
		pHeader->SetButton(BUTTON_POSITION_RIGHT, buttonRightItem);
		pHeader->SetButton(BUTTON_POSITION_LEFT, buttonLeftItem);
	}
	pHeader->AddActionEventListener(*this);
}

void
MyHondanaSettingForm::SetPanel(void)
{
	RelativeLayout* pRelativeLayout = dynamic_cast<RelativeLayout*>(this->GetLayoutN());

	//*********************************Portrait******************************************
	Panel* pPanel_Portrait;
	__pBackgroundPanel = new (std::nothrow) Panel();
	__pBackgroundPanel->Construct(Rectangle(0, this->GetHeight()-200, this->GetWidth(), this->GetHeight()));
	pPanel_Portrait = __pBackgroundPanel;
	this->AddControl(pPanel_Portrait);

	pPanel_Portrait->SetBackgroundColor(0xff9999ff);
	pRelativeLayout->SetRelation(*pPanel_Portrait, this,	RECT_EDGE_RELATION_LEFT_TO_LEFT);
	pRelativeLayout->SetRelation(*pPanel_Portrait, this,	RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
	pRelativeLayout->SetRelation(*pPanel_Portrait, this,	RECT_EDGE_RELATION_BOTTOM_TO_BOTTOM);

		//*********************************Landscape******************************************
	Panel* pPanel_Landscape;
	__pBackgroundPanel_Landscape = new (std::nothrow) Panel();
	__pBackgroundPanel_Landscape->Construct(Rectangle(0, this->GetHeight()-150, this->GetWidth(), this->GetHeight()));
	pPanel_Landscape = __pBackgroundPanel_Landscape;
	this->AddControl(pPanel_Landscape);

	pPanel_Landscape->SetBackgroundColor(0xff9999ff);
	pRelativeLayout->SetRelation(*pPanel_Landscape, this,	RECT_EDGE_RELATION_LEFT_TO_LEFT);
	pRelativeLayout->SetRelation(*pPanel_Landscape, this,	RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
	pRelativeLayout->SetRelation(*pPanel_Landscape, this,	RECT_EDGE_RELATION_BOTTOM_TO_BOTTOM);

	delete pRelativeLayout;

}

void
MyHondanaSettingForm::SetButton(void)
{
	AppResource *pAppResource = App::GetInstance()->GetAppResource();

	//*********************************portrait******************************************
	Panel&          pCoverFlowOn_Thumbnail  = *__pBackgroundPanel;
	pCoverFlowOn_Thumbnail.SetBackgroundColor(0xff222222);

	__pButton1 = new (std::nothrow) Button;
	__pButton1->Construct(Rectangle(0, this->GetHeight()-230, 180, 112), "");
	__pButton1->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_move.png"));
	__pButton1->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_move_pressed.png"));
	__pButton1->SetActionId(ID_BUTTON1);
	__pButton1->AddActionEventListener(*this);
	pCoverFlowOn_Thumbnail.AddControl(__pButton1);

	__pButton2 = new (std::nothrow) Button;
	__pButton2->Construct(Rectangle(180, this->GetHeight()-230, 180, 112), "");
	__pButton2->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_next.png"));
	__pButton2->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_next_pressed.png"));
	__pButton2->SetActionId(ID_BUTTON2);
	__pButton2->AddActionEventListener(*this);
	pCoverFlowOn_Thumbnail.AddControl(__pButton2);

	__pButton3 = new (std::nothrow) Button;
	__pButton3->Construct(Rectangle(360, this->GetHeight()-230, 180, 112), "");
	__pButton3->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_setting.png"));
	__pButton3->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_setting_pressed.png"));
	__pButton3->SetActionId(ID_BUTTON3);
	__pButton3->AddActionEventListener(*this);
	pCoverFlowOn_Thumbnail.AddControl(__pButton3);

	__pButton4 = new (std::nothrow) Button;
	__pButton4->Construct(Rectangle(540, this->GetHeight()-230, 180, 112), "");
	__pButton4->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_help.png"));
	__pButton4->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_help_pressed.png"));
	__pButton4->SetActionId(ID_BUTTON4);
	__pButton4->AddActionEventListener(*this);
	pCoverFlowOn_Thumbnail.AddControl(__pButton4);

	__pBookMarkButton = new (std::nothrow) Button;
	__pBookMarkButton->Construct(Rectangle(0, this->GetHeight()-118, 118, 118), "");
	__pBookMarkButton->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"bookmark.png"));
	__pBookMarkButton->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"bookmark.png"));
	__pBookMarkButton->SetActionId(ID_BUTTON5);
	__pBookMarkButton->AddActionEventListener(*this);
	pCoverFlowOn_Thumbnail.AddControl(__pBookMarkButton);

	__pLabel = new(std::nothrow) Label;
	__pLabel->Construct(Rectangle(118, this->GetHeight()-118, this->GetWidth()-118, 38), L"1 / 155");
	__pLabel->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pLabel->SetTextVerticalAlignment(ALIGNMENT_BOTTOM);
	__pLabel->SetTextConfig(26, LABEL_TEXT_STYLE_NORMAL);
	__pLabel->SetBackgroundColor(0xff262626);
	pCoverFlowOn_Thumbnail.AddControl(__pLabel);

	__pSlider = new(std::nothrow) Slider;
//	__pSlider->Construct(Rectangle(118, this->GetHeight()-80, this->GetWidth()-118, 80), BACKGROUND_STYLE_DEFAULT, false, 1, 155, GROUP_STYLE_NONE);
	__pSlider->Construct(Rectangle(118, this->GetHeight()-80, this->GetWidth()-118, 80),SLIDER_STYLE_NONE, 1, 155);
	__pSlider->SetValue(155);
//	__pSlider->SetThumbBitmap(SLIDER_THUMB_STATUS_NORMAL,*pAppResource->GetBitmapN(L"optionmenu_icon_setting.png"));
//	__pSlider->SetThumbBitmap(SLIDER_THUMB_STATUS_PRESSED,*pAppResource->GetBitmapN(L"optionmenu_icon_setting.png"));
	__pSlider->SetThumbTextColor(SLIDER_THUMB_STATUS_NORMAL, 0xff686868);
	__pSlider->SetThumbTextColor(SLIDER_THUMB_STATUS_PRESSED, 0xff1111ff);
	__pSlider->SetBarColor(0xff11ff11);
	__pSlider->SetColor(0xff262626);
	__pSlider->AddAdjustmentEventListener(*this);
	pCoverFlowOn_Thumbnail.AddControl(__pSlider);

	//*********************************Landscape******************************************
	Panel&          pCoverFlowOn_Thumbnail_Landscape  = *__pBackgroundPanel_Landscape;
	pCoverFlowOn_Thumbnail_Landscape.SetBackgroundColor(0xff222222);

	__pButton1_Landscape = new (std::nothrow) Button;
	__pButton1_Landscape->Construct(Rectangle(0, this->GetHeight()-180, 320, 77), "");
	__pButton1_Landscape->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_move_landscape.png"));
	__pButton1_Landscape->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_move_landscape_pressed.png"));
	__pButton1_Landscape->SetActionId(ID_BUTTON1);
	__pButton1_Landscape->AddActionEventListener(*this);
	pCoverFlowOn_Thumbnail_Landscape.AddControl(__pButton1_Landscape);

	__pButton2_Landscape = new (std::nothrow) Button;
	__pButton2_Landscape->Construct(Rectangle(320, this->GetHeight()-180, 320, 77), "");
	__pButton2_Landscape->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_next_landscape.png"));
	__pButton2_Landscape->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_next_landscape_pressed.png"));
	__pButton2_Landscape->SetActionId(ID_BUTTON2);
	__pButton2_Landscape->AddActionEventListener(*this);
	pCoverFlowOn_Thumbnail_Landscape.AddControl(__pButton2_Landscape);

	__pButton3_Landscape = new (std::nothrow) Button;
	__pButton3_Landscape->Construct(Rectangle(640, this->GetHeight()-180, 320, 77), "");
	__pButton3_Landscape->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_setting_landscape.png"));
	__pButton3_Landscape->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_setting_landscape_pressed.png"));
	__pButton3_Landscape->SetActionId(ID_BUTTON3);
	__pButton3_Landscape->AddActionEventListener(*this);
	pCoverFlowOn_Thumbnail_Landscape.AddControl(__pButton3_Landscape);

	__pButton4_Landscape = new (std::nothrow) Button;
	__pButton4_Landscape->Construct(Rectangle(960, this->GetHeight()-180, 320, 77), "");
	__pButton4_Landscape->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_help_landscape.png"));
	__pButton4_Landscape->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_help_landscape_pressed.png"));
	__pButton4_Landscape->SetActionId(ID_BUTTON4);
	__pButton4_Landscape->AddActionEventListener(*this);
	pCoverFlowOn_Thumbnail_Landscape.AddControl(__pButton4_Landscape);

	__pBookMarkButton_Landscape = new (std::nothrow) Button;
	__pBookMarkButton_Landscape->Construct(Rectangle(0, this->GetHeight()-103, 103, 103), "");
	__pBookMarkButton_Landscape->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"bookmark.png"));
	__pBookMarkButton_Landscape->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"bookmark.png"));
	__pBookMarkButton_Landscape->SetActionId(ID_BUTTON5);
	__pBookMarkButton_Landscape->AddActionEventListener(*this);
	pCoverFlowOn_Thumbnail_Landscape.AddControl(__pBookMarkButton_Landscape);

	__pLabel_Landscape = new(std::nothrow) Label;
	__pLabel_Landscape->Construct(Rectangle(103, this->GetHeight()-103, this->GetWidth()-103, 38), L"1 / 155");
	__pLabel_Landscape->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pLabel_Landscape->SetTextVerticalAlignment(ALIGNMENT_BOTTOM);
	__pLabel_Landscape->SetTextConfig(26, LABEL_TEXT_STYLE_NORMAL);
	__pLabel_Landscape->SetBackgroundColor(0xff262626);
	pCoverFlowOn_Thumbnail_Landscape.AddControl(__pLabel_Landscape);

	__pSlider_Landscape = new(std::nothrow) Slider;
//	__pSlider_Landscape->Construct(Rectangle(103, this->GetHeight()-65, this->GetWidth()-103, 65), BACKGROUND_STYLE_DEFAULT, false, 1, 155, GROUP_STYLE_NONE);
	__pSlider_Landscape->Construct(Rectangle(103, this->GetHeight()-65, this->GetWidth()-103, 65),SLIDER_STYLE_NONE, 1, 155);
	__pSlider_Landscape->SetValue(155);
//	__pSlider->SetThumbBitmap(SLIDER_THUMB_STATUS_NORMAL,*pAppResource->GetBitmapN(L"optionmenu_icon_setting.png"));
//	__pSlider->SetThumbBitmap(SLIDER_THUMB_STATUS_PRESSED,*pAppResource->GetBitmapN(L"optionmenu_icon_setting.png"));
	__pSlider_Landscape->SetThumbTextColor(SLIDER_THUMB_STATUS_NORMAL, 0xff686868);
	__pSlider_Landscape->SetThumbTextColor(SLIDER_THUMB_STATUS_PRESSED, 0xff1111ff);
	__pSlider_Landscape->SetBarColor(0xff00ff00);
	__pSlider_Landscape->SetColor(0xff262626);
	__pSlider_Landscape->AddAdjustmentEventListener(*this);
	pCoverFlowOn_Thumbnail_Landscape.AddControl(__pSlider_Landscape);

	if(isFirstStart==true)
	{
		__pBackgroundPanel->SetShowState(true);
		__pBackgroundPanel_Landscape->SetShowState(false);
	}
}

void
MyHondanaSettingForm::OnOrientationChanged(const Control &source, OrientationStatus orientationStatus)
{
	__pButton1->Destroy();
	__pButton2->Destroy();
	__pButton3->Destroy();
	__pButton4->Destroy();
	__pBackgroundPanel->Destroy();
	__pButton1_Landscape->Destroy();
	__pButton2_Landscape->Destroy();
	__pButton3_Landscape->Destroy();
	__pButton4_Landscape->Destroy();
	__pBackgroundPanel_Landscape->Destroy();

	SetPanel();
	SetButton();
	if(GetOrientationStatus()==ORIENTATION_PORTRAIT)
	{
		__pBackgroundPanel->SetShowState(true);
		__pBackgroundPanel_Landscape->SetShowState(false);
	}
	else
	{
		__pBackgroundPanel->SetShowState(false);
		__pBackgroundPanel_Landscape->SetShowState(true);
	}

	this->RequestRedraw();
}

void
MyHondanaSettingForm::OnUserEventReceivedN(RequestId requestId, Tizen::Base::Collection::IList* pArgs)
{
//	AppLogDebug("Detail_OnUserEventReceivedN = %d", __dIndex);
//	__Indexlist = new Tizen::Base::Collection::ArrayList;
//	Integer* pInt = static_cast< Integer* >(pArgs->GetAt(0));
//	__dIndex = pInt->ToInt();
//	delete pInt;
//	AppLogDebug("Received = %d", __dIndex);
}


void
MyHondanaSettingForm::OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId, const Tizen::Ui::Scenes::SceneId& nextSceneId)
{
}

void
MyHondanaSettingForm::OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId, const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs)
{
}

void
MyHondanaSettingForm::OnSliderBarMoved(Tizen::Ui::Controls::Slider& source, int value)
{
}

void
MyHondanaSettingForm::OnAdjustmentValueChanged(const Tizen::Ui::Control& source, int adjustment)
{
}
