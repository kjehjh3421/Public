#include <new>
#include <FApp.h>
#include <FGraphics.h>
#include <FAppUiApp.h>
#include <FBase.h>
#include "MyHondanaMainForm.h"
#include "MyHondanaDetailForm.h"
#include "SceneRegister.h"
#include "AppResourceId.h"
#include "FUiLayout.h"
#include "FUiRelativeLayout.h"
#include "FUiVerticalBoxLayout.h"
#include "FUiHorizontalBoxLayout.h"
#include "FUiGridLayout.h"
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
using namespace Tizen::Base::Utility;

const wchar_t LIST_IMAGE_PATH1[] = L"book02.png";
const wchar_t LIST_IMAGE_PATH2[] = L"book02.png";
const wchar_t LIST_IMAGE_PATH3[] = L"list_new_book_icon.png";
const wchar_t LIST_IMAGE_PATH4[] = L"grid_new_book_icon.png";
const wchar_t LIST_IMAGE_PATH5[] = L"list_bottom_text.png";
const wchar_t LIST_IMAGE_PATH6[] = L"grid_bottom_text.png";

const wchar_t HEADER_BACKGROUND[] = L"header_background.png";
int  __dIndex;

namespace
{

bool isCoverFlow = false;

Dimension GridDimension(153, 260);

	enum
	{
		THUMBNAIL = 100,
		LIST = THUMBNAIL + 0x01,

		ID_BUTTON_BASE     = 110,
		ID_BUTTON_URL = ID_BUTTON_BASE + 0x00,
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

MyHondanaDetailForm::MyHondanaDetailForm(void)
	: __pDetailViewPanel(null)
	, __pListView(null)
	, __pCover(null)
	, __pBook(null)
	, __pHeaderBackground(null)
	, __pOptionMenu(null)
{
}

MyHondanaDetailForm::~MyHondanaDetailForm(void)
{
}

bool
MyHondanaDetailForm::Initialize(void)
{
	RelativeLayout relativeLayout;
	relativeLayout.Construct();
	this->Construct(relativeLayout, FORM_STYLE_NORMAL | FORM_STYLE_INDICATOR | FORM_STYLE_HEADER);

	return true;
}

result
MyHondanaDetailForm::OnInitializing(void)
{
	result r = E_SUCCESS;
	Control::OnInitializing();

	SetOrientation(ORIENTATION_AUTOMATIC);
	AddOrientationEventListener(*this);
	SetFormBackEventListener(this);
	SetFormMenuEventListener(this);
	this->SetBackgroundColor(Color::GetColor(COLOR_ID_BLACK));

	SetHeader();
	SetListView();

	OptionMenu();
	DeleteMenu();
	GetBitmap();
		
	return r;
}

result
MyHondanaDetailForm::OnTerminating(void)
{
	result r = E_SUCCESS;
	return r;
}

void
MyHondanaDetailForm::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	switch(actionId)
	{
	case ID_BUTTON_MARKET:
	{
		pSceneManager->GoForward(ForwardSceneTransition(SCENE_MARKET));
	}
		break;
	case ID_BUTTON_URL:
	{
		pSceneManager->GoForward(ForwardSceneTransition(SCENE_MARKET));
	}
		break;
		//***************************OPTION MENU : RENEWAL*******************************
	case ID_CONTEXT_OPTION_ITEM1:
	{

	}
		break;

		//***************************OPTION MENU : DELETE*******************************
	case ID_CONTEXT_OPTION_ITEM2:
	{
		__pDeleteMenu->SetShowState(true);
		__pDeleteMenu->Show();
	}
		break;

		//***************************OPTION MENU : DOWNLOAD*******************************
	case ID_CONTEXT_OPTION_ITEM3:
	{

	}
		break;

		//***************************OPTION MENU : SETTING*******************************
	case ID_CONTEXT_OPTION_ITEM4:
	{
		pSceneManager->GoForward(ForwardSceneTransition(SCENE_SETTING));
	}
		break;

		//***************************OPTION MENU : HELP*******************************
	case ID_CONTEXT_OPTION_ITEM5:
	{
	}
		break;
	default:
		break;
	}
}

void
MyHondanaDetailForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	pSceneManager->GoBackward(BackwardSceneTransition(SCENE_TRANSITION_ANIMATION_TYPE_RIGHT));
}

