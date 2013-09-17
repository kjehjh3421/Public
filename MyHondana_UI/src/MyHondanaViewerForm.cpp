#include <new>
#include <FApp.h>
#include <FGraphics.h>
#include <FAppUiApp.h>
#include <FBase.h>
#include "MyHondanaViewerForm.h"
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
		ID_BUTTON_MARKET = ID_BUTTON_BASE + 0x01,
	};
bool isFirstStart = true;
}

MyHondanaViewerForm::MyHondanaViewerForm(void)
: __isVisible(true)
{
}

MyHondanaViewerForm::~MyHondanaViewerForm(void)
{
}

bool
MyHondanaViewerForm::Initialize(void)
{
	RelativeLayout relativeLayout;
	relativeLayout.Construct();
	this->Construct(relativeLayout, FORM_STYLE_NORMAL | FORM_STYLE_INDICATOR | FORM_STYLE_HEADER);

	return true;
}

result
MyHondanaViewerForm::OnInitializing(void)
{
	result r = E_SUCCESS;
	Control::OnInitializing();

	SetOrientation(ORIENTATION_AUTOMATIC);
	AddOrientationEventListener(*this);
	SetFormBackEventListener(this);
	SetFormMenuEventListener(this);
	this->SetBackgroundColor(0xff292929);

	SetHeader();
	SetPanel();
	SetButton();
	ToastPopup();

	return r;
}

result
MyHondanaViewerForm::OnTerminating(void)
{
	result r = E_SUCCESS;
	return r;
}

void
MyHondanaViewerForm::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
    switch(actionId)
    {
    case ID_BUTTON_MARKET :
		pSceneManager->GoForward(ForwardSceneTransition(SCENE_MARKET));
    	break;
    case ID_BUTTON1:
		pSceneManager->GoForward(ForwardSceneTransition(SCENE_VIEWERMOVE));
    	break;
    default:
        break;
    }
    Invalidate(true);
}

void
MyHondanaViewerForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	pSceneManager->GoBackward(BackwardSceneTransition());
}


void
MyHondanaViewerForm::OnFormMenuRequested(Tizen::Ui::Controls::Form& source)
{
	switch(__isVisible)
	{
	case true:
		__pBackgroundPanel->SetShowState(false);
		SetActionBarsVisible(FORM_ACTION_BAR_INDICATOR| FORM_ACTION_BAR_HEADER, false);
		__isVisible = false;
		break;
	case false:
		__pBackgroundPanel->SetShowState(true);
		SetActionBarsVisible(FORM_ACTION_BAR_INDICATOR| FORM_ACTION_BAR_HEADER, true);
		__isVisible = true;
		break;
	default:
		break;
	}
}

void
MyHondanaViewerForm::OnOrientationChanged(const Control &source, OrientationStatus orientationStatus)
{
	__pButton1->Destroy();
	__pButton2->Destroy();
	__pButton3->Destroy();
	__pButton4->Destroy();
	__pLabel->Destroy();
	__pLabel_LeftNum->Destroy();
	__pLabel_CenterNum->Destroy();
	__pLabel_RightNum->Destroy();
	__pSlider->Destroy();
	__pBookMarkButton->Destroy();
	__pBackgroundPanel->Destroy();

	SetPanel();
	SetButton();
}

void
MyHondanaViewerForm::SetHeader(void)
{
	AppResource *pAppResource = App::GetInstance()->GetAppResource();

	// Create header
	Header * pHeader = GetHeader();
	if (pHeader != null) {
		ButtonItem  buttonRightItem;
		buttonRightItem.Construct(BUTTON_ITEM_STYLE_ICON, ID_BUTTON_MARKET);
		buttonRightItem.SetBackgroundBitmap(BUTTON_ITEM_STATUS_NORMAL, pAppResource->GetBitmapN(L"header_background.png"));
		buttonRightItem.SetIcon(BUTTON_ITEM_STATUS_NORMAL, pAppResource->GetBitmapN(L"btn_market_normal.png"));
		buttonRightItem.SetIcon(BUTTON_ITEM_STATUS_PRESSED, pAppResource->GetBitmapN(L"btn_market_pressed.png"));

		pHeader->SetStyle(HEADER_STYLE_TITLE);
		pHeader->SetBackgroundBitmap(pAppResource->GetBitmapN(L"header_background.png"));
		pHeader->SetTitleText(L"Viewer");

		pHeader->SetTitleTextColor(Color::GetColor(COLOR_ID_WHITE));
		pHeader->SetButton(BUTTON_POSITION_RIGHT, buttonRightItem);
	}
	pHeader->AddActionEventListener(*this);
}

