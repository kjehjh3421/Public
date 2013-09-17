#include <FApp.h>
#include <FGraphics.h>
#include <FAppUiApp.h>
#include <FBase.h>
#include "MyHondanaMainForm.h"
#include "MyHondanaDeleteForm.h"
#include "SceneRegister.h"
#include "AppResourceId.h"
#include "FUiLayout.h"
#include "FUiRelativeLayout.h"
#include "FUiVerticalBoxLayout.h"
#include "FUiHorizontalBoxLayout.h"
#include "FUiGridLayout.h"
#include "FMedia.h"
#include <FSystem.h>

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Graphics;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Media;
using namespace Tizen::Ui::Scenes;
using namespace Tizen::Ui::Animations;
using namespace Tizen::Base::Collection;
using namespace Tizen::System;

const wchar_t LIST_IMAGE_PATH1[] = L"book02.png";
const wchar_t LIST_IMAGE_PATH2[] = L"book02.png";
const wchar_t LIST_IMAGE_PATH3[] = L"list_new_book_icon.png";
const wchar_t LIST_IMAGE_PATH4[] = L"grid_new_book_icon.png";
const wchar_t LIST_IMAGE_PATH5[] = L"list_bottom_text.png";
const wchar_t LIST_IMAGE_PATH6[] = L"grid_bottom_text.png";

const wchar_t HEADER_BACKGROUND[] = L"header_background.png";

namespace
{
static const int SIZE_OF_LABEL_Y = 40;

bool isPortrait = true;
bool isFirstStart = true;

	enum
	{
		BOOK_STATUS_TOTAL_OPEN = 100,
		BOOK_STATUS_TOTAL_CLOSE = BOOK_STATUS_TOTAL_OPEN + 0x01,

		ID_BUTTON_BASE     = 110,
		ID_BUTTON_CANCEL = ID_BUTTON_BASE + 0x00,
		ID_BUTTON_DELETE = ID_BUTTON_BASE + 0x01,
		ID_BUTTON_ACTIONBAR = ID_BUTTON_BASE + 0x02,
		ID_BUTTON_OPTION = ID_BUTTON_BASE + 0x03,
	};

int mBookDeleteMode = BOOK_STATUS_TOTAL_OPEN;
//int mBookOrientationMode = PORTRAIT;
}

MyHondanaDeleteForm::MyHondanaDeleteForm(void)
	: __pCover(null)
	, __pBook(null)
	, __pListNewBook(null)
	, __pGridNewBook(null)
	, __pListBottomText(null)
	, __pGridBottomText(null)
	, __pHeaderBackground(null)
	, __pDeleteCheckPopup(null)
{
}

MyHondanaDeleteForm::~MyHondanaDeleteForm(void)
{
}

bool
MyHondanaDeleteForm::Initialize(void)
{
	RelativeLayout relativeLayout;
	relativeLayout.Construct();

	this->Construct(relativeLayout, FORM_STYLE_NORMAL | FORM_STYLE_INDICATOR | FORM_STYLE_HEADER);

	return true;
}

result
MyHondanaDeleteForm::OnInitializing(void)
{
	result r = E_SUCCESS;
	Control::OnInitializing();

	SetOrientation(ORIENTATION_AUTOMATIC);
	AddOrientationEventListener(*this);
	SetFormBackEventListener(this);
	SetFormMenuEventListener(this);
	PowerManager::AddScreenEventListener(*((IScreenEventListener*) this));
	PowerManager::TurnScreenOn();
	this->SetBackgroundColor(Color::GetColor(COLOR_ID_BLACK));

	SetHeader();
	SetSplitPanel();
	SetListView();
	SetButton();
	GetBitmap();
	DeleteCheckPopup();
	isFirstStart = false;

	return r;
}

result
MyHondanaDeleteForm::OnTerminating(void)
{
	result r = E_SUCCESS;
	return r;
}