void
MyHondanaDetailForm::OnFormMenuRequested(Tizen::Ui::Controls::Form& source)
{

}


void
MyHondanaDetailForm::GetBitmap(void)
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
MyHondanaDetailForm::GetItemCount(void)
{
	return LIST_VIEW_MAIN_MENU_COUNT;
}

Tizen::Ui::Controls::ListItemBase*
MyHondanaDetailForm::CreateItem(int index, int itemWidth)
{
	struct LIST_ITEM {
			const Tizen::Graphics::Bitmap& bookbitmap;
			const Tizen::Base::String  		itemTitleText;
			const Tizen::Base::String		itemAuthorText;
			bool recommend;
			bool readbook;
	} LIST_ITEM[]= {
		 { * App::GetInstance()->GetAppResource()->GetBitmapN(L"book20.png"), L"しんじゅくすわんかぶきちょうすかうとさばいばる", L"いわさきなつみ", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book20.png"), L"しんじゅくすわんかぶきちょうすかうとさばいばる", L"いわさきなつみ", false, false }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book19.png"), L"わんかぶきちょうすかう", L"わさきみ", false, false }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book18.png"), L"くすわんかぶきちょうすかうとさば", L"わさきみ", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book17.png"), L"しんじゅく", L"わさきみ", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book16.png"), L"すわんかぶきちょうすかうとさばいばる", L"わきみ", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book15.png"), L"うとさばいばる", L"わきみ", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book14.png"), L"しんじょうすかうとさばいばる", L"わさみ", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book13.png"), L"ばいばる", L"さきみ", false, false }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book12.png"), L"しいばる", L"わさみ", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book11.png"), L"くすわんかぶきちょうすかうとさばいばる", L"わさ", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book10.png"), L"しんじゅくすうとさばいばる", L"わみ", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book09.png"), L"かうとさばいばる", L"わさきみ", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book08.png"), L"しばる", L"わさ", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book07.png"), L"ぶきちょうすかうといばる", L"わ", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book06.png"), L"ゅくすわんかちょうすかばいばる", L"わさきみ", false, false }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book05.png"), L"くすわんかぶきちすかうといばる", L"み", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book04.png"), L"しくすわんかうすかうとさばる", L"わさきみ", false, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book03.png"), L"しじゅくとさばいばる", L"わさみ", true, true }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book02.png"), L"ゅくすわんかぶきちょうすかうとさばいばる", L"み", true, false }
		,{ * App::GetInstance()->GetAppResource()->GetBitmapN(L"book01.png"), L"ばいばる", L"わさきみ", true, false }
	};

//	MyHondanaMainForm* mainForm = new MyHondanaMainForm();
	ListAnnexStyle style = LIST_ANNEX_STYLE_NORMAL;
	CustomItem* pItem = new (std::nothrow) CustomItem();
	Rectangle coverImageRect(20, 10, 70, 100);//96, 150);
	Rectangle bookImageRect(8, 77, 95, 40);
	Rectangle titlekanaRect(105, 15, this->GetWidth()-200, 40);
	Rectangle authornamekanaRect(105, 55, this->GetWidth()-170, 40);
	Rectangle releasedateRect(15, 80, 80, 30);
	Rectangle gotonewbookImageRect(this->GetWidth()-85, 30, 60, 60);//70, 153, 50
	Dimension itemDimension(100, 120);//160

	style = LIST_ANNEX_STYLE_NORMAL;

	pItem->Construct(itemDimension, style);
	pItem->AddElement(coverImageRect, ID_FORMAT_BITMAP, LIST_ITEM[__dIndex].bookbitmap, null, null);
	pItem->AddElement(titlekanaRect, ID_FORMAT_STRING, L"1 巻", 30, Color::GetColor(COLOR_ID_WHITE), Color::GetColor(COLOR_ID_WHITE), Color::GetColor(COLOR_ID_WHITE), true);
	pItem->AddElement(authornamekanaRect, ID_FORMAT_STRING2, LIST_ITEM[__dIndex].itemAuthorText, 26, Color::GetColor(COLOR_ID_WHITE), Color::GetColor(COLOR_ID_WHITE), Color::GetColor(COLOR_ID_WHITE), true);
	pItem->AddElement(releasedateRect, ID_FORMAT_STRING3, L"", 14, Color::GetColor(COLOR_ID_WHITE), Color::GetColor(COLOR_ID_WHITE), Color::GetColor(COLOR_ID_WHITE), true);
	return pItem;
}