void
MyHondanaViewerForm::SetPanel(void)
{
	RelativeLayout* pRelativeLayout = dynamic_cast<RelativeLayout*>(this->GetLayoutN());

	__pBackgroundPanel = new (std::nothrow) Panel();
	if(GetOrientation()==ORIENTATION_PORTRAIT)
		__pBackgroundPanel->Construct(Rectangle(0, this->GetHeight()-230, this->GetWidth(), this->GetHeight()));
	else
		__pBackgroundPanel->Construct(Rectangle(0, this->GetHeight()-195, this->GetWidth(), this->GetHeight()));
	this->AddControl(__pBackgroundPanel);

	__pBackgroundPanel->SetBackgroundColor(0xff000000);
	pRelativeLayout->SetRelation(*__pBackgroundPanel, this,	RECT_EDGE_RELATION_LEFT_TO_LEFT);
	pRelativeLayout->SetRelation(*__pBackgroundPanel, this,	RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
	pRelativeLayout->SetRelation(*__pBackgroundPanel, this,	RECT_EDGE_RELATION_BOTTOM_TO_BOTTOM);

	delete pRelativeLayout;
}

void
MyHondanaViewerForm::SetButton(void)
{
	AppResource *pAppResource = App::GetInstance()->GetAppResource();

	__pBackgroundPanel->SetBackgroundColor(0xff000000);

	if(GetOrientationStatus()==ORIENTATION_STATUS_PORTRAIT)
	{
		__pButton1 = new (std::nothrow) Button;
		__pButton1->Construct(Rectangle(0, this->GetHeight()-230, 180, 112), "");
		__pButton1->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_move.png"));
		__pButton1->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_move_pressed.png"));
		__pButton1->SetActionId(ID_BUTTON1);
		__pButton1->AddActionEventListener(*this);
		__pBackgroundPanel->AddControl(__pButton1);

		__pButton2 = new (std::nothrow) Button;
		__pButton2->Construct(Rectangle(180, this->GetHeight()-230, 180, 112), "");
		__pButton2->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_next.png"));
		__pButton2->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_next_pressed.png"));
		__pButton2->SetActionId(ID_BUTTON2);
		__pButton2->AddActionEventListener(*this);
		__pBackgroundPanel->AddControl(__pButton2);

		__pButton3 = new (std::nothrow) Button;
		__pButton3->Construct(Rectangle(360, this->GetHeight()-230, 180, 112), "");
		__pButton3->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_setting.png"));
		__pButton3->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_setting_pressed.png"));
		__pButton3->SetActionId(ID_BUTTON3);
		__pButton3->AddActionEventListener(*this);
		__pBackgroundPanel->AddControl(__pButton3);

		__pButton4 = new (std::nothrow) Button;
		__pButton4->Construct(Rectangle(540, this->GetHeight()-230, 180, 112), "");
		__pButton4->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_help.png"));
		__pButton4->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_help_pressed.png"));
		__pButton4->SetActionId(ID_BUTTON4);
		__pButton4->AddActionEventListener(*this);
		__pBackgroundPanel->AddControl(__pButton4);
	}
	else
	{
		__pButton1 = new (std::nothrow) Button;
		__pButton1->Construct(Rectangle(0, this->GetHeight()-195, 320, 77), "");
		__pButton1->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_move_landscape.png"));
		__pButton1->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_move_landscape_pressed.png"));
		__pButton1->SetActionId(ID_BUTTON1);
		__pButton1->AddActionEventListener(*this);
		__pBackgroundPanel->AddControl(__pButton1);

		__pButton2 = new (std::nothrow) Button;
		__pButton2->Construct(Rectangle(320, this->GetHeight()-195, 320, 77), "");
		__pButton2->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_next_landscape.png"));
		__pButton2->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_next_landscape_pressed.png"));
		__pButton2->SetActionId(ID_BUTTON2);
		__pButton2->AddActionEventListener(*this);
		__pBackgroundPanel->AddControl(__pButton2);

		__pButton3 = new (std::nothrow) Button;
		__pButton3->Construct(Rectangle(640, this->GetHeight()-195, 320, 77), "");
		__pButton3->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_setting_landscape.png"));
		__pButton3->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_setting_landscape_pressed.png"));
		__pButton3->SetActionId(ID_BUTTON3);
		__pButton3->AddActionEventListener(*this);
		__pBackgroundPanel->AddControl(__pButton3);

		__pButton4 = new (std::nothrow) Button;
		__pButton4->Construct(Rectangle(960, this->GetHeight()-195, 320, 77), "");
		__pButton4->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_help_landscape.png"));
		__pButton4->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"view_btn_help_landscape_pressed.png"));
		__pButton4->SetActionId(ID_BUTTON4);
		__pButton4->AddActionEventListener(*this);
		__pBackgroundPanel->AddControl(__pButton4);
	}


	__pLabel = new(std::nothrow) Label;
	__pLabel->Construct(Rectangle(0, this->GetHeight()-118, this->GetWidth(), 118), L"");
	__pLabel->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pLabel->SetTextVerticalAlignment(ALIGNMENT_TOP);
	__pLabel->SetTextConfig(22, LABEL_TEXT_STYLE_NORMAL);
	__pLabel->SetBackgroundBitmap(*pAppResource->GetBitmapN(L"slidebar_bg_portrait.png"));
	__pBackgroundPanel->AddControl(__pLabel);

	__pLabel_LeftNum = new(std::nothrow) Label;
	__pLabel_LeftNum->Construct(Rectangle(106, this->GetHeight()-118, (this->GetWidth()-146)/2-1, 52), L"1");
	__pLabel_LeftNum->SetTextHorizontalAlignment(ALIGNMENT_RIGHT);
	__pLabel_LeftNum->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pLabel_LeftNum->SetTextConfig(22, LABEL_TEXT_STYLE_NORMAL);
	__pLabel_LeftNum->SetTextColor(0xffffffff);
	__pLabel_LeftNum->SetBackgroundColor(0x0011ff11);
	__pBackgroundPanel->AddControl(__pLabel_LeftNum);

	__pLabel_CenterNum = new(std::nothrow) Label;
	__pLabel_CenterNum->Construct(Rectangle(106+(this->GetWidth()-146)/2-19, this->GetHeight()-118, 50, 52), L"|");
	__pLabel_CenterNum->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
	__pLabel_CenterNum->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pLabel_CenterNum->SetTextConfig(22, LABEL_TEXT_STYLE_NORMAL);
	__pLabel_CenterNum->SetTextColor(0xff555555);
	__pLabel_CenterNum->SetBackgroundColor(0x1111ff);
	__pBackgroundPanel->AddControl(__pLabel_CenterNum);

	__pLabel_RightNum = new(std::nothrow) Label;
	__pLabel_RightNum->Construct(Rectangle(106+(this->GetWidth()-146)/2, this->GetHeight()-118, (this->GetWidth()-146)/2, 52), L"155");
	__pLabel_RightNum->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
	__pLabel_RightNum->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pLabel_RightNum->SetTextConfig(22, LABEL_TEXT_STYLE_NORMAL);
	__pLabel_RightNum->SetTextColor(0xff555555);
	__pLabel_RightNum->SetBackgroundColor(0x001111ff);
	__pBackgroundPanel->AddControl(__pLabel_RightNum);

	__pSlider = new(std::nothrow) Slider;
	__pSlider->Construct(Rectangle(66, this->GetHeight()-118, this->GetWidth()-66, 118), SLIDER_STYLE_NONE, 1, 155);
	__pSlider->SetValue(155);
	__pSlider->SetThumbBitmap(SLIDER_THUMB_STATUS_NORMAL,*pAppResource->GetBitmapN(L"viewer_bar_control_normal.png"));
	__pSlider->SetThumbBitmap(SLIDER_THUMB_STATUS_PRESSED,*pAppResource->GetBitmapN(L"viewer_bar_control_pressed.png"));
	__pSlider->SetThumbTextColor(SLIDER_THUMB_STATUS_NORMAL, 0x00ffffff);
	__pSlider->SetThumbTextColor(SLIDER_THUMB_STATUS_PRESSED, 0x00ffffff);
	__pSlider->SetBarColor(0xff555555);
	__pSlider->SetBarBackgroundColor(0xff11ff11);
	__pSlider->SetColor(0x00000000);
	__pSlider->AddSliderEventListener(*this);
	__pSlider->AddAdjustmentEventListener(*this);
	__pBackgroundPanel->AddControl(__pSlider);

	__pBookMarkButton = new (std::nothrow) Button;
	__pBookMarkButton->Construct(Rectangle(0, this->GetHeight()-81, 86, 44), "");
	__pBookMarkButton->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"viewer_bookmark_icon_normal.png"));
	__pBookMarkButton->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"viewer_bookmark_icon_selected.png"));
	__pBookMarkButton->SetActionId(ID_BUTTON5);
	__pBookMarkButton->AddActionEventListener(*this);
	__pBackgroundPanel->AddControl(__pBookMarkButton);

}
void
MyHondanaViewerForm::SetButton2(void)
{

}