void
MyHondanaDeleteForm::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	switch(actionId)
	{
	//***************************OPTION MENU*******************************
	case ID_BUTTON_ACTIONBAR:
	{

	}
		break;
	case ID_BUTTON_CANCEL:
	{
		__pListView->Destroy();
		__pFileSizeLabel->Destroy();
		__pCancelButton->Destroy();
		__pDeleteButton->Destroy();
		__pListView_Landscape->Destroy();
		__pFileSizeLabel_Landscape->Destroy();
		__pCancelButton_Landscape->Destroy();
		__pDeleteButton_Landscape->Destroy();
		__pDeleteBackgroundPanel->Destroy();
		__pDeleteBackgroundPanel_Bottom->Destroy();
		__pDeleteBackgroundPanel_Landscape->Destroy();
		__pDeleteBackgroundPanel_Bottom_Landscape->Destroy();

		isFirstStart=true;
		pSceneManager->GoBackward(BackwardSceneTransition());
	}
		break;
	case ID_BUTTON_DELETE:
	{
		__pDeleteCheckPopup->SetShowState(true);
		__pDeleteCheckPopup->Show();
	}
		break;
	default:
		break;
	}
	Invalidate(true);
}

void
MyHondanaDeleteForm::OnOrientationChanged(const Control &source, OrientationStatus orientationStatus)
{
	SetSplitPanel();
	SetListView();
	SetButton();

	switch(GetOrientationStatus())
	{
		case ORIENTATION_PORTRAIT:
		{
			__pDeleteBackgroundPanel->SetShowState(true);
			__pDeleteBackgroundPanel_Bottom->SetShowState(true);
			__pDeleteBackgroundPanel_Landscape->SetShowState(false);
			__pDeleteBackgroundPanel_Bottom_Landscape->SetShowState(false);
		}
			break;
		case ORIENTATION_LANDSCAPE:
		{
			__pDeleteBackgroundPanel->SetShowState(false);
			__pDeleteBackgroundPanel_Bottom->SetShowState(false);
			__pDeleteBackgroundPanel_Landscape->SetShowState(true);
			__pDeleteBackgroundPanel_Bottom_Landscape->SetShowState(true);
		}
			break;
		case ORIENTATION_LANDSCAPE_REVERSE:
		{
			__pDeleteBackgroundPanel->SetShowState(false);
			__pDeleteBackgroundPanel_Bottom->SetShowState(false);
			__pDeleteBackgroundPanel_Landscape->SetShowState(true);
			__pDeleteBackgroundPanel_Bottom_Landscape->SetShowState(true);
		}
			break;
		default:
			break;
	}
	this->RequestRedraw();
}

void
MyHondanaDeleteForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{

	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	__pListView->Destroy();
	__pFileSizeLabel->Destroy();
	__pCancelButton->Destroy();
	__pDeleteButton->Destroy();
	__pListView_Landscape->Destroy();
	__pFileSizeLabel_Landscape->Destroy();
	__pCancelButton_Landscape->Destroy();
	__pDeleteButton_Landscape->Destroy();
	__pDeleteBackgroundPanel->Destroy();
	__pDeleteBackgroundPanel_Bottom->Destroy();
	__pDeleteBackgroundPanel_Landscape->Destroy();
	__pDeleteBackgroundPanel_Bottom_Landscape->Destroy();

	isFirstStart=true;

	pSceneManager->GoBackward(BackwardSceneTransition());
}

void
MyHondanaDeleteForm::OnFormMenuRequested(Tizen::Ui::Controls::Form& source)
{
//	OptionMenu __pMenu = new (std:nothrow) ;
//	__pMenu->Construct();
//	__pMenu->AddItem(L"item0", ID_CONTEXT_ITEM+0);
//	__pMenu->AddActionEventListener(*this);
//	__pMenu->SetShowState(false);
//	OptionMenu();

//	__pOptionMenu->SetShowState(true);
//	__pOptionMenu->Show();
}

void
MyHondanaDeleteForm::GetBitmap(void)
{
	AppResource* pAppResource = Application::GetInstance()->GetAppResource();
	__pCover = pAppResource->GetBitmapN(LIST_IMAGE_PATH1);
	__pBook = pAppResource->GetBitmapN(LIST_IMAGE_PATH2);
	__pListNewBook = pAppResource->GetBitmapN(LIST_IMAGE_PATH3);
	__pGridNewBook = pAppResource->GetBitmapN(LIST_IMAGE_PATH4);
	__pListBottomText = pAppResource->GetBitmapN(LIST_IMAGE_PATH5);
	__pGridBottomText = pAppResource->GetBitmapN(LIST_IMAGE_PATH6);
	__pHeaderBackground = pAppResource->GetBitmapN(HEADER_BACKGROUND);
}

int
MyHondanaDeleteForm::GetItemCount(void)
{
	return LIST_VIEW_MAIN_MENU_COUNT;
}