bool
MyHondanaDetailForm::DeleteItem(int index, Tizen::Ui::Controls::ListItemBase* pItem, int itemWidth)
{
	delete pItem;
	pItem = null;
	return true;
}


void
MyHondanaDetailForm::SetHeader(void)
{
	AppResource *pAppResource = App::GetInstance()->GetAppResource();

	// Create header
	Header * pHeader = GetHeader();
	if (pHeader != null) {
		ButtonItem  buttonRightItem;
		buttonRightItem.Construct(BUTTON_ITEM_STYLE_ICON, ID_BUTTON_MARKET);
		buttonRightItem.SetIcon(BUTTON_ITEM_STATUS_NORMAL, pAppResource->GetBitmapN(L"btn_market_normal.png"));
		buttonRightItem.SetIcon(BUTTON_ITEM_STATUS_PRESSED, pAppResource->GetBitmapN(L"btn_market_pressed.png"));

		pHeader->SetStyle(HEADER_STYLE_TITLE);
		pHeader->SetBackgroundBitmap(pAppResource->GetBitmapN(L"header_background.png"));
		pHeader->SetTitleText(L"マイ本棚");

		pHeader->SetTitleTextColor(Color::GetColor(COLOR_ID_WHITE));
		pHeader->SetButton(BUTTON_POSITION_RIGHT, buttonRightItem);
	}
	pHeader->AddActionEventListener(*this);
}