result
MyHondanaViewerForm::Play(void)
{
	result r = E_SUCCESS;

	bool showState;

	if (GetAnimationDirection() == ANIMATION_FORWARD)
		showState = false;
	else
	{
		showState = true;
	}

	AnimationTransaction::Begin(__transactionId);
	__pLabel_Toast->SetShowState(true);
	int start = 1;
	int end = 0;
	IntegerAnimation animRightBottom(start, end, AnimationPropertyInfo2::DEFAULT_DURATION2, ANIMATION_INTERPOLATOR_EASE_IN_OUT);
	_animationPropertyInfo2.ApplyGlobalSettings(animRightBottom);
	(__pLabel_Toast->GetControlAnimator())->StartUserAnimation(ANIMATION_TARGET_ALPHA, animRightBottom);

//	(__pLabel_Toast->GetControlAnimator())->SetShowState(false);

	AnimationTransaction::Commit();
//	int start, end;
//
//	if (GetAnimationDirection() == ANIMATION_FORWARD)
//	{
//		start = 0;
//		end = 1;
//	}
//	else
//	{
//		start = 1;
//		end = 0;
//	}
//
//	IntegerAnimation animRightBottom(start, end, AnimationPropertyInfo::DEFAULT_DURATION, ANIMATION_INTERPOLATOR_LINEAR);
//
//	_animationPropertyInfo.ApplyGlobalSettings(animRightBottom);
//
//	(__pLabel_LeftNum->GetControlAnimator())->StartUserAnimation(ANIMATION_TARGET_ALPHA, animRightBottom);
	return r;
}
void
MyHondanaViewerForm::ToastPopup(void)
{
//	const int firstpage = __pSlider->GetValue();
	int first_page = __pSlider->GetValue()-(__pSlider->GetValue()-1);
	String str_first_page = Tizen::Base::Integer::ToString(first_page);
//	Integer::Parse(str_page, page);

	__pLabel_Toast = new (std::nothrow) Label;
	__pLabel_Toast->Construct(Rectangle(this->GetWidth()/2-100, this->GetHeight()/2-50, 200, 100), str_first_page);
	__pLabel_Toast->SetTextColor(0xffffffff);
	__pLabel_Toast->SetBackgroundColor(0xff292929);
	__pLabel_Toast->SetShowState(false);
	this->AddControl(__pLabel_Toast);
}