Tizen::Ui::Controls::ListItemBase*
MyHondanaDeleteForm::CreateItem(int index, int itemWidth)
{
	AppResource* pAppResource = Application::GetInstance()->GetAppResource();

	struct BOOK_LIST {
		const Tizen::Graphics::Bitmap* bookbitmap;
		const Tizen::Base::String  		itemTitleText;
		const Tizen::Base::String		itemAuthorText;
		bool recommend;
		bool readbook;
	} BOOK_LIST_ITEM[]= {
		 { pAppResource->GetBitmapN(L"book01.png"), L"しんじゅくすわんかぶきちょうすかうとさばいばる", L"いわさきなつみ", false, true }
		,{ pAppResource->GetBitmapN(L"book02.png"), L"わんかぶきちょうすかう", L"わさきみ", false, true }
		,{ pAppResource->GetBitmapN(L"book03.png"), L"くすわんかぶきちょうすかうとさば", L"わさきみ", false, true }
		,{ pAppResource->GetBitmapN(L"book04.png"), L"しんじゅく", L"わさきみ", false, true }
		,{ pAppResource->GetBitmapN(L"book05.png"), L"すわんかぶきちょうすかうとさばいばる", L"わきみ", false, true }
		,{ pAppResource->GetBitmapN(L"book06.png"), L"うとさばいばる", L"わきみ", false, true }
		,{ pAppResource->GetBitmapN(L"book07.png"), L"しんじょうすかうとさばいばる", L"わさみ", false, true }
		,{ pAppResource->GetBitmapN(L"book08.png"), L"ばいばる", L"さきみ", false, true }
		,{ pAppResource->GetBitmapN(L"book09.png"), L"しいばる", L"わさみ", false, true }
		,{ pAppResource->GetBitmapN(L"book10.png"), L"くすわんかぶきちょうすかうとさばいばる", L"わさ", false, true }
		,{ pAppResource->GetBitmapN(L"book11.png"), L"しんじゅくすうとさばいばる", L"わみ", false, true }
		,{ pAppResource->GetBitmapN(L"book12.png"), L"かうとさばいばる", L"わさきみ", false, true }
		,{ pAppResource->GetBitmapN(L"book13.png"), L"しばる", L"わさ", false, true }
		,{ pAppResource->GetBitmapN(L"book14.png"), L"ぶきちょうすかうといばる", L"わ", false, true }
		,{ pAppResource->GetBitmapN(L"book15.png"), L"ゅくすわんかちょうすかばいばる", L"わさきみ", false, false }
		,{ pAppResource->GetBitmapN(L"book16.png"), L"くすわんかぶきちすかうといばる", L"み", false, true }
		,{ pAppResource->GetBitmapN(L"book17.png"), L"しくすわんかうすかうとさばる", L"わさきみ", false, true }
		,{ pAppResource->GetBitmapN(L"book18.png"), L"しじゅくとさばいばる", L"わさみ", true, true }
		,{ pAppResource->GetBitmapN(L"book19.png"), L"ゅくすわんかぶきちょうすかうとさばいばる", L"み", true, false }
		,{ pAppResource->GetBitmapN(L"book20.png"), L"ばいばる", L"わさきみ", true, false }
	};

	ListAnnexStyle style = LIST_ANNEX_STYLE_NORMAL;

	CustomItem* pItem = new (std::nothrow) CustomItem();
	Rectangle coverImageRect(20, 10, 70, 100);//96, 150);
	Rectangle bookImageRect(8, 77, 95, 40);
	Rectangle titlekanaRect(105, 15, this->GetWidth()-200, 40);
	Rectangle authornamekanaRect(105, 55, this->GetWidth()-170, 40);
	Rectangle releasedateRect(15, 80, 80, 30);
	Rectangle gotonewbookImageRect(this->GetWidth()-85, 30, 60, 60);//70, 153, 50
	Dimension itemDimension(100, 120);//160

	pItem->Construct(itemDimension, style);
	pItem->AddElement(coverImageRect, ID_FORMAT_BITMAP, *BOOK_LIST_ITEM[index].bookbitmap, null, null);
	pItem->AddElement(titlekanaRect, ID_FORMAT_STRING, BOOK_LIST_ITEM[index].itemTitleText, 30, Color::GetColor(COLOR_ID_WHITE), Color::GetColor(COLOR_ID_WHITE), Color::GetColor(COLOR_ID_WHITE), true);
	pItem->AddElement(authornamekanaRect, ID_FORMAT_STRING2, BOOK_LIST_ITEM[index].itemAuthorText, 26, Color::GetColor(COLOR_ID_GREY), Color::GetColor(COLOR_ID_GREY), Color::GetColor(COLOR_ID_GREY), true);
	pItem->AddElement(releasedateRect, ID_FORMAT_STRING3, L"", 14, Color::GetColor(COLOR_ID_WHITE), Color::GetColor(COLOR_ID_WHITE), Color::GetColor(COLOR_ID_WHITE), true);
	if(index==0)
		pItem->AddElement(bookImageRect, ID_FORMAT_BITMAP2, *__pListBottomText, null, null);
	if(BOOK_LIST_ITEM[index].readbook==false)
		pItem->AddElement(gotonewbookImageRect, ID_FORMAT_BITMAP3, *__pListNewBook, null, null);

	return pItem;
}