void
MyHondanaDetailForm::SetListView(void)
{
	AppResource *pAppResource = App::GetInstance()->GetAppResource();
	Rectangle clientRect= GetClientAreaBounds();
	Rectangle rect(0,0,clientRect.width,clientRect.height);

	String str_title="しんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばる";
	String str_author = "岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海";
	int title_length = str_title.GetLength();
	int author_length = str_author.GetLength();
	int line_title_height = 41;
	int line_author_height = 29;
	//**************************************************************PORTRAIT*****************************************************************
	{
		int space_title_height_portrait = 0;
		int str_title_length_portrait = 20;
		if(title_length<=str_title_length_portrait)
			space_title_height_portrait = line_title_height;
		else if(title_length>str_title_length_portrait && title_length<=str_title_length_portrait*2)
			space_title_height_portrait = line_title_height*2;
		else if(title_length>str_title_length_portrait*2 && title_length<=str_title_length_portrait*3)
			space_title_height_portrait = line_title_height*3;
		else if(title_length>str_title_length_portrait*3 && title_length<=str_title_length_portrait*4)
			space_title_height_portrait = line_title_height*4;
		else if(title_length>str_title_length_portrait*4 && title_length<=str_title_length_portrait*5)
			space_title_height_portrait = line_title_height*5;
		else if(title_length>str_title_length_portrait*5 && title_length<=str_title_length_portrait*6)
			space_title_height_portrait = line_title_height*6;
		else if(title_length>str_title_length_portrait*6 && title_length<=str_title_length_portrait*7)
			space_title_height_portrait = line_title_height*7;
		else if(title_length>str_title_length_portrait*7 && title_length<=str_title_length_portrait*8)
			space_title_height_portrait = line_title_height*8;
		else if(title_length>str_title_length_portrait*8 && title_length<=str_title_length_portrait*9)
			space_title_height_portrait = line_title_height*9;
		else if(title_length>str_title_length_portrait*9)
			space_title_height_portrait = line_title_height*10;

		int space_author_height_portrait = 0;
		int str_author_length_portrait = 28;

		if(author_length<=str_author_length_portrait)
			space_author_height_portrait = line_author_height;
		else if(author_length>str_author_length_portrait && author_length<=str_author_length_portrait*2)
			space_author_height_portrait = line_author_height*2;
		else if(author_length>str_author_length_portrait*2 && author_length<=str_author_length_portrait*3)
			space_author_height_portrait = line_author_height*3;
		else if(author_length>str_author_length_portrait*3 && author_length<=str_author_length_portrait*4)
			space_author_height_portrait = line_author_height*4;
		else if(author_length>str_author_length_portrait*4 && author_length<=str_author_length_portrait*5)
			space_author_height_portrait = line_author_height*5;
		else if(author_length>str_author_length_portrait*5 && author_length<=str_author_length_portrait*6)
			space_author_height_portrait = line_author_height*6;
		else if(author_length>str_author_length_portrait*6)
			space_author_height_portrait = line_author_height*7;

		__pDetailViewPanel = new (std::nothrow) Panel();
		__pDetailViewPanel->Construct(rect);
		AddControl(*__pDetailViewPanel);

//		__pDetailTitle = new (std::nothrow) Label;
//		__pDetailTitle->Construct(Rectangle(0, 0, this->GetWidth(), space_title_height_portrait+30), str_title);
//		__pDetailTitle->SetBackgroundColor(0xff222222);
//		__pDetailTitle->SetTextConfig(35, LABEL_TEXT_STYLE_BOLD);
//		__pDetailTitle->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
//		__pDetailTitle->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
//		__pDetailViewPanel->AddControl(__pDetailTitle);
//
//		__pDetailTitleURL = new(std::nothrow) Button;
//		__pDetailTitleURL->Construct(Rectangle(this->GetWidth()-156, space_title_height_portrait+30-48, 146, 38), L"");
//		__pDetailTitleURL->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"download_store_popup_button.png"));
//		__pDetailTitleURL->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"download_store_popup_button.png"));
//		__pDetailTitleURL->SetActionId(ID_BUTTON_URL);
//		__pDetailTitleURL->AddActionEventListener(*this);
//		__pDetailViewPanel->AddControl(__pDetailTitleURL);

		__pDetailTitle = new (std::nothrow) TextBox;
		__pDetailTitle->Construct(Rectangle(0, 0, this->GetWidth(), space_title_height_portrait+30), TEXT_BOX_BORDER_NONE);
		__pDetailTitle->SetColor(TEXT_BOX_STATUS_NORMAL, 0xff222222);
		__pDetailTitle->SetColor(TEXT_BOX_STATUS_HIGHLIGHTED, 0xff222222);
		__pDetailTitle->SetTextColor(TEXT_BOX_TEXT_COLOR_LINK, Color::GetColor(COLOR_ID_WHITE));
		__pDetailTitle->SetTextSize(35);
		__pDetailTitle->SetTextStyle(TEXT_BOX_TEXT_STYLE_UNDERLINE);
		__pDetailTitle->SetText(str_title);
		__pDetailTitle->SetTextAlignment(ALIGNMENT_LEFT);
		__pDetailTitle->SetAutoLinkMask(1);
		__pDetailTitle->AddUiLinkEventListener(*this);
		__pDetailTitle->RemoveTextBlockEventListener(*this);
		__pDetailViewPanel->AddControl(__pDetailTitle);
		OnLinkClicked(*__pDetailTitle, str_title, LINK_TYPE_URL, L"http://www.naver.com");

		__pDetailTitleURL = new(std::nothrow) Button;
		__pDetailTitleURL->Construct(Rectangle(0, 0, this->GetWidth(), space_title_height_portrait+30), L"");
		__pDetailTitleURL->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"translate.png"));
		__pDetailTitleURL->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"translate.png"));
		__pDetailTitleURL->SetActionId(ID_BUTTON_URL);
		__pDetailTitleURL->AddActionEventListener(*this);
		__pDetailViewPanel->AddControl(__pDetailTitleURL);

		__pDetailAuthor = new (std::nothrow) Label;
		__pDetailAuthor->Construct(Rectangle(0, space_title_height_portrait+30, this->GetWidth(), space_author_height_portrait+20), str_author);
		__pDetailAuthor->SetBackgroundColor(0xff222222);
		__pDetailAuthor->SetTextColor(Color::GetColor(COLOR_ID_GREY));
		__pDetailAuthor->SetTextConfig(25, LABEL_TEXT_STYLE_NORMAL);
		__pDetailAuthor->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pDetailAuthor->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
		__pDetailViewPanel->AddControl(__pDetailAuthor);

		__pListView = new (std::nothrow) ListView();
		__pListView->Construct(Rectangle(0, space_title_height_portrait+space_author_height_portrait+50, this->GetWidth(), GetClientAreaBounds().height-(space_title_height_portrait+space_author_height_portrait)-50), true, SCROLL_STYLE_FADE_OUT);
		__pListView->SetItemProvider(*this);
		__pListView->AddListViewItemEventListener(*this);
		__pDetailViewPanel->AddControl(*__pListView);

	}

	//**************************************************************LANDSCAPE*****************************************************************
	{
		int space_title_height_landscape = 0;
		int str_title_length_landscape = 37;
		if(title_length<=str_title_length_landscape)
			space_title_height_landscape = line_title_height;
		else if(title_length>str_title_length_landscape && title_length<=str_title_length_landscape*2)
			space_title_height_landscape = line_title_height*2;
		else if(title_length>str_title_length_landscape*2 && title_length<=str_title_length_landscape*3)
			space_title_height_landscape = line_title_height*3;
		else if(title_length>str_title_length_landscape*3 && title_length<=str_title_length_landscape*4)
			space_title_height_landscape = line_title_height*4;
		else if(title_length>str_title_length_landscape*4 && title_length<=str_title_length_landscape*5)
			space_title_height_landscape = line_title_height*5;
		else if(title_length>str_title_length_landscape*5)
			space_title_height_landscape = line_title_height*6;

		int space_author_height_landscape = 0;
		int str_author_length_landscape = 52;
		if(author_length<=str_author_length_landscape)
			space_author_height_landscape = line_author_height;
		else if(author_length>str_author_length_landscape && author_length<=str_author_length_landscape*2)
			space_author_height_landscape = line_author_height*2;
		else if(author_length>str_author_length_landscape*2 && author_length<=str_author_length_landscape*3)
			space_author_height_landscape = line_author_height*3;
		else if(author_length>str_author_length_landscape*3)
			space_author_height_landscape = line_author_height*4;


		__pDetailViewScrollPanel = new (std::nothrow) ScrollPanel();
		__pDetailViewScrollPanel->Construct(rect);
		AddControl(*__pDetailViewScrollPanel);

//		__pDetailTitle_Landscape = new (std::nothrow) Label;
//		__pDetailTitle_Landscape->Construct(Rectangle(0, 0, this->GetWidth(), space_title_height_landscape+30), str_title);
//		__pDetailTitle_Landscape->SetBackgroundColor(0xff222222);
//		__pDetailTitle_Landscape->SetTextConfig(35, LABEL_TEXT_STYLE_BOLD);
//		__pDetailTitle_Landscape->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
//		__pDetailTitle_Landscape->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
//		__pDetailViewScrollPanel->AddControl(__pDetailTitle_Landscape);
//
//		__pDetailTitleURL_Landscape = new(std::nothrow) Button;
//		__pDetailTitleURL_Landscape->Construct(Rectangle(this->GetWidth()-156, space_title_height_landscape+30-48, 146, 38), L"");
//		__pDetailTitleURL_Landscape->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"download_store_popup_button.png"));
//		__pDetailTitleURL_Landscape->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"download_store_popup_button.png"));
//		__pDetailTitleURL_Landscape->SetActionId(ID_BUTTON_URL);
//		__pDetailTitleURL_Landscape->AddActionEventListener(*this);
//		__pDetailViewScrollPanel->AddControl(__pDetailTitleURL_Landscape);

		__pDetailTitle_Landscape = new (std::nothrow) TextBox;
		__pDetailTitle_Landscape->Construct(Rectangle(0, 0, this->GetWidth(), space_title_height_landscape+30), TEXT_BOX_BORDER_NONE);
		__pDetailTitle_Landscape->SetColor(TEXT_BOX_STATUS_NORMAL, 0xff222222);
		__pDetailTitle_Landscape->SetColor(TEXT_BOX_STATUS_HIGHLIGHTED, 0xff222222);
		__pDetailTitle_Landscape->SetTextColor(TEXT_BOX_TEXT_COLOR_NORMAL, Color::GetColor(COLOR_ID_WHITE));
		__pDetailTitle_Landscape->SetTextSize(35);
		__pDetailTitle_Landscape->SetTextStyle(TEXT_BOX_TEXT_STYLE_UNDERLINE);
		__pDetailTitle_Landscape->SetText(str_title);
		__pDetailTitle_Landscape->SetTextAlignment(ALIGNMENT_LEFT);
		__pDetailTitle_Landscape->AddUiLinkEventListener(*this);
		__pDetailTitle_Landscape->RemoveTextBlockEventListener(*this);
		__pDetailViewScrollPanel->AddControl(__pDetailTitle_Landscape);

		__pDetailTitleURL_Landscape = new(std::nothrow) Button;
		__pDetailTitleURL_Landscape->Construct(Rectangle(0, 0, this->GetWidth(), space_title_height_landscape+30), L"");
		__pDetailTitleURL_Landscape->SetNormalBackgroundBitmap(*pAppResource->GetBitmapN(L"translate.png"));
		__pDetailTitleURL_Landscape->SetPressedBackgroundBitmap(*pAppResource->GetBitmapN(L"translate.png"));
		__pDetailTitleURL_Landscape->SetActionId(ID_BUTTON_URL);
		__pDetailTitleURL_Landscape->AddActionEventListener(*this);
		__pDetailViewScrollPanel->AddControl(__pDetailTitleURL_Landscape);

		__pDetailAuthor_Landscape = new (std::nothrow) Label;
		__pDetailAuthor_Landscape->Construct(Rectangle(0, space_title_height_landscape+20, this->GetWidth(), space_author_height_landscape+20), str_author);
		__pDetailAuthor_Landscape->SetBackgroundColor(0xff222222);
		__pDetailAuthor_Landscape->SetTextColor(Color::GetColor(COLOR_ID_GREY));
		__pDetailAuthor_Landscape->SetTextConfig(25, LABEL_TEXT_STYLE_NORMAL);
		__pDetailAuthor_Landscape->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pDetailAuthor_Landscape->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
		__pDetailViewScrollPanel->AddControl(__pDetailAuthor_Landscape);

		__pListView_Landscape = new (std::nothrow) ListView();
		__pListView_Landscape->Construct(Rectangle(0, space_title_height_landscape+space_author_height_landscape+50, this->GetWidth(), LIST_VIEW_MAIN_MENU_COUNT*120/*GetClientAreaBounds().height-(space_title_height_landscape+space_author_height_landscape+20)*/), true, SCROLL_STYLE_FADE_OUT);
		__pListView_Landscape->SetItemProvider(*this);
		__pListView_Landscape->AddListViewItemEventListener(*this);
		__pDetailViewScrollPanel->AddControl(*__pListView_Landscape);
	}


	if(isFirstStart==true)
	{
		__pDetailViewPanel->SetShowState(true);
		__pDetailViewScrollPanel->SetShowState(false);
	}

}