void
MyHondanaViewerForm::ShowMessageBox(void)
{
	MessageBox* pMessageBox = new (std::nothrow) MessageBox();
	pMessageBox->Construct(null, L"\n\n", MSGBOX_STYLE_NONE, 2000);
	pMessageBox->SetColor(0xff262626);

	__pLabel_MsgBox = new(std::nothrow) Label;
	if(GetOrientationStatus()==ORIENTATION_STATUS_PORTRAIT)
		__pLabel_MsgBox->Construct(Rectangle(35, 35, 580, 155), L"参考イメージ  準備中");
	else
		__pLabel_MsgBox->Construct(Rectangle(35, 35, 760, 155), L"参考イメージ  準備中");
	__pLabel_MsgBox->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pLabel_MsgBox->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pLabel_MsgBox->SetTextConfig(40, LABEL_TEXT_STYLE_NORMAL);
	__pLabel_MsgBox->SetBackgroundColor(0xff262626);
	pMessageBox->AddControl(__pLabel_MsgBox);

	int ModalResult;
	pMessageBox->ShowAndWait(ModalResult);

	delete pMessageBox;
}

void
MyHondanaViewerForm::OnUserEventReceivedN(RequestId requestId, Tizen::Base::Collection::IList* pArgs)
{
//	AppLogDebug("Detail_OnUserEventReceivedN = %d", __dIndex);
//	__Indexlist = new Tizen::Base::Collection::ArrayList;
//	Integer* pInt = static_cast< Integer* >(pArgs->GetAt(0));
//	__dIndex = pInt->ToInt();
//	delete pInt;
//	AppLogDebug("Received = %d", __dIndex);
}


void
MyHondanaViewerForm::OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId, const Tizen::Ui::Scenes::SceneId& nextSceneId)
{
}

void
MyHondanaViewerForm::OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId, const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs)
{
}

void
MyHondanaViewerForm::OnSliderBarMoved(Tizen::Ui::Controls::Slider& source, int value)
{
	String str_current_page = Tizen::Base::Integer::ToString(value);
	__pLabel_LeftNum->SetText(str_current_page);
}

void
MyHondanaViewerForm::OnAdjustmentValueChanged(const Tizen::Ui::Control& source, int adjustment)
{
	Play();
	String str_current_page = Tizen::Base::Integer::ToString(adjustment);
	__pLabel_Toast->SetText(str_current_page);
}