bool
MyHondanaDeleteForm::DeleteItem(int index, Tizen::Ui::Controls::ListItemBase* pItem, int itemWidth)
{
	delete pItem;
	pItem = null;
	return true;
}

void
MyHondanaDeleteForm::OnListViewItemStateChanged(ListView& listView, int index, int elementId, ListItemStatus status)
{
//	SceneManager* pSceneManager = SceneManager::GetInstance();
//	AppAssert(pSceneManager);
//
//	ArrayList* pList = new (std::nothrow) ArrayList();
//	pList->Add(*(new (std::nothrow) Integer(index)));
//
//	MyHondanaDetailForm* pDetailForm = new (std::nothrow) MyHondanaDetailForm;
//	pDetailForm->Initialize();
//	pDetailForm->AddControl(*pDetailForm);
//	pDetailForm->SendUserEvent(MyHondanaDeleteForm::REQUEST_ID_SEND, pList);
//
//
//	pSceneManager->GoForward(ForwardSceneTransition(SCENE_DETAIL));
}

void
MyHondanaDeleteForm::OnListViewItemSwept(ListView& listView, int index, SweepDirection direction)
{
}

void
MyHondanaDeleteForm::OnListViewContextItemStateChanged(ListView& listView, int index, int elementId, ListContextItemStatus state)
{
}

void
MyHondanaDeleteForm::OnListViewItemLongPressed(ListView& listView, int index, int elementId, bool& invokeListViewItemCallback)
{
//	SceneManager* pSceneManager = SceneManager::GetInstance();
//	AppAssert(pSceneManager);
//
//	pSceneManager->GoForward(ForwardSceneTransition(SCENE_DETAIL));
}

void
MyHondanaDeleteForm::SetHeader(void)
{
	AppResource *pAppResource = App::GetInstance()->GetAppResource();

	// Create header
	Header * pHeader = GetHeader();

	ButtonItem  buttonRightItem;
	buttonRightItem.Construct(BUTTON_ITEM_STYLE_ICON, ID_BUTTON_ACTIONBAR);
	if(mBookDeleteMode==BOOK_STATUS_TOTAL_OPEN)
	{
		buttonRightItem.SetIcon(BUTTON_ITEM_STATUS_NORMAL, pAppResource->GetBitmapN(L"total_close.png"));
		buttonRightItem.SetIcon(BUTTON_ITEM_STATUS_PRESSED, pAppResource->GetBitmapN(L"total_close.png"));
	}
	else if(mBookDeleteMode==BOOK_STATUS_TOTAL_CLOSE)
	{
		buttonRightItem.SetIcon(BUTTON_ITEM_STATUS_NORMAL, pAppResource->GetBitmapN(L"total_open.png"));
		buttonRightItem.SetIcon(BUTTON_ITEM_STATUS_PRESSED, pAppResource->GetBitmapN(L"total_open.png"));
	}
	pHeader->SetStyle(HEADER_STYLE_TITLE);
	pHeader->SetBackgroundBitmap(pAppResource->GetBitmapN(L"header_background.png"));
	pHeader->SetTitleText(L"マイ本棚");
//	pHeader->SetTitleIcon(pAppResource->GetBitmapN(L"icon.png"));
	pHeader->SetTitleTextColor(Color::GetColor(COLOR_ID_WHITE));
	pHeader->SetButton(BUTTON_POSITION_RIGHT, buttonRightItem);
	pHeader->AddActionEventListener(*this);
}