void
MyHondanaDetailForm::OnListViewItemStateChanged(ListView& listView, int index, int elementId, ListItemStatus status)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	pSceneManager->GoForward(ForwardSceneTransition(SCENE_VIEWER));
}

void
MyHondanaDetailForm::OnListViewItemSwept(ListView& listView, int index, SweepDirection direction)
{
}

void
MyHondanaDetailForm::OnListViewContextItemStateChanged(ListView& listView, int index, int elementId, ListContextItemStatus state)
{
}

void
MyHondanaDetailForm::OnListViewItemLongPressed(ListView& listView, int index, int elementId, bool& invokeListViewItemCallback)
{
//	SceneManager* pSceneManager = SceneManager::GetInstance();
//	AppAssert(pSceneManager);
//	pSceneManager->GoForward(ForwardSceneTransition(SCENE_DETAIL));
}

void
MyHondanaDetailForm::OnOrientationChanged(const Control &source, OrientationStatus orientationStatus)
{
	__pDetailTitle->Destroy();
	__pDetailTitle_Landscape->Destroy();
	__pDetailAuthor->Destroy();
	__pDetailAuthor_Landscape->Destroy();
	__pListView->Destroy();
	__pListView_Landscape->Destroy();
	__pDetailViewPanel->Destroy();
	__pDetailViewScrollPanel->Destroy();

	SetListView();
	OptionMenu();
	if(GetOrientationStatus()==ORIENTATION_PORTRAIT)
	{
		__pDetailViewPanel->SetShowState(true);
		__pDetailViewScrollPanel->SetShowState(false);
	}
	else
	{
		__pDetailViewPanel->SetShowState(false);
		__pDetailViewScrollPanel->SetShowState(true);
	}

	this->RequestRedraw();
}

void
MyHondanaDetailForm::OnUserEventReceivedN(RequestId requestId, Tizen::Base::Collection::IList* pArgs)
{
	AppLogDebug("Detail_OnUserEventReceivedN = %d", __dIndex);
	__Indexlist = new Tizen::Base::Collection::ArrayList;
	Integer* pInt = static_cast< Integer* >(pArgs->GetAt(0));
	__dIndex = pInt->ToInt();
	delete pInt;
	AppLogDebug("Received = %d", __dIndex);
}


void
MyHondanaDetailForm::OptionMenu(void)
{
	AppResource* pAppResource = Application::GetInstance()->GetAppResource();

	__pOptionMenu = new (std::nothrow) ContextMenu();
	switch(GetOrientationStatus())
	{
		case ORIENTATION_PORTRAIT:
			__pOptionMenu->Construct(Point(665, 120), CONTEXT_MENU_STYLE_LIST, CONTEXT_MENU_ANCHOR_DIRECTION_DOWNWARD);
			__pOptionMenu->SetMaxVisibleItemsCount(5);
			break;
		case ORIENTATION_LANDSCAPE:
			__pOptionMenu->Construct(Point(1225, 55), CONTEXT_MENU_STYLE_LIST, CONTEXT_MENU_ANCHOR_DIRECTION_DOWNWARD);
			__pOptionMenu->SetMaxVisibleItemsCount(5);
			break;
		case ORIENTATION_LANDSCAPE_REVERSE:
			__pOptionMenu->Construct(Point(1225, 55), CONTEXT_MENU_STYLE_LIST, CONTEXT_MENU_ANCHOR_DIRECTION_DOWNWARD);
			__pOptionMenu->SetMaxVisibleItemsCount(5);
			break;
	}
	__pOptionMenu->AddItem(L"更新", ID_CONTEXT_OPTION_ITEM1, *pAppResource->GetBitmapN("optionmenu_icon_refresh.png"), pAppResource->GetBitmapN("optionmenu_icon_refresh.png"));
	__pOptionMenu->AddItem(L"削除", ID_CONTEXT_OPTION_ITEM2, *pAppResource->GetBitmapN("optionmenu_icon_delete.png"), pAppResource->GetBitmapN("optionmenu_icon_delete.png"));
	__pOptionMenu->AddItem(L"まとめてダウンロード", ID_CONTEXT_OPTION_ITEM3, *pAppResource->GetBitmapN("optionmenu_icon_download.png"), pAppResource->GetBitmapN("optionmenu_icon_download.png"));
	__pOptionMenu->AddItem(L"設定", ID_CONTEXT_OPTION_ITEM4, *pAppResource->GetBitmapN("optionmenu_icon_setting.png"), pAppResource->GetBitmapN("optionmenu_icon_setting.png"));
	__pOptionMenu->AddItem(L"ヘルプ", ID_CONTEXT_OPTION_ITEM5, *pAppResource->GetBitmapN("optionmenu_icon_help.png"), pAppResource->GetBitmapN("optionmenu_icon_help.png"));
	__pOptionMenu->SetColor(0xff333333);
	__pOptionMenu->AddActionEventListener(*this);
}