void
MyHondanaDeleteForm::SetSplitPanel(void)
{
	RelativeLayout* pRelativeLayout = dynamic_cast<RelativeLayout*>(this->GetLayoutN());
	int list_height = LIST_VIEW_MAIN_MENU_COUNT*120;
	//****************************************************Portrait****************************************************************
	Panel* pPanel;
	__pDeleteBackgroundPanel_Bottom = new (std::nothrow) Panel();
	__pDeleteBackgroundPanel_Bottom->Construct(Rectangle(0, 0, this->GetWidth(), this->GetHeight()));

	pPanel = __pDeleteBackgroundPanel_Bottom;
	this->AddControl(pPanel);

	pRelativeLayout->SetRelation(*pPanel, this, RECT_EDGE_RELATION_LEFT_TO_LEFT);
	pRelativeLayout->SetRelation(*pPanel, this, RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
	pRelativeLayout->SetRelation(*pPanel, this, RECT_EDGE_RELATION_TOP_TO_TOP);
	pRelativeLayout->SetRelation(*pPanel, this, RECT_EDGE_RELATION_BOTTOM_TO_BOTTOM);

	ScrollPanel* pScrollPanel;
	__pDeleteBackgroundPanel = new (std::nothrow) ScrollPanel();
	__pDeleteBackgroundPanel->Construct(Rectangle(0, 0, this->GetWidth(), list_height));
	pScrollPanel = __pDeleteBackgroundPanel;
	pPanel->AddControl(pScrollPanel);

	pRelativeLayout->SetRelation(*pScrollPanel, pPanel, RECT_EDGE_RELATION_LEFT_TO_LEFT);
	pRelativeLayout->SetRelation(*pScrollPanel, pPanel, RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
	pRelativeLayout->SetRelation(*pScrollPanel, pPanel, RECT_EDGE_RELATION_TOP_TO_TOP);


	//****************************************************Landscape****************************************************************
	Panel* pPanel_Landscape;
	__pDeleteBackgroundPanel_Bottom_Landscape = new (std::nothrow) Panel();
	__pDeleteBackgroundPanel_Bottom_Landscape->Construct(Rectangle(0, 0, this->GetWidth(), this->GetHeight()));

	pPanel_Landscape = __pDeleteBackgroundPanel_Bottom_Landscape;
	this->AddControl(pPanel_Landscape);

	pRelativeLayout->SetRelation(*pPanel_Landscape, this, RECT_EDGE_RELATION_LEFT_TO_LEFT);
	pRelativeLayout->SetRelation(*pPanel_Landscape, this, RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
	pRelativeLayout->SetRelation(*pPanel_Landscape, this, RECT_EDGE_RELATION_TOP_TO_TOP);
	pRelativeLayout->SetRelation(*pPanel_Landscape, this, RECT_EDGE_RELATION_BOTTOM_TO_BOTTOM);

	ScrollPanel* pScrollPanel_Landscape;
	__pDeleteBackgroundPanel_Landscape = new (std::nothrow) ScrollPanel();
	__pDeleteBackgroundPanel_Landscape->Construct(Rectangle(0, 0, this->GetWidth(), list_height));
	pScrollPanel_Landscape = __pDeleteBackgroundPanel_Landscape;
	pPanel_Landscape->AddControl(pScrollPanel_Landscape);

	pRelativeLayout->SetRelation(*pScrollPanel_Landscape, pPanel_Landscape, RECT_EDGE_RELATION_LEFT_TO_LEFT);
	pRelativeLayout->SetRelation(*pScrollPanel_Landscape, pPanel_Landscape, RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
	pRelativeLayout->SetRelation(*pScrollPanel_Landscape, pPanel_Landscape, RECT_EDGE_RELATION_TOP_TO_TOP);

	//--------------isFirstStart--------------
	if(isFirstStart==true)
	{
			__pDeleteBackgroundPanel->SetShowState(true);
			__pDeleteBackgroundPanel_Bottom->SetShowState(true);
			__pDeleteBackgroundPanel_Landscape->SetShowState(false);
			__pDeleteBackgroundPanel_Bottom_Landscape->SetShowState(false);
	}
//	else if(isFirstStart==false)
//	{
//		if(isPortrait==true)
//		{
//			__pDeleteBackgroundPanel->SetShowState(true);
//			__pDeleteBackgroundPanel_Bottom->SetShowState(true);
//			__pDeleteBackgroundPanel_Landscape->SetShowState(false);
//			__pDeleteBackgroundPanel_Bottom_Landscape->SetShowState(false);
//			isPortrait=false;
//		}
//		else
//		{
//			__pDeleteBackgroundPanel->SetShowState(false);
//			__pDeleteBackgroundPanel_Bottom->SetShowState(false);
//			__pDeleteBackgroundPanel_Landscape->SetShowState(true);
//			__pDeleteBackgroundPanel_Bottom_Landscape->SetShowState(true);
//			isPortrait=true;
//		}
//	}

	delete pRelativeLayout;
}

void
MyHondanaDeleteForm::SetListView(void)
{
	//****************************************************Portrait****************************************************************
	Panel&          pList  = *__pDeleteBackgroundPanel;
	__pListView = new (std::nothrow) ListView();
	__pListView->Construct(Rectangle(0, 0, this->GetWidth(), this->GetHeight()-320), true, SCROLL_STYLE_FADE_OUT);
	__pListView->SetBackgroundColor(0xff232323);
	__pListView->SetItemProvider(*this);
	__pListView->AddListViewItemEventListener(*this);
	pList.AddControl(*__pListView);
	//****************************************************Landscape****************************************************************
	Panel&          pList_Landscape  = *__pDeleteBackgroundPanel_Landscape;
	__pListView_Landscape = new (std::nothrow) ListView();
	__pListView_Landscape->Construct(Rectangle(0, 0, this->GetWidth(), this->GetHeight()-252), true, SCROLL_STYLE_FADE_OUT);
	__pListView_Landscape->SetBackgroundColor(0xff232323);
	__pListView_Landscape->SetItemProvider(*this);
	__pListView_Landscape->AddListViewItemEventListener(*this);
	pList_Landscape.AddControl(*__pListView_Landscape);
}

void
MyHondanaDeleteForm::SetButton(void)
{
	//****************************************************Portrait****************************************************************
	Panel&          pLabel  = *__pDeleteBackgroundPanel_Bottom;
	pLabel.SetBackgroundColor(0xff333333);
	__pFileSizeLabel = new (std::nothrow) Label;
	__pFileSizeLabel->Construct(Rectangle(0,  this->GetHeight()-320, this->GetWidth(), SIZE_OF_LABEL_Y), L"");
	__pFileSizeLabel->SetText(L"0 MB");
	__pFileSizeLabel->SetTextConfig(32, LABEL_TEXT_STYLE_NORMAL);
	__pFileSizeLabel->SetTextColor(0xff999999);
	__pFileSizeLabel->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pFileSizeLabel->SetTextVerticalAlignment(ALIGNMENT_BOTTOM);
	__pFileSizeLabel->SetBackgroundColor(0xff333333);
	pLabel.AddControl(__pFileSizeLabel);

	__pCancelButton = new (std::nothrow) Button;
	__pCancelButton->Construct(Rectangle(20, this->GetHeight()-260, this->GetWidth()/2-30, 84), "");
	__pCancelButton->SetColor(BUTTON_STATUS_NORMAL, 0xff545454);
	__pCancelButton->SetColor(BUTTON_STATUS_PRESSED, 0xff343434);
	__pCancelButton->SetText(L"キャンセル");
	__pCancelButton->SetTextColor(0xffffffff);
	__pCancelButton->SetTextSize(30);
	__pCancelButton->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pCancelButton->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pCancelButton->SetActionId(ID_BUTTON_CANCEL);
	__pCancelButton->AddActionEventListener(*this);
	pLabel.AddControl(__pCancelButton);

	__pDeleteButton = new (std::nothrow) Button;
	__pDeleteButton->Construct(Rectangle(this->GetWidth()/2+10, this->GetHeight()-260, this->GetWidth()/2-30, 84), "");
	__pDeleteButton->SetColor(BUTTON_STATUS_NORMAL, 0xffff7777);
	__pDeleteButton->SetColor(BUTTON_STATUS_PRESSED, 0xffff3131);
	__pDeleteButton->SetText(L"削除");
	__pDeleteButton->SetTextColor(0xffffffff);
	__pDeleteButton->SetTextSize(30);
	__pDeleteButton->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pDeleteButton->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pDeleteButton->SetActionId(ID_BUTTON_DELETE);
	__pDeleteButton->AddActionEventListener(*this);
	pLabel.AddControl(__pDeleteButton);
	//****************************************************Landscape****************************************************************
	Panel&          pLabel_Landscape  = *__pDeleteBackgroundPanel_Bottom_Landscape;
	pLabel_Landscape.SetBackgroundColor(0xff333333);
	__pFileSizeLabel_Landscape = new (std::nothrow) Label;
	__pFileSizeLabel_Landscape->Construct(Rectangle(0,  this->GetHeight()-252, this->GetWidth(), SIZE_OF_LABEL_Y), L"");
	__pFileSizeLabel_Landscape->SetText(L"0 MB");
	__pFileSizeLabel_Landscape->SetTextConfig(32, LABEL_TEXT_STYLE_NORMAL);
	__pFileSizeLabel_Landscape->SetTextColor(0xff999999);
	__pFileSizeLabel_Landscape->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pFileSizeLabel_Landscape->SetTextVerticalAlignment(ALIGNMENT_BOTTOM);
	__pFileSizeLabel_Landscape->SetBackgroundColor(0xff333333);
	pLabel_Landscape.AddControl(__pFileSizeLabel_Landscape);

	__pCancelButton_Landscape = new (std::nothrow) Button;
	__pCancelButton_Landscape->Construct(Rectangle(20, this->GetHeight()-192, this->GetWidth()/2-30, 84), "");
	__pCancelButton_Landscape->SetColor(BUTTON_STATUS_NORMAL, 0xff545454);
	__pCancelButton_Landscape->SetColor(BUTTON_STATUS_PRESSED, 0xff343434);
	__pCancelButton_Landscape->SetText(L"キャンセル");
	__pCancelButton_Landscape->SetTextColor(0xffffffff);
	__pCancelButton_Landscape->SetTextSize(30);
	__pCancelButton_Landscape->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pCancelButton_Landscape->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pCancelButton_Landscape->SetActionId(ID_BUTTON_CANCEL);
	__pCancelButton_Landscape->AddActionEventListener(*this);
	pLabel_Landscape.AddControl(__pCancelButton_Landscape);

	__pDeleteButton_Landscape = new (std::nothrow) Button;
	__pDeleteButton_Landscape->Construct(Rectangle(this->GetWidth()/2+10, this->GetHeight()-192, this->GetWidth()/2-30, 84), "");
	__pDeleteButton_Landscape->SetColor(BUTTON_STATUS_NORMAL, 0xffff7777);
	__pDeleteButton_Landscape->SetColor(BUTTON_STATUS_PRESSED, 0xffff3131);
	__pDeleteButton_Landscape->SetText(L"削除");
	__pDeleteButton_Landscape->SetTextColor(0xffffffff);
	__pDeleteButton_Landscape->SetTextSize(30);
	__pDeleteButton_Landscape->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pDeleteButton_Landscape->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pDeleteButton_Landscape->SetActionId(ID_BUTTON_DELETE);
	__pDeleteButton_Landscape->AddActionEventListener(*this);
	pLabel_Landscape.AddControl(__pDeleteButton_Landscape);
}

void
MyHondanaDeleteForm::DeleteCheckPopup(void)
{
	Rectangle clientRect= GetClientAreaBounds();
	Rectangle rect(0, 0, clientRect.width, clientRect.height);

	__pDeleteCheckPopup = new (std::nothrow) Popup();
	__pDeleteCheckPopup->Construct(true, Dimension(550, 356));
	__pDeleteCheckPopup->SetTitleText(L"削除 確認");
	__pDeleteCheckPopup->SetTitleTextColor(Color::GetColor(COLOR_ID_WHITE));
	__pDeleteCheckPopup->SetColor(0xff222222);

	__pDeleteCheckPopupPanel = new (std::nothrow) DeleteCheckPopupPanel(this);
	__pDeleteCheckPopupPanel->Construct(Rectangle(0, 0, clientRect.width, clientRect.height));

	__pDeleteCheckPopup->AddControl(__pDeleteCheckPopupPanel);
}


void
MyHondanaDeleteForm::DeleteCheckPopupHide(void)
{
	__pDeleteCheckPopup->SetShowState(false);
}

void
MyHondanaDeleteForm::OnDeleteCheckPopupPanelItemSelected(int selectIdx)
{
	switch (selectIdx) {
	case 1:
		break;
	default:
		break;
	}

	DeleteCheckPopupHide();
}

void
MyHondanaDeleteForm::OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId, const Tizen::Ui::Scenes::SceneId& nextSceneId)
{
}

void
MyHondanaDeleteForm::OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId, const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs)
{
}