void
MyHondanaDetailForm::DeleteMenu(void)
{
	Rectangle clientRect= GetClientAreaBounds();
	Rectangle rect(0, 0, clientRect.width, clientRect.height);

	__pDeleteMenu = new (std::nothrow) Popup();
	__pDeleteMenu->Construct(true, Dimension(550, 500));
	__pDeleteMenu->SetTitleText(L"削除");
	__pDeleteMenu->SetTitleTextColor(Color::GetColor(COLOR_ID_WHITE));
	__pDeleteMenu->SetColor(0xff222222);

	__pDeletePanel = new (std::nothrow) DeletePopupPanel();
	__pDeletePanel->Construct(Rectangle(0, 0, clientRect.width, clientRect.height));

	__pDeleteMenu->AddControl(__pDeletePanel);
}

void
MyHondanaDetailForm::OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId, const Tizen::Ui::Scenes::SceneId& nextSceneId)
{
}

void
MyHondanaDetailForm::OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId, const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs)
{
}

void MyHondanaDetailForm::OnLinkClicked(Tizen::Ui::Control &source, const Tizen::Base::String &text, Tizen::Base::Utility::LinkType linkType, const Tizen::Base::String &link)
{
}

void MyHondanaDetailForm::OnTextBlockSelected(Tizen::Ui::Control &source, int start, int end)
{
}
