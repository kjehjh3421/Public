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
#include <FApp.h>
#include <FGraphics.h>
#include <FAppUiApp.h>
#include <FBase.h>
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
using namespace Tizen::Io;

namespace
{
	static const int SIZE_OF_LABEL_TEXT = 24;
	static const int SIZE_OF_BUTTON_X = 182;
	static const int SIZE_OF_SORT_BUTTON_X = 213;
	static const int SIZE_OF_BUTTON_Y = 80;

	enum
	{
		COVERFLOW_ON_THUMBNAIL = 100,
		COVERFLOW_ON_LIST = COVERFLOW_ON_THUMBNAIL + 0x01,
		COVERFLOW_OFF_THUMBNAIL = COVERFLOW_ON_THUMBNAIL + 0x02,
		COVERFLOW_OFF_LIST = COVERFLOW_ON_THUMBNAIL + 0x03,
		PORTRAIT = COVERFLOW_ON_THUMBNAIL + 0x04,
		LANDSCAPE = COVERFLOW_ON_THUMBNAIL + 0x05,

		ID_BUTTON_BASE     = 110,
		ID_BUTTON_COVERFLOW = ID_BUTTON_BASE + 0x00,
		ID_BUTTON_MARKET 	= ID_BUTTON_BASE + 0x01,
		ID_BUTTON_ACTIONBAR = ID_BUTTON_BASE + 0x02,
		ID_BUTTON_OPTION = ID_BUTTON_BASE + 0x03,
		ID_EXIT = ID_BUTTON_BASE + 0x04,
		ID_BUTTON_SORT = ID_BUTTON_BASE + 0x05,
		ID_BUTTON_NEWBOOK = ID_BUTTON_BASE + 0x06,
		ID_CONTEXT_ITEM1 = ID_BUTTON_BASE + 0x07, // ContextMenu : Date of purchase
		ID_CONTEXT_ITEM2 = ID_BUTTON_BASE + 0x08, // ContextMenu : Title
		ID_CONTEXT_ITEM3 = ID_BUTTON_BASE + 0x09, // ContextMenu : Author
		ID_CONTEXT_ITEM4 = ID_BUTTON_BASE + 0x10, // ContextMenu : Sort Set
		ID_CONTEXT_OPTION_ITEM1 = ID_BUTTON_BASE + 0x11, // ContextMenu : Option Item1 - View Change
		ID_CONTEXT_OPTION_ITEM2 = ID_BUTTON_BASE + 0x12, // ContextMenu : Option Item2 - Renewal
		ID_CONTEXT_OPTION_ITEM3 = ID_BUTTON_BASE + 0x13, // ContextMenu : Option Item3 - Delete
		ID_CONTEXT_OPTION_ITEM4 = ID_BUTTON_BASE + 0x14, // ContextMenu : Option Item4 - Download
		ID_CONTEXT_OPTION_ITEM5 = ID_BUTTON_BASE + 0x15, // ContextMenu : Option Item5 - Setting
		ID_CONTEXT_OPTION_ITEM6 = ID_BUTTON_BASE + 0x16, // ContextMenu : Option Item6 - help
	};

	bool isCoverFlow = false;
	bool isFirstStart = true;
	int mBookMode = COVERFLOW_ON_THUMBNAIL;
//	int mBookOrientationMode = PORTRAIT;
}

MyHondanaMainForm::MyHondanaMainForm(void)
: __transactionId(0)
{
	__nNewBookButtonImageNum = 0;

	for(int i=0 ; i < 3 ; i++) {
		__pBitmapNewBookNormal[i] = null;
	}
}

MyHondanaMainForm::~MyHondanaMainForm(void)
{
	for(int i=0 ; i < 3 ; i++) {
		if( __pBitmapNewBookNormal[i] ) {
			delete __pBitmapNewBookNormal[i];
			__pBitmapNewBookNormal[i] = null;
		}
	}
}

bool
MyHondanaMainForm::Initialize(void)
{
	RelativeLayout relativeLayout;
	relativeLayout.Construct();

	this->Construct(relativeLayout, FORM_STYLE_NORMAL | FORM_STYLE_INDICATOR | FORM_STYLE_LANDSCAPE_INDICATOR_AUTO_HIDE | FORM_STYLE_HEADER);
	__pHttpService = new HttpCommunicationService(this);

	return true;
}

result
MyHondanaMainForm::OnInitializing(void)
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

	StartConect(L"http://stg.book.dmkt-sp.jp/api/bookshelf/sync");
	ParseAndDisplay();
	GetBitmap();
	SetHeader();
	SetSplitPanel();
	SetButton();
	SetThumbnailView();
	SetListView();
	SortMenu();
	DeleteMenu();
	UpdateMenu();
	ContextOptionMenu();
	Play();

//	__timer.Construct(*this);
//	__timer.StartAsRepeatable(100);

	chkNewBook = false;
	isFirstStart = false;
	return r;
}

result
MyHondanaMainForm::OnTerminating(void)
{
	result r = E_SUCCESS;
	//Set Header()
	for(int i=0; i<2; i++)
	{
		delete __pButton_market[i];
		delete __pButton_contextmenu[i];
	}
	delete __pHeader_background;

	//Set Button()
	delete __pThumbnail_background_greyblack;
	delete __pDivider_background;
	for(int i=0; i<2; i++)
	{
		delete __pThumbnail_background[i];
		delete __pDivider_sortbutton[i];
		delete __pDivider_newbookbutton[i];
		delete __pDivider_coverflow_on_button[i];
		delete __pDivider_coverflow_off_button[i];
	}

	//ContextMenu()
	for(int i=0; i<2; i++)
	{
		delete __pOptionmenu_thumbnail[i];
		delete __pOptionmenu_list[i];
		delete __pOptionmenu_update[i];
		delete __pOptionmenu_delete[i];
		delete __pOptionmenu_download[i];
		delete __pOptionmenu_setting[i];
		delete __pOptionmenu_help[i];
	}

	//FormMenu
	for(int i=0; i<2; i++)
	{
		delete __pOptionmenu_thumbnail[i];
		delete __pOptionmenu_list[i];
		delete __pOptionmenu_update[i];
		delete __pOptionmenu_delete[i];
		delete __pOptionmenu_download[i];
		delete __pOptionmenu_setting[i];
		delete __pOptionmenu_help[i];
	}

	return r;
}

void
MyHondanaMainForm::GetBitmap(void)
{
	AppResource* pAppResource = Application::GetInstance()->GetAppResource();
	//**Thumbnail View / List View
	__pListNewBook = pAppResource->GetBitmapN(L"list_new_book_icon.png");
	__pGridNewBook = pAppResource->GetBitmapN(L"thumbnail_new_btn_1.png");
	__pListBottomText = pAppResource->GetBitmapN(L"list_bottom_text.png");
	__pGridBottomText = pAppResource->GetBitmapN(L"recently_thumbnail.png");

	//**Header
	__pHeader_background = pAppResource->GetBitmapN(L"header_background.png");
	__pButton_market[0] = pAppResource->GetBitmapN(L"btn_market_normal.png");
	__pButton_market[1] = pAppResource->GetBitmapN(L"btn_market_pressed.png");
	__pButton_contextmenu[0] = pAppResource->GetBitmapN(L"btn_actionbar.png");
	__pButton_contextmenu[1] = pAppResource->GetBitmapN(L"btn_actionbar_pressed.png");

	//**Option Menu / Context Menu
	__pOptionmenu_thumbnail[0] = pAppResource->GetBitmapN("optionmenu_icon_gridview.png");
	__pOptionmenu_thumbnail[1] = pAppResource->GetBitmapN("optionmenu_icon_gridview.png");
	__pOptionmenu_list[0] = pAppResource->GetBitmapN("optionmenu_icon_listview.png");
	__pOptionmenu_list[1] = pAppResource->GetBitmapN("optionmenu_icon_listview.png");
	__pOptionmenu_update[0] = pAppResource->GetBitmapN("optionmenu_icon_refresh.png");
	__pOptionmenu_update[1] = pAppResource->GetBitmapN("optionmenu_icon_refresh.png");
	__pOptionmenu_delete[0] = pAppResource->GetBitmapN("optionmenu_icon_delete.png");
	__pOptionmenu_delete[1] = pAppResource->GetBitmapN("optionmenu_icon_delete.png");
	__pOptionmenu_download[0] = pAppResource->GetBitmapN("optionmenu_icon_download.png");
	__pOptionmenu_download[1] = pAppResource->GetBitmapN("optionmenu_icon_download.png");
	__pOptionmenu_setting[0] = pAppResource->GetBitmapN("optionmenu_icon_setting.png");
	__pOptionmenu_setting[1] = pAppResource->GetBitmapN("optionmenu_icon_setting.png");
	__pOptionmenu_help[0] = pAppResource->GetBitmapN("optionmenu_icon_help.png");
	__pOptionmenu_help[1] = pAppResource->GetBitmapN("optionmenu_icon_help.png");

	//**Book List
	__pBookCover[0] = pAppResource->GetBitmapN(L"book20.png");
	__pBookCover[1] = pAppResource->GetBitmapN(L"book19.png");
	__pBookCover[2] = pAppResource->GetBitmapN(L"book18.png");
	__pBookCover[3] = pAppResource->GetBitmapN(L"book17.png");
	__pBookCover[4] = pAppResource->GetBitmapN(L"book16.png");
	__pBookCover[5] = pAppResource->GetBitmapN(L"book15.png");
	__pBookCover[6] = pAppResource->GetBitmapN(L"book14.png");
	__pBookCover[7] = pAppResource->GetBitmapN(L"book13.png");
	__pBookCover[8] = pAppResource->GetBitmapN(L"book12.png");
	__pBookCover[9] = pAppResource->GetBitmapN(L"book11.png");
	__pBookCover[10] = pAppResource->GetBitmapN(L"book10.png");
	__pBookCover[11] = pAppResource->GetBitmapN(L"book09.png");
	__pBookCover[12] = pAppResource->GetBitmapN(L"book08.png");
	__pBookCover[13] = pAppResource->GetBitmapN(L"book07.png");
	__pBookCover[14] = pAppResource->GetBitmapN(L"book06.png");
	__pBookCover[15] = pAppResource->GetBitmapN(L"book05.png");
	__pBookCover[16] = pAppResource->GetBitmapN(L"book04.png");
	__pBookCover[17] = pAppResource->GetBitmapN(L"book03.png");
	__pBookCover[18] = pAppResource->GetBitmapN(L"book02.png");
	__pBookCover[19] = pAppResource->GetBitmapN(L"book01.png");

	//**Button Animation
	__pBitmapNewBookNormal[0] = pAppResource->GetBitmapN(L"new_btn_ani_01.png");
	__pBitmapNewBookNormal[1] = pAppResource->GetBitmapN(L"new_btn_ani_02.png");
	__pBitmapNewBookNormal[2] = pAppResource->GetBitmapN(L"new_btn_ani_03.png");

	//**Divider Bar
	__pThumbnail_background_greyblack = pAppResource->GetBitmapN(L"thumbnail_background.png");
	__pThumbnail_background[0] = pAppResource->GetBitmapN(L"thumbnail_background_grey.png");
	__pThumbnail_background[1] = pAppResource->GetBitmapN(L"thumbnail_background_black.png");
	__pDivider_background = pAppResource->GetBitmapN(L"greenbar_bg.#.png");
	__pDivider_sortbutton[0] = pAppResource->GetBitmapN(L"dropdown_btn_nor.png");
	__pDivider_sortbutton[1] = pAppResource->GetBitmapN(L"dropdown_btn_pressed.png");
	__pDivider_newbookbutton[0] = pAppResource->GetBitmapN(L"new_btn_ani_03.png");
	__pDivider_newbookbutton[1] = pAppResource->GetBitmapN(L"new_btn_pressed.png");
	__pDivider_coverflow_on_button[0] = pAppResource->GetBitmapN(L"coverflow_off_normal.png");
	__pDivider_coverflow_on_button[1] = pAppResource->GetBitmapN(L"coverflow_off_pressed.png");
	__pDivider_coverflow_off_button[0] = pAppResource->GetBitmapN(L"coverflow_on_normal.png");
	__pDivider_coverflow_off_button[1] = pAppResource->GetBitmapN(L"coverflow_on_pressed.png");

	__pOverlay = pAppResource->GetBitmapN(L"download.png");
}

void
MyHondanaMainForm::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	switch(actionId)
	{
	//***************************COVERFLOW ON / OFF*******************************
	case ID_BUTTON_COVERFLOW:
		if(mBookMode == COVERFLOW_ON_THUMBNAIL)
		{
			__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
			__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
			__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(true);
			__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);

			mBookMode = COVERFLOW_OFF_THUMBNAIL;
		}
		else if(mBookMode == COVERFLOW_OFF_THUMBNAIL)
		{
			__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(true);
			__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
			__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
			__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);

			mBookMode = COVERFLOW_ON_THUMBNAIL;
		}
		else if(mBookMode == COVERFLOW_ON_LIST)
		{
			__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
			__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
			__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
			__pBackgroundPanel_CoverFlowOff_List->SetShowState(true);

			mBookMode = COVERFLOW_OFF_LIST;
		}
		else if(mBookMode == COVERFLOW_OFF_LIST)
		{
			__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
			__pBackgroundPanel_CoverFlowOn_List->SetShowState(true);
			__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
			__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);

			mBookMode = COVERFLOW_ON_LIST;
		}
		break;

	//***************************OPTION MENU*******************************
	case ID_BUTTON_ACTIONBAR:
		ContextOptionMenu();
		if(mBookMode == COVERFLOW_ON_THUMBNAIL)
		{
			__pContextMenu_Thumbnail->SetShowState(true);
			__pContextMenu_Thumbnail->Show();
		}
		else if(mBookMode == COVERFLOW_ON_LIST)
		{
			__pContextMenu_List->SetShowState(true);
			__pContextMenu_List->Show();
		}
		else if(mBookMode == COVERFLOW_OFF_THUMBNAIL)
		{
			__pContextMenu_Thumbnail->SetShowState(true);
			__pContextMenu_Thumbnail->Show();
		}
		else if(mBookMode == COVERFLOW_OFF_LIST)
		{
			__pContextMenu_List->SetShowState(true);
			__pContextMenu_List->Show();
		}
		break;

	//***************************STORE(MARKET)*******************************
	case ID_BUTTON_MARKET:
		{
			pSceneManager->GoForward(ForwardSceneTransition(SCENE_MARKET));
		}
		break;

	//***************************SORT MENU*******************************
	case ID_BUTTON_SORT:
		{
			__pSortMenu->SetShowState(true);
			__pSortMenu->Show();
		}
		break;

	//***************************NEWBOOK VIEW*******************************
	case ID_BUTTON_NEWBOOK:
		{
			if(chkNewBook)
			{
				__pNewBookViewButton_CoverFlowOn_Thumbnail->SetNormalBackgroundBitmap(*__pDivider_newbookbutton[0]);
				__pNewBookViewButton_CoverFlowOff_Thumbnail->SetNormalBackgroundBitmap(*__pDivider_newbookbutton[0]);
				__pNewBookViewButton_CoverFlowOn_List->SetNormalBackgroundBitmap(*__pDivider_newbookbutton[0]);
				__pNewBookViewButton_CoverFlowOff_List->SetNormalBackgroundBitmap(*__pDivider_newbookbutton[0]);
				chkNewBook = false;
			}
			else
			{
				__pNewBookViewButton_CoverFlowOn_Thumbnail->SetNormalBackgroundBitmap(*__pDivider_newbookbutton[1]);
				__pNewBookViewButton_CoverFlowOff_Thumbnail->SetNormalBackgroundBitmap(*__pDivider_newbookbutton[1]);
				__pNewBookViewButton_CoverFlowOn_List->SetNormalBackgroundBitmap(*__pDivider_newbookbutton[1]);
				__pNewBookViewButton_CoverFlowOff_List->SetNormalBackgroundBitmap(*__pDivider_newbookbutton[1]);
				chkNewBook = true;
			}
		}
		break;

		//***************************OPTION MENU : VIEW CHANGE*******************************
	case ID_CONTEXT_OPTION_ITEM1:
		{
			if(mBookMode == COVERFLOW_ON_THUMBNAIL)	// On -> Off
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(true);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);

				mBookMode = COVERFLOW_ON_LIST;
			}
			else if(mBookMode == COVERFLOW_OFF_THUMBNAIL)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(true);

				mBookMode = COVERFLOW_OFF_LIST;
			}
			else if(mBookMode == COVERFLOW_ON_LIST)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(true);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);

				mBookMode = COVERFLOW_ON_THUMBNAIL;
			}
			else if(mBookMode == COVERFLOW_OFF_LIST)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(true);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);

				mBookMode = COVERFLOW_OFF_THUMBNAIL;
			}
		}
		break;

		//***************************OPTION MENU : RENEWAL*******************************
	case ID_CONTEXT_OPTION_ITEM2:
		{
			__pUpdateMenu->SetShowState(true);
			__pUpdateMenu->Show();
		}
		break;

		//***************************OPTION MENU : DELETE*******************************
	case ID_CONTEXT_OPTION_ITEM3:
		{
			__pDeleteMenu->SetShowState(true);
			__pDeleteMenu->Show();
		}
		break;

		//***************************OPTION MENU : DOWNLOAD*******************************
	case ID_CONTEXT_OPTION_ITEM4:
		{
			pSceneManager->GoForward(ForwardSceneTransition(SCENE_VIEWER));
		}
		break;

		//***************************OPTION MENU : SETTING*******************************
	case ID_CONTEXT_OPTION_ITEM5:
		{
//			pSceneManager->GoForward(ForwardSceneTransition(SCENE_SETTING));
		}
		break;

		//***************************OPTION MENU : HELP*******************************
	case ID_CONTEXT_OPTION_ITEM6:
		{
//			pSceneManager->GoForward(ForwardSceneTransition(SCENE_HELP));
		}
		break;
	default:
		break;
	}
	Invalidate(true);
}

void
MyHondanaMainForm::OnOrientationChanged(const Control &source, OrientationStatus orientationStatus)
{
	SetSplitPanel();
	SetButton();
	SetThumbnailView();
	SetListView();
	UpdateMenu();

	switch(orientationStatus)
	{
		case ORIENTATION_STATUS_PORTRAIT:
			if(mBookMode == COVERFLOW_ON_THUMBNAIL)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(true);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);
			}
			else if(mBookMode == COVERFLOW_OFF_THUMBNAIL)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(true);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);
			}
			else if(mBookMode == COVERFLOW_ON_LIST)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(true);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);
			}
			else if(mBookMode == COVERFLOW_OFF_LIST)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(true);
			}

			break;
		case ORIENTATION_STATUS_LANDSCAPE:
			if(mBookMode == COVERFLOW_ON_THUMBNAIL)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(true);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);

				mBookMode = COVERFLOW_OFF_THUMBNAIL;
			}
			else if(mBookMode == COVERFLOW_OFF_THUMBNAIL)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(true);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);

				mBookMode = COVERFLOW_ON_THUMBNAIL;
			}
			else if(mBookMode == COVERFLOW_ON_LIST)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(true);

				mBookMode = COVERFLOW_OFF_LIST;
			}
			else if(mBookMode == COVERFLOW_OFF_LIST)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(true);

				mBookMode = COVERFLOW_ON_LIST;
			}
			break;
		case ORIENTATION_STATUS_LANDSCAPE_REVERSE:
			if(mBookMode == COVERFLOW_ON_THUMBNAIL)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(true);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);

				mBookMode = COVERFLOW_OFF_THUMBNAIL;
			}
			else if(mBookMode == COVERFLOW_OFF_THUMBNAIL)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(true);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);

				mBookMode = COVERFLOW_ON_THUMBNAIL;
			}
			else if(mBookMode == COVERFLOW_ON_LIST)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(true);

				mBookMode = COVERFLOW_OFF_LIST;
			}
			else if(mBookMode == COVERFLOW_OFF_LIST)
			{
				__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
				__pBackgroundPanel_CoverFlowOff_List->SetShowState(true);

				mBookMode = COVERFLOW_ON_LIST;
			}
			break;
	}
	Invalidate(true);
}

void
MyHondanaMainForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	UiApp* pApp = UiApp::GetInstance();
	AppAssert(pApp);
	pApp->Terminate();
}

void
MyHondanaMainForm::OnFormMenuRequested(Tizen::Ui::Controls::Form& source)
{
	//*************************************************Status : List****************************************************
	__pOptionKey_List = new (std::nothrow) OptionMenu();
	__pOptionKey_List->Construct();
	__pOptionKey_List->AddItem(L"表示切替", ID_CONTEXT_OPTION_ITEM1, *__pOptionmenu_thumbnail[0], __pOptionmenu_thumbnail[1]);
	__pOptionKey_List->AddItem(L"更新", ID_CONTEXT_OPTION_ITEM2, *__pOptionmenu_update[0], __pOptionmenu_update[1]);
	__pOptionKey_List->AddItem(L"削除", ID_CONTEXT_OPTION_ITEM3, *__pOptionmenu_delete[0], __pOptionmenu_delete[1]);
	__pOptionKey_List->AddItem(L"まとめてダウンロード", ID_CONTEXT_OPTION_ITEM4, *__pOptionmenu_download[0], __pOptionmenu_download[1]);
	__pOptionKey_List->AddItem(L"設定", ID_CONTEXT_OPTION_ITEM5, *__pOptionmenu_setting[0], __pOptionmenu_setting[1]);
	__pOptionKey_List->AddItem(L"ヘルプ", ID_CONTEXT_OPTION_ITEM6, *__pOptionmenu_help[0], __pOptionmenu_help[1]);
	__pOptionKey_List->SetMaxVisibleItemsCount(6);
	__pOptionKey_List->SetColor(0xff232323);
	__pOptionKey_List->AddActionEventListener(*this);

	//*************************************************Status : Thumbnail****************************************************
	__pOptionKey_Thumbnail = new (std::nothrow) OptionMenu();
	__pOptionKey_Thumbnail->Construct();
	__pOptionKey_Thumbnail->AddItem(L"表示切替", ID_CONTEXT_OPTION_ITEM1, *__pOptionmenu_list[0], __pOptionmenu_list[1]);
	__pOptionKey_Thumbnail->AddItem(L"更新", ID_CONTEXT_OPTION_ITEM2, *__pOptionmenu_update[0], __pOptionmenu_update[1]);
	__pOptionKey_Thumbnail->AddItem(L"削除", ID_CONTEXT_OPTION_ITEM3, *__pOptionmenu_delete[0], __pOptionmenu_delete[1]);
	__pOptionKey_Thumbnail->AddItem(L"まとめてダウンロード", ID_CONTEXT_OPTION_ITEM4, *__pOptionmenu_download[0], __pOptionmenu_download[1]);
	__pOptionKey_Thumbnail->AddItem(L"設定", ID_CONTEXT_OPTION_ITEM5, *__pOptionmenu_setting[0], __pOptionmenu_setting[1]);
	__pOptionKey_Thumbnail->AddItem(L"ヘルプ", ID_CONTEXT_OPTION_ITEM6, *__pOptionmenu_help[0], __pOptionmenu_help[1]);
	__pOptionKey_Thumbnail->SetMaxVisibleItemsCount(6);
	__pOptionKey_Thumbnail->SetColor(0xff232323);
	__pOptionKey_Thumbnail->AddActionEventListener(*this);

	if(mBookMode == COVERFLOW_ON_THUMBNAIL)
	{
		__pOptionKey_Thumbnail->SetShowState(true);
		__pOptionKey_Thumbnail->Show();
	}
	else if(mBookMode == COVERFLOW_ON_LIST)
	{
		__pOptionKey_List->SetShowState(true);
		__pOptionKey_List->Show();
	}
}

int
MyHondanaMainForm::GetItemCount(void)
{
	return LIST_VIEW_MAIN_MENU_COUNT;
}

ListItemBase*
MyHondanaMainForm::CreateItem(int index, int itemWidth)
{
	struct BOOK_LIST {
		const Tizen::Graphics::Bitmap*  bookbitmap;
		const Tizen::Base::String  		itemTitleText;
		const Tizen::Base::String		itemAuthorText;
		bool recommend;
		bool readbook;
	} BOOK_LIST_ITEM[]= {
		 { __pBookCover[0], L"しんじゅくすわんかぶきちょうすかうとさばいばる", L"いわさきなつみしんじゅくすわんかぶきちょうすかうとさばいばる", false, true }
		,{ __pBookCover[0], *(arTitleInfo[0].mTitleName), *(arTitleInfo[0].mAuthorName), false, false }
		,{ __pBookCover[1], L"わんかぶきちょうすかう", L"わさきみ", false, false }
		,{ __pBookCover[2], L"くすわんかぶきちょうすかうとさば", L"わさきみ", false, false }
		,{ __pBookCover[3], L"しんじゅく", L"わさきみ", false, false }
		,{ __pBookCover[4], L"すわんかぶきちょうすかうとさばいばる", L"わきみ", false, true }
		,{ __pBookCover[5], L"うとさばいばる", L"わきみ", false, true }
		,{ __pBookCover[6], L"しんじょうすかうとさばいばる", L"わさみ", false, true }
		,{ __pBookCover[7], L"ばいばる", L"さきみ", false, false }
		,{ __pBookCover[8], L"しいばる", L"わさみ", false, true }
		,{ __pBookCover[9], L"くすわんかぶきちょうすかうとさばいばる", L"わさ", false, true }
		,{ __pBookCover[10], L"しんじゅくすうとさばいばる", L"わみ", false, true }
		,{ __pBookCover[11], L"かうとさばいばる", L"わさきみ", false, true }
		,{ __pBookCover[12], L"しばる", L"わさ", false, true }
		,{ __pBookCover[13], L"ぶきちょうすかうといばる", L"わ", false, true }
		,{ __pBookCover[14], L"ゅくすわんかちょうすかばいばる", L"わさきみ", false, false }
		,{ __pBookCover[15], L"くすわんかぶきちすかうといばる", L"み", false, true }
		,{ __pBookCover[16], L"しくすわんかうすかうとさばる", L"わさきみ", false, true }
		,{ __pBookCover[17], L"しじゅくとさばいばる", L"わさみ", true, true }
		,{ __pBookCover[18], L"ゅくすわんかぶきちょうすかうとさばいばる", L"み", true, false }
		,{ __pBookCover[19], L"ばいばる", L"わさきみ", true, false }
	};

	ListAnnexStyle style = LIST_ANNEX_STYLE_NORMAL;

	CustomItem* pItem = new (std::nothrow) CustomItem();
	Rectangle coverImageRect(20, 6, 68, 106);//96, 150);
	Rectangle overlayRect(20,6,40,40);
	Rectangle bookImageRect(8, 76, 92, 40);
	Rectangle titlekanaRect(113, 20, this->GetWidth()-230, 34);
	Rectangle authornamekanaRect(113, 70, this->GetWidth()-230, 28);
	Rectangle releasedateRect(15, 80, 80, 30);
	Rectangle gotonewbookImageRect(this->GetWidth()-98, 20, 78, 78);//70, 153, 50
	Dimension itemDimension(100, 118);//160

	pItem->Construct(itemDimension, style);
	pItem->AddElement(coverImageRect, ID_FORMAT_BITMAP, *BOOK_LIST_ITEM[index].bookbitmap, null, null);
	pItem->AddElement(overlayRect, ID_FORMAT_BITMAP5, *__pOverlay, null, null);
	pItem->AddElement(titlekanaRect, ID_FORMAT_STRING, BOOK_LIST_ITEM[index].itemTitleText, 34, Color::GetColor(COLOR_ID_WHITE), Color::GetColor(COLOR_ID_WHITE), Color::GetColor(COLOR_ID_WHITE), true);
	pItem->AddElement(authornamekanaRect, ID_FORMAT_STRING2, BOOK_LIST_ITEM[index].itemAuthorText, 28, Color::GetColor(COLOR_ID_GREY), Color::GetColor(COLOR_ID_GREY), Color::GetColor(COLOR_ID_GREY), true);
	if(index==0)
		pItem->AddElement(bookImageRect, ID_FORMAT_BITMAP2, *__pListBottomText, null, null);
	if(BOOK_LIST_ITEM[index].readbook==false)
		pItem->AddElement(gotonewbookImageRect, ID_FORMAT_BITMAP3, *__pListNewBook, null, null);

	return pItem;

	for(int i=0; i<20; i++)
		delete __pBookCover[i];
	delete __pListBottomText;
	delete __pListNewBook;
	delete BOOK_LIST_ITEM[index].bookbitmap;
}

void
MyHondanaMainForm::OnListViewItemStateChanged(ListView& listView, int index, int elementId, ListItemStatus status)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	ArrayList* pList = new (std::nothrow) ArrayList();
	pList->Add(*(new (std::nothrow) Integer(index)));

	MyHondanaDetailForm* pDetailForm = new (std::nothrow) MyHondanaDetailForm;
	pDetailForm->Initialize();
	pDetailForm->AddControl(*pDetailForm);
	pDetailForm->SendUserEvent(MyHondanaMainForm::REQUEST_ID_SEND, pList);

	switch(elementId)
	{
	case ID_FORMAT_BITMAP3:
		pSceneManager->GoForward(ForwardSceneTransition(SCENE_MARKET));
		break;
	default:
		pSceneManager->GoForward(ForwardSceneTransition(SCENE_DETAIL, SCENE_TRANSITION_ANIMATION_TYPE_LEFT));
		break;
	}
	Invalidate(true);
}

bool
MyHondanaMainForm::DeleteItem(int index, Tizen::Ui::Controls::ListItemBase* pItem, int itemWidth)
{
	delete pItem;
	pItem = null;
	return true;
}

IconListViewItem*
MyHondanaMainForm::CreateItem(int index)
{
	struct BOOK_LIST {
		const Tizen::Graphics::Bitmap* bookbitmap;
		const Tizen::Base::String  		itemTitleText;
		const Tizen::Base::String		itemAuthorText;
		bool recommend;
		bool readbook;
	} BOOK_LIST_ITEM[]= {
		 { __pBookCover[0], L"しんじゅくすわんかぶきちょうすかうとさばいばる", L"いわさきなつみ", false, false }
		,{ __pBookCover[0], *(arTitleInfo[0].mTitleName), *(arTitleInfo[0].mAuthorName), false, false }
		,{ __pBookCover[1], L"わんかぶきちょうすかう", L"わさきみ", false, false }
		,{ __pBookCover[2], L"くすわんかぶきちょうすかうとさば", L"わさきみ", false, false }
		,{ __pBookCover[3], L"しんじゅく", L"わさきみ", false, false }
		,{ __pBookCover[4], L"すわんかぶきちょうすかうとさばいばる", L"わきみ", false, true }
		,{ __pBookCover[5], L"うとさばいばる", L"わきみ", false, true }
		,{ __pBookCover[6], L"しんじょうすかうとさばいばる", L"わさみ", false, true }
		,{ __pBookCover[7], L"ばいばる", L"さきみ", false, false }
		,{ __pBookCover[8], L"しいばる", L"わさみ", false, true }
		,{ __pBookCover[9], L"くすわんかぶきちょうすかうとさばいばる", L"わさ", false, true }
		,{ __pBookCover[10], L"しんじゅくすうとさばいばる", L"わみ", false, true }
		,{ __pBookCover[11], L"かうとさばいばる", L"わさきみ", false, true }
		,{ __pBookCover[12], L"しばる", L"わさ", false, true }
		,{ __pBookCover[13], L"ぶきちょうすかうといばる", L"わ", false, true }
		,{ __pBookCover[14], L"ゅくすわんかちょうすかばいばる", L"わさきみ", false, false }
		,{ __pBookCover[15], L"くすわんかぶきちすかうといばる", L"み", false, true }
		,{ __pBookCover[16], L"しくすわんかうすかうとさばる", L"わさきみ", false, true }
		,{ __pBookCover[17], L"しじゅくとさばいばる", L"わさみ", true, true }
		,{ __pBookCover[18], L"ゅくすわんかぶきちょうすかうとさばいばる", L"み", true, false }
		,{ __pBookCover[19], L"ばいばる", L"わさきみ", true, false }
	};

	IconListViewItem* pIconListview = new (std::nothrow) IconListViewItem();
	String itemText(L"");
	pIconListview->Construct(*BOOK_LIST_ITEM[index].bookbitmap, &itemText);



	if(index==0)
		pIconListview->SetOverlayBitmap(ID_FORMAT_BITMAP2, __pGridBottomText, ALIGNMENT_CENTER, ALIGNMENT_BOTTOM);
	if(BOOK_LIST_ITEM[index].readbook==false)
		pIconListview->SetOverlayBitmap(ID_FORMAT_BITMAP3, __pGridNewBook, ALIGNMENT_CENTER, ALIGNMENT_TOP);
	pIconListview->SetOverlayBitmap(ID_FORMAT_BITMAP5, __pOverlay, ALIGNMENT_LEFT, ALIGNMENT_TOP);

	return pIconListview;

	for(int i=0; i<20; i++)
		delete __pBookCover[i];
	delete __pGridBottomText;
	delete __pGridNewBook;
	delete BOOK_LIST_ITEM[index].bookbitmap;
}

void
MyHondanaMainForm::OnIconListViewOverlayBitmapSelected(IconListView& iconListView, int index, int overlayBitmapId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	switch(overlayBitmapId)
	{
	case ID_FORMAT_BITMAP3:
		pSceneManager->GoForward(ForwardSceneTransition(SCENE_MARKET));
		break;
	}
	Invalidate(true);
}

bool
MyHondanaMainForm::DeleteItem(int index, IconListViewItem* pItem)
{
	delete pItem;
	return true;
}


void
MyHondanaMainForm::OnListViewItemSwept(ListView& listView, int index, SweepDirection direction)
{
}

void
MyHondanaMainForm::OnListViewContextItemStateChanged(ListView& listView, int index, int elementId, ListContextItemStatus state)
{
}

void
MyHondanaMainForm::OnListViewItemLongPressed(ListView& listView, int index, int elementId, bool& invokeListViewItemCallback)
{
}

void
MyHondanaMainForm::OnIconListViewItemStateChanged(IconListView& view, int index, IconListViewItemStatus status)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	ArrayList* pList = new (std::nothrow) ArrayList();
	pList->Add(*(new (std::nothrow) Integer(index)));

	MyHondanaDetailForm* pDetailForm = new (std::nothrow) MyHondanaDetailForm;
	pDetailForm->Initialize();
	pDetailForm->AddControl(*pDetailForm);
	pDetailForm->SendUserEvent(MyHondanaMainForm::REQUEST_ID_SEND, pList);


	pSceneManager->GoForward(ForwardSceneTransition(SCENE_DETAIL, SCENE_TRANSITION_ANIMATION_TYPE_LEFT));
	Invalidate(true);
}

void
MyHondanaMainForm::SetHeader(void)
{
	// Create header
	Header * pHeader = GetHeader();
	if (pHeader != null)
	{
		pHeader->SetStyle(HEADER_STYLE_TITLE);
		pHeader->SetBackgroundBitmap(__pHeader_background);
		pHeader->SetTitleText(L"マイ本棚");
		pHeader->SetTitleTextColor(Color::GetColor(COLOR_ID_WHITE));

//		ButtonItem  buttonLeftItem;
//		buttonLeftItem.Construct(BUTTON_ITEM_STYLE_ICON, ID_BUTTON_MARKET);
//		buttonLeftItem.SetIcon(BUTTON_ITEM_STATUS_NORMAL, __pButton_market[0]);
//		buttonLeftItem.SetIcon(BUTTON_ITEM_STATUS_PRESSED, __pButton_market[1]);
//		pHeader->SetButton(BUTTON_POSITION_LEFT, buttonLeftItem);

		ButtonItem  buttonRightItem;

		buttonRightItem.Construct(BUTTON_ITEM_STYLE_ICON, ID_BUTTON_MARKET);
		buttonRightItem.SetBackgroundBitmap(BUTTON_ITEM_STATUS_NORMAL, __pHeader_background);
		buttonRightItem.SetBackgroundBitmap(BUTTON_ITEM_STATUS_PRESSED, __pHeader_background);
		buttonRightItem.SetIcon(BUTTON_ITEM_STATUS_NORMAL, __pButton_market[0]);
		buttonRightItem.SetIcon(BUTTON_ITEM_STATUS_PRESSED, __pButton_market[1]);
		pHeader->SetButton(BUTTON_POSITION_RIGHT, buttonRightItem);
	}
	pHeader->AddActionEventListener(*this);
}

void
MyHondanaMainForm::SetFooter(void)
{
}

void
MyHondanaMainForm::SetSplitPanel(void)
{
	RelativeLayout* pRelativeLayout = dynamic_cast<RelativeLayout*>(this->GetLayoutN());
	{
		//*********************************CoverFlowOn_Thumbnail View******************************************
		ScrollPanel* pPanel_On;
		__pBackgroundPanel_CoverFlowOn_Thumbnail = new (std::nothrow) ScrollPanel();
		__pBackgroundPanel_CoverFlowOn_Thumbnail->Construct(Rectangle(0, 0, this->GetWidth(), this->GetHeight()));
		__pBackgroundPanel_CoverFlowOn_Thumbnail->SetScrollPosition(500, true);
		__pBackgroundPanel_CoverFlowOn_Thumbnail->SetScrollBarVisible(true);
		pPanel_On = __pBackgroundPanel_CoverFlowOn_Thumbnail;
		this->AddControl(pPanel_On);

		pPanel_On->SetBackgroundColor(0xff222222);
		pRelativeLayout->SetRelation(*pPanel_On, this,	RECT_EDGE_RELATION_LEFT_TO_LEFT);
		pRelativeLayout->SetRelation(*pPanel_On, this,	RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
		pRelativeLayout->SetRelation(*pPanel_On, this,	RECT_EDGE_RELATION_TOP_TO_TOP);
		pRelativeLayout->SetRelation(*pPanel_On, this,	RECT_EDGE_RELATION_BOTTOM_TO_BOTTOM);

		//*********************************CoverFlowOff_Thumbnail View******************************************
		ScrollPanel* pPanel_Off;
		__pBackgroundPanel_CoverFlowOff_Thumbnail = new (std::nothrow) ScrollPanel();
		__pBackgroundPanel_CoverFlowOff_Thumbnail->Construct(Rectangle(0, 0, this->GetWidth(), this->GetHeight()));
		pPanel_Off = __pBackgroundPanel_CoverFlowOff_Thumbnail;
		this->AddControl(pPanel_Off);

		pPanel_Off->SetBackgroundColor(0xff222222);

		pRelativeLayout->SetRelation(*pPanel_Off, this,	RECT_EDGE_RELATION_LEFT_TO_LEFT);
		pRelativeLayout->SetRelation(*pPanel_Off, this,	RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
		pRelativeLayout->SetRelation(*pPanel_Off, this,	RECT_EDGE_RELATION_TOP_TO_TOP);
		pRelativeLayout->SetRelation(*pPanel_Off, this,	RECT_EDGE_RELATION_BOTTOM_TO_BOTTOM);

		//*********************************CoverFlowOn_List View******************************************
		ScrollPanel* pScrollPanel_On;
		__pBackgroundPanel_CoverFlowOn_List = new (std::nothrow) ScrollPanel();
		__pBackgroundPanel_CoverFlowOn_List->Construct(Rectangle(0, 0, this->GetWidth(), this->GetHeight()));
		pScrollPanel_On = __pBackgroundPanel_CoverFlowOn_List;
		this->AddControl(pScrollPanel_On);

		pScrollPanel_On->SetBackgroundColor(0xff222222);
		pRelativeLayout->SetRelation(*pScrollPanel_On, this, RECT_EDGE_RELATION_LEFT_TO_LEFT);
		pRelativeLayout->SetRelation(*pScrollPanel_On, this, RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
		pRelativeLayout->SetRelation(*pScrollPanel_On, this, RECT_EDGE_RELATION_TOP_TO_TOP);
		pRelativeLayout->SetRelation(*pScrollPanel_On, this, RECT_EDGE_RELATION_BOTTOM_TO_BOTTOM);


		//*********************************CoverFlowOff_List View******************************************
		ScrollPanel* pScrollPanel_Off;
		__pBackgroundPanel_CoverFlowOff_List = new (std::nothrow) ScrollPanel();
		__pBackgroundPanel_CoverFlowOff_List->Construct(Rectangle(0, 0, this->GetWidth(), this->GetHeight()));
		pScrollPanel_Off = __pBackgroundPanel_CoverFlowOff_List;
		this->AddControl(pScrollPanel_Off);

		pScrollPanel_Off->SetBackgroundColor(0xff222222);
		pRelativeLayout->SetRelation(*pScrollPanel_Off, this, RECT_EDGE_RELATION_LEFT_TO_LEFT);
		pRelativeLayout->SetRelation(*pScrollPanel_Off, this, RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
		pRelativeLayout->SetRelation(*pScrollPanel_Off, this, RECT_EDGE_RELATION_TOP_TO_TOP);
		pRelativeLayout->SetRelation(*pScrollPanel_Off, this, RECT_EDGE_RELATION_BOTTOM_TO_BOTTOM);
	}

	{
		//*********************************CoverFlow On_Thumbnail******************************************
		Panel* pCoverFlowOn_Thumbnail;
		__pCoverFlowOn_Thumbnail = new (std::nothrow) CoverFlowPanel();
		__pCoverFlowOn_Thumbnail->Construct(Rectangle(0, 0, this->GetWidth(), 260));
		pCoverFlowOn_Thumbnail = __pCoverFlowOn_Thumbnail;
		__pBackgroundPanel_CoverFlowOn_Thumbnail->AddControl(pCoverFlowOn_Thumbnail);

		pRelativeLayout->SetHorizontalFitPolicy(*pCoverFlowOn_Thumbnail, FIT_POLICY_PARENT);
		pRelativeLayout->SetRelation(*pCoverFlowOn_Thumbnail, this, RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
		pRelativeLayout->SetRelation(*pCoverFlowOn_Thumbnail, this, RECT_EDGE_RELATION_TOP_TO_TOP);

		//*********************************CoverFlow Off_Thumbnail******************************************
		Panel* pCoverFlowOff_Thumbnail;
		__pCoverFlowOff_Thumbnail = new (std::nothrow) CoverFlowPanel();
		__pCoverFlowOff_Thumbnail->Construct(Rectangle(0, 0, this->GetWidth(), 0));
		pCoverFlowOff_Thumbnail = __pCoverFlowOff_Thumbnail;
		__pBackgroundPanel_CoverFlowOff_Thumbnail->AddControl(pCoverFlowOff_Thumbnail);

		pRelativeLayout->SetHorizontalFitPolicy(*pCoverFlowOff_Thumbnail, FIT_POLICY_PARENT);
		pRelativeLayout->SetRelation(*pCoverFlowOff_Thumbnail, this, RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
		pRelativeLayout->SetRelation(*pCoverFlowOff_Thumbnail, this, RECT_EDGE_RELATION_TOP_TO_TOP);

		//*********************************CoverFlow On_List******************************************
		Panel* pCoverFlowOn_List;
		__pCoverFlowOn_List = new (std::nothrow) CoverFlowPanel();
		__pCoverFlowOn_List->Construct(Rectangle(0, 0, this->GetWidth(), 260));
		pCoverFlowOn_List = __pCoverFlowOn_List;
		__pBackgroundPanel_CoverFlowOn_List->AddControl(pCoverFlowOn_List);

		pRelativeLayout->SetHorizontalFitPolicy(*pCoverFlowOn_List, FIT_POLICY_PARENT);
		pRelativeLayout->SetRelation(*pCoverFlowOn_List, this, RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
		pRelativeLayout->SetRelation(*pCoverFlowOn_List, this, RECT_EDGE_RELATION_TOP_TO_TOP);

		//*********************************CoverFlow Off_List******************************************
		Panel* pCoverFlowOff_List;
		__pCoverFlowOff_List = new (std::nothrow) CoverFlowPanel();
		__pCoverFlowOff_List->Construct(Rectangle(0, 0, this->GetWidth(), 0));
		pCoverFlowOff_List = __pCoverFlowOff_List;
		__pBackgroundPanel_CoverFlowOff_List->AddControl(pCoverFlowOff_List);

		pRelativeLayout->SetHorizontalFitPolicy(*pCoverFlowOff_List, FIT_POLICY_PARENT);
		pRelativeLayout->SetRelation(*pCoverFlowOff_List, this, RECT_EDGE_RELATION_RIGHT_TO_RIGHT);
		pRelativeLayout->SetRelation(*pCoverFlowOff_List, this, RECT_EDGE_RELATION_TOP_TO_TOP);
	}

	//--------------isFirstStart--------------
	if(isFirstStart==true)
	{
		__pBackgroundPanel_CoverFlowOn_Thumbnail->SetShowState(true);
		__pBackgroundPanel_CoverFlowOn_List->SetShowState(false);
		__pBackgroundPanel_CoverFlowOff_Thumbnail->SetShowState(false);
		__pBackgroundPanel_CoverFlowOff_List->SetShowState(false);
	}

	delete pRelativeLayout;
	Invalidate(true);
}

void
MyHondanaMainForm::SetListView(void)
{
	int list_height = LIST_VIEW_MAIN_MENU_COUNT*118;

	//*********************************CoverFlow On******************************************
	Panel&          pListCoverFlowOn  = *__pBackgroundPanel_CoverFlowOn_List;

	__pListView_CoverFlowOn = new (std::nothrow) ListView();
	__pListView_CoverFlowOn->Construct(Rectangle(0, SIZE_OF_BUTTON_Y+260, this->GetWidth(), list_height), true, SCROLL_STYLE_FADE_OUT);
	__pListView_CoverFlowOn->SetItemProvider(*this);
	__pListView_CoverFlowOn->AddListViewItemEventListener(*this);
	pListCoverFlowOn.AddControl(*__pListView_CoverFlowOn);

	//*********************************CoverFlow Off******************************************
	Panel&          pListCoverFlowOff  = *__pBackgroundPanel_CoverFlowOff_List;

	__pListView_CoverFlowOff = new (std::nothrow) ListView();
	__pListView_CoverFlowOff->Construct(Rectangle(0, SIZE_OF_BUTTON_Y+0, this->GetWidth(), list_height), true, SCROLL_STYLE_FADE_OUT);
	__pListView_CoverFlowOff->SetItemProvider(*this);
	__pListView_CoverFlowOff->AddListViewItemEventListener(*this);
	pListCoverFlowOff.AddControl(*__pListView_CoverFlowOff);
	Invalidate(true);
}

void
MyHondanaMainForm::SetThumbnailView(void)
{
	//*******************************Thumbnail_Background***********************************
	int label_height_count;
	if(GetOrientationStatus()==ORIENTATION_STATUS_PORTRAIT)
	{
		if(LIST_VIEW_MAIN_MENU_COUNT%3==0)
			label_height_count = (LIST_VIEW_MAIN_MENU_COUNT/3);
		else
			label_height_count = (LIST_VIEW_MAIN_MENU_COUNT/3)+1;
	}
	else
	{
		if(LIST_VIEW_MAIN_MENU_COUNT%6==0)
			label_height_count = (LIST_VIEW_MAIN_MENU_COUNT/6);
		else
			label_height_count = (LIST_VIEW_MAIN_MENU_COUNT/6)+1;
	}

//	int thumbnail_height = label_height_count*360;
	//*********************************CoverFlow On******************************************
	Panel&          pThumbnailCoverFlowOn  = *__pBackgroundPanel_CoverFlowOn_Thumbnail;

	__pThumbnailView_CoverFlowOn = new (std::nothrow) IconListView();
	if(GetOrientationStatus()==ORIENTATION_STATUS_PORTRAIT)
	{
		__pThumbnailView_CoverFlowOn->Construct(Rectangle(0, SIZE_OF_BUTTON_Y-6+260, GetClientAreaBounds().width, (label_height_count*330)+52), Dimension (144,330), // book width 226
												ICON_LIST_VIEW_STYLE_NORMAL, ICON_LIST_VIEW_SCROLL_DIRECTION_VERTICAL, ICON_LIST_SCROLL_STYLE_FADE_OUT);
		__pThumbnailView_CoverFlowOn->SetMargin(MARGIN_TYPE_TOP, 52);
		__pThumbnailView_CoverFlowOn->SetMargin(MARGIN_TYPE_LEFT, 48);
		__pThumbnailView_CoverFlowOn->SetMargin(MARGIN_TYPE_RIGHT, 48);
		__pThumbnailView_CoverFlowOn->SetMargin(MARGIN_TYPE_BOTTOM, 0);
		__pThumbnailView_CoverFlowOn->SetItemSpacing(96, 0);
	}
	else
	{
		__pThumbnailView_CoverFlowOn->Construct(Rectangle(0, SIZE_OF_BUTTON_Y-6+260, GetClientAreaBounds().width, (label_height_count*330)+52), Dimension (144,330), // book width 226
												ICON_LIST_VIEW_STYLE_NORMAL, ICON_LIST_VIEW_SCROLL_DIRECTION_VERTICAL, ICON_LIST_SCROLL_STYLE_FADE_OUT);
		__pThumbnailView_CoverFlowOn->SetMargin(MARGIN_TYPE_TOP, 52);
		__pThumbnailView_CoverFlowOn->SetMargin(MARGIN_TYPE_LEFT, 58);
		__pThumbnailView_CoverFlowOn->SetMargin(MARGIN_TYPE_RIGHT, 58);
		__pThumbnailView_CoverFlowOn->SetMargin(MARGIN_TYPE_BOTTOM, 0);
		__pThumbnailView_CoverFlowOn->SetItemSpacing(60, 0);
	}
	__pThumbnailView_CoverFlowOn->SetItemBorderStyle(ICON_LIST_VIEW_ITEM_BORDER_STYLE_NONE);
	__pThumbnailView_CoverFlowOn->SetItemLayoutVerticalAlignment(ALIGNMENT_BOTTOM);
	__pThumbnailView_CoverFlowOn->SetItemProvider(*this);
	__pThumbnailView_CoverFlowOn->AddIconListViewItemEventListener(*this);
	pThumbnailCoverFlowOn.AddControl(*__pThumbnailView_CoverFlowOn);

	//*********************************CoverFlow Off******************************************
	Panel&          pThumbnailCoverFlowOff  = *__pBackgroundPanel_CoverFlowOff_Thumbnail;

	__pThumbnailView_CoverFlowOff = new (std::nothrow) IconListView();
	if(GetOrientationStatus()==ORIENTATION_STATUS_PORTRAIT)
	{
		__pThumbnailView_CoverFlowOff->Construct(Rectangle(0, SIZE_OF_BUTTON_Y-6, GetClientAreaBounds().width, (label_height_count*330)+52), Dimension (144,330), // book width 226
												ICON_LIST_VIEW_STYLE_NORMAL, ICON_LIST_VIEW_SCROLL_DIRECTION_VERTICAL, ICON_LIST_SCROLL_STYLE_FADE_OUT);
		__pThumbnailView_CoverFlowOff->SetMargin(MARGIN_TYPE_TOP, 52);
		__pThumbnailView_CoverFlowOff->SetMargin(MARGIN_TYPE_LEFT, 48);
		__pThumbnailView_CoverFlowOff->SetMargin(MARGIN_TYPE_RIGHT, 48);
		__pThumbnailView_CoverFlowOff->SetMargin(MARGIN_TYPE_BOTTOM, 0);
		__pThumbnailView_CoverFlowOff->SetItemSpacing(96, 0);
	}
	else
	{
		__pThumbnailView_CoverFlowOff->Construct(Rectangle(0, SIZE_OF_BUTTON_Y-6, GetClientAreaBounds().width, (label_height_count*330)+52), Dimension (144,330), // book width 226
												ICON_LIST_VIEW_STYLE_NORMAL, ICON_LIST_VIEW_SCROLL_DIRECTION_VERTICAL, ICON_LIST_SCROLL_STYLE_FADE_OUT);
		__pThumbnailView_CoverFlowOff->SetMargin(MARGIN_TYPE_TOP, 52);
		__pThumbnailView_CoverFlowOff->SetMargin(MARGIN_TYPE_LEFT, 58);
		__pThumbnailView_CoverFlowOff->SetMargin(MARGIN_TYPE_RIGHT, 58);
		__pThumbnailView_CoverFlowOff->SetMargin(MARGIN_TYPE_BOTTOM, 0);
		__pThumbnailView_CoverFlowOff->SetItemSpacing(60, 0);
	}
	__pThumbnailView_CoverFlowOff->SetItemBorderStyle(ICON_LIST_VIEW_ITEM_BORDER_STYLE_NONE);
	__pThumbnailView_CoverFlowOff->SetItemLayoutVerticalAlignment(ALIGNMENT_BOTTOM);
	__pThumbnailView_CoverFlowOff->SetItemProvider(*this);
	__pThumbnailView_CoverFlowOff->AddIconListViewItemEventListener(*this);
	pThumbnailCoverFlowOff.AddControl(*__pThumbnailView_CoverFlowOff);

	Invalidate(true);
}


void MyHondanaMainForm::OnTimerExpired(Timer& timer)
{

	iCntTimer--;

	if(iCntTimer == 0)
	{
		__timer.Cancel();
	}
	else
	{
		__pNewBookViewButton_CoverFlowOn_Thumbnail->SetNormalBackgroundBitmap( *__pBitmapNewBookNormal[__nNewBookButtonImageNum] );
		__pNewBookViewButton_CoverFlowOn_Thumbnail->RequestRedraw();

		__pNewBookViewButton_CoverFlowOff_Thumbnail->SetNormalBackgroundBitmap( *__pBitmapNewBookNormal[__nNewBookButtonImageNum] );
		__pNewBookViewButton_CoverFlowOff_Thumbnail->RequestRedraw();

		__pNewBookViewButton_CoverFlowOn_List->SetNormalBackgroundBitmap( *__pBitmapNewBookNormal[__nNewBookButtonImageNum] );
		__pNewBookViewButton_CoverFlowOn_List->RequestRedraw();

		__pNewBookViewButton_CoverFlowOff_List->SetNormalBackgroundBitmap( *__pBitmapNewBookNormal[__nNewBookButtonImageNum] );
		__pNewBookViewButton_CoverFlowOff_List->RequestRedraw();

		__nNewBookButtonImageNum ++;
		if( __nNewBookButtonImageNum >= 3 )
			__nNewBookButtonImageNum = 0;
	}
}

result
MyHondanaMainForm::Play(void)
{
	result r = E_SUCCESS;

//	bool showState;
//
//	if (GetAnimationDirection() == ANIMATION_FORWARD)
//	{
//		showState = false;
//	}
//	else
//	{
//		showState = true;
//	}
//
//	AnimationTransaction::Begin(__transactionId);
//
//	(__pNewBookViewButton_CoverFlowOn_Thumbnail->GetControlAnimator())->SetShowState(showState);
//
//	AnimationTransaction::Commit();
	int start, end;

	if (GetAnimationDirection() == ANIMATION_FORWARD)
	{
		start = 0;
		end = 1;
	}
	else
	{
		start = 1;
		end = 0;
	}

	IntegerAnimation animRightBottom(start, end, AnimationPropertyInfo::DEFAULT_DURATION, ANIMATION_INTERPOLATOR_LINEAR);

	_animationPropertyInfo.ApplyGlobalSettings(animRightBottom);

	(__pNewBookViewButton_CoverFlowOn_Thumbnail->GetControlAnimator())->StartUserAnimation(ANIMATION_TARGET_ALPHA, animRightBottom);
	return r;
}

void
MyHondanaMainForm::SetButton(void)
{
	//*********************************CoverFlow On_Thumbnail******************************************
	Panel&          pCoverFlowOn_Thumbnail  = *__pBackgroundPanel_CoverFlowOn_Thumbnail;
	pCoverFlowOn_Thumbnail.SetBackgroundColor(0xff000000); // 0xff222222

	{
		int y_space = 660; // dimension : y
		int i=0;
		int label_height_count;

		if(GetOrientationStatus()==ORIENTATION_STATUS_PORTRAIT)
		{
			if(LIST_VIEW_MAIN_MENU_COUNT%6==0)
			{
				label_height_count = (LIST_VIEW_MAIN_MENU_COUNT/6);
				Label* __pLabel_CoverFlowOn_Thumbnail_Background[label_height_count];
				if(label_height_count%2==0)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOn_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+260+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOn_Thumbnail.AddControl(__pLabel_CoverFlowOn_Thumbnail_Background[i]);
					}
				}
				else if(label_height_count%2==1)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOn_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+260+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOn_Thumbnail.AddControl(__pLabel_CoverFlowOn_Thumbnail_Background[i]);
					}
				}
			}
			else
			{
				label_height_count = ((LIST_VIEW_MAIN_MENU_COUNT/6)+1);
				Label* __pLabel_CoverFlowOn_Thumbnail_Background[label_height_count];
				if(label_height_count%2==0)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOn_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+260+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOn_Thumbnail.AddControl(__pLabel_CoverFlowOn_Thumbnail_Background[i]);
					}
				}
				else if(label_height_count%2==1)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOn_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+260+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOn_Thumbnail.AddControl(__pLabel_CoverFlowOn_Thumbnail_Background[i]);
					}
				}
			}
		}
		else
		{
			if(LIST_VIEW_MAIN_MENU_COUNT%6==0)
			{
				label_height_count = (LIST_VIEW_MAIN_MENU_COUNT/12);
				Label* __pLabel_CoverFlowOn_Thumbnail_Background[label_height_count];
				if(label_height_count%2==0)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOn_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+260+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOn_Thumbnail.AddControl(__pLabel_CoverFlowOn_Thumbnail_Background[i]);
					}
				}
				else if(label_height_count%2==1)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOn_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+260+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOn_Thumbnail.AddControl(__pLabel_CoverFlowOn_Thumbnail_Background[i]);
					}
				}
			}
			else
			{
				label_height_count = ((LIST_VIEW_MAIN_MENU_COUNT/12)+1);
				Label* __pLabel_CoverFlowOn_Thumbnail_Background[label_height_count];
				if(label_height_count%2==0)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOn_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+260+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOn_Thumbnail.AddControl(__pLabel_CoverFlowOn_Thumbnail_Background[i]);
					}
				}
				else if(label_height_count%2==1)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOn_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+260+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOn_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOn_Thumbnail.AddControl(__pLabel_CoverFlowOn_Thumbnail_Background[i]);
					}
				}
			}
		}
	}

	__pLabel_CoverFlowOn_Thumbnail = new (std::nothrow) Label;
	__pLabel_CoverFlowOn_Thumbnail->Construct(Rectangle(0, 260, this->GetWidth(), 74), "");
	__pLabel_CoverFlowOn_Thumbnail->SetTextConfig(SIZE_OF_LABEL_TEXT, LABEL_TEXT_STYLE_NORMAL);
	__pLabel_CoverFlowOn_Thumbnail->SetTextColor(Color::GetColor(COLOR_ID_WHITE));
	__pLabel_CoverFlowOn_Thumbnail->SetTextConfig(32, LABEL_TEXT_STYLE_NORMAL);
	__pLabel_CoverFlowOn_Thumbnail->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
	__pLabel_CoverFlowOn_Thumbnail->SetBackgroundBitmap(*__pDivider_background);
	pCoverFlowOn_Thumbnail.AddControl(__pLabel_CoverFlowOn_Thumbnail);

	__pSortButton_CoverFlowOn_Thumbnail = new (std::nothrow) Button;
	__pSortButton_CoverFlowOn_Thumbnail->Construct(Rectangle(19, 268, SIZE_OF_SORT_BUTTON_X, 58), "");
	__pSortButton_CoverFlowOn_Thumbnail->SetNormalBackgroundBitmap(*__pDivider_sortbutton[0]);
	__pSortButton_CoverFlowOn_Thumbnail->SetPressedBackgroundBitmap(*__pDivider_sortbutton[1]);
	__pSortButton_CoverFlowOn_Thumbnail->SetText("購入日順");
	__pSortButton_CoverFlowOn_Thumbnail->SetTextSize(30);
	__pSortButton_CoverFlowOn_Thumbnail->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
	__pSortButton_CoverFlowOn_Thumbnail->SetActionId(ID_BUTTON_SORT);
	__pSortButton_CoverFlowOn_Thumbnail->AddActionEventListener(*this);
	pCoverFlowOn_Thumbnail.AddControl(__pSortButton_CoverFlowOn_Thumbnail);

	__pNewBookViewButton_CoverFlowOn_Thumbnail = new (std::nothrow) Button;
	__pNewBookViewButton_CoverFlowOn_Thumbnail->Construct(Rectangle(SIZE_OF_SORT_BUTTON_X+18+19, 268, 184, 58), "");
	__pNewBookViewButton_CoverFlowOn_Thumbnail->SetNormalBackgroundBitmap(*__pDivider_newbookbutton[0]);
	__pNewBookViewButton_CoverFlowOn_Thumbnail->SetPressedBackgroundBitmap(*__pDivider_newbookbutton[1]);
	__pNewBookViewButton_CoverFlowOn_Thumbnail->SetActionId(ID_BUTTON_NEWBOOK);
	__pNewBookViewButton_CoverFlowOn_Thumbnail->AddActionEventListener(*this);
	pCoverFlowOn_Thumbnail.AddControl(__pNewBookViewButton_CoverFlowOn_Thumbnail);

	__pCoverFlowOnButton_Thumbnail = new (std::nothrow) Button;
	__pCoverFlowOnButton_Thumbnail->Construct(Rectangle(this->GetWidth()-SIZE_OF_BUTTON_X, 260, SIZE_OF_BUTTON_X, 64), "");
	__pCoverFlowOnButton_Thumbnail->SetNormalBackgroundBitmap(*__pDivider_coverflow_on_button[0]);
	__pCoverFlowOnButton_Thumbnail->SetPressedBackgroundBitmap(*__pDivider_coverflow_on_button[1]);
	__pCoverFlowOnButton_Thumbnail->SetActionId(ID_BUTTON_COVERFLOW);
	__pCoverFlowOnButton_Thumbnail->AddActionEventListener(*this);
	pCoverFlowOn_Thumbnail.AddControl(__pCoverFlowOnButton_Thumbnail);

	//*********************************CoverFlow On_List******************************************
	Panel&          pCoverFlowOn_List  = *__pBackgroundPanel_CoverFlowOn_List;
	pCoverFlowOn_List.SetBackgroundColor(0xff262626); // 0xff222222

	__pLabel_CoverFlowOn_List = new (std::nothrow) Label;
	__pLabel_CoverFlowOn_List->Construct(Rectangle(0, 260, this->GetWidth(), 74), "");
	__pLabel_CoverFlowOn_List->SetTextConfig(SIZE_OF_LABEL_TEXT, LABEL_TEXT_STYLE_NORMAL);
	__pLabel_CoverFlowOn_List->SetTextColor(Color::GetColor(COLOR_ID_WHITE));
	__pLabel_CoverFlowOn_List->SetTextConfig(32, LABEL_TEXT_STYLE_NORMAL);
	__pLabel_CoverFlowOn_List->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
	__pLabel_CoverFlowOn_List->SetBackgroundBitmap(*__pDivider_background);
	pCoverFlowOn_List.AddControl(__pLabel_CoverFlowOn_List);

	__pSortButton_CoverFlowOn_List = new (std::nothrow) Button;
	__pSortButton_CoverFlowOn_List->Construct(Rectangle(19, 268, SIZE_OF_SORT_BUTTON_X, 58), "");
	__pSortButton_CoverFlowOn_List->SetNormalBackgroundBitmap(*__pDivider_sortbutton[0]);
	__pSortButton_CoverFlowOn_List->SetPressedBackgroundBitmap(*__pDivider_sortbutton[1]);
	__pSortButton_CoverFlowOn_List->SetText("購入日順");
	__pSortButton_CoverFlowOn_List->SetTextSize(30);
	__pSortButton_CoverFlowOn_List->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
	__pSortButton_CoverFlowOn_List->SetActionId(ID_BUTTON_SORT);
	__pSortButton_CoverFlowOn_List->AddActionEventListener(*this);
	pCoverFlowOn_List.AddControl(__pSortButton_CoverFlowOn_List);

	__pNewBookViewButton_CoverFlowOn_List = new (std::nothrow) Button;
	__pNewBookViewButton_CoverFlowOn_List->Construct(Rectangle(SIZE_OF_SORT_BUTTON_X+18+19, 268, 184, 58), "");
	__pNewBookViewButton_CoverFlowOn_List->SetNormalBackgroundBitmap(*__pDivider_newbookbutton[0]);
	__pNewBookViewButton_CoverFlowOn_List->SetPressedBackgroundBitmap(*__pDivider_newbookbutton[1]);
	__pNewBookViewButton_CoverFlowOn_List->SetActionId(ID_BUTTON_NEWBOOK);
	__pNewBookViewButton_CoverFlowOn_List->AddActionEventListener(*this);
	pCoverFlowOn_List.AddControl(__pNewBookViewButton_CoverFlowOn_List);

	__pCoverFlowOnButton_List = new (std::nothrow) Button;
	__pCoverFlowOnButton_List->Construct(Rectangle(this->GetWidth()-SIZE_OF_BUTTON_X, 260, SIZE_OF_BUTTON_X, 64), "");
	__pCoverFlowOnButton_List->SetNormalBackgroundBitmap(*__pDivider_coverflow_on_button[0]);
	__pCoverFlowOnButton_List->SetPressedBackgroundBitmap(*__pDivider_coverflow_on_button[1]);
	__pCoverFlowOnButton_List->SetActionId(ID_BUTTON_COVERFLOW);
	__pCoverFlowOnButton_List->AddActionEventListener(*this);
	pCoverFlowOn_List.AddControl(__pCoverFlowOnButton_List);

	//*********************************CoverFlow Off_Thumbnail******************************************
	Panel&          pCoverFlowOff_Thumbnail  = *__pBackgroundPanel_CoverFlowOff_Thumbnail;
	pCoverFlowOff_Thumbnail.SetBackgroundColor(0xff000000); //0xff222222

	{
		int y_space = 660; // dimension : y
		int i=0;
		int label_height_count;

		if(GetOrientationStatus()==ORIENTATION_STATUS_PORTRAIT)
		{
			if(LIST_VIEW_MAIN_MENU_COUNT%6==0)
			{
				label_height_count = (LIST_VIEW_MAIN_MENU_COUNT/6);
				Label* __pLabel_CoverFlowOff_Thumbnail_Background[label_height_count];
				if(label_height_count%2==0)
				{

					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOff_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOff_Thumbnail.AddControl(__pLabel_CoverFlowOff_Thumbnail_Background[i]);
					}
				}
				else if(label_height_count%2==1)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOff_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOff_Thumbnail.AddControl(__pLabel_CoverFlowOff_Thumbnail_Background[i]);
					}
				}
			}
			else
			{
				label_height_count = ((LIST_VIEW_MAIN_MENU_COUNT/6)+1);
				Label* __pLabel_CoverFlowOff_Thumbnail_Background[label_height_count];
				if(label_height_count%2==0)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOff_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOff_Thumbnail.AddControl(__pLabel_CoverFlowOff_Thumbnail_Background[i]);
					}
				}
				else if(label_height_count%2==1)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOff_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOff_Thumbnail.AddControl(__pLabel_CoverFlowOff_Thumbnail_Background[i]);
					}
				}
			}
		}
		else
		{
			if(LIST_VIEW_MAIN_MENU_COUNT%6==0)
			{
				label_height_count = (LIST_VIEW_MAIN_MENU_COUNT/12);
				Label* __pLabel_CoverFlowOff_Thumbnail_Background[label_height_count];
				if(label_height_count%2==0)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOff_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOff_Thumbnail.AddControl(__pLabel_CoverFlowOff_Thumbnail_Background[i]);
					}
				}
				else if(label_height_count%2==1)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOff_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOff_Thumbnail.AddControl(__pLabel_CoverFlowOff_Thumbnail_Background[i]);
					}
				}
			}
			else
			{
				label_height_count = ((LIST_VIEW_MAIN_MENU_COUNT/12)+1);
				Label* __pLabel_CoverFlowOff_Thumbnail_Background[label_height_count];
				if(label_height_count%2==0)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOff_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOff_Thumbnail.AddControl(__pLabel_CoverFlowOff_Thumbnail_Background[i]);
					}
				}
				else if(label_height_count%2==1)
				{
					for(i=0; i<label_height_count; i++)
					{
						__pLabel_CoverFlowOff_Thumbnail_Background[i] = new (std::nothrow) Label;
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->Construct(Rectangle(0, (y_space*i)+74, this->GetWidth(), y_space/2), "");
						__pLabel_CoverFlowOff_Thumbnail_Background[i]->SetBackgroundBitmap(*__pThumbnail_background[0]);
						pCoverFlowOff_Thumbnail.AddControl(__pLabel_CoverFlowOff_Thumbnail_Background[i]);
					}
				}
			}
		}
	}

	__pLabel_CoverFlowOff_Thumbnail = new (std::nothrow) Label;
	__pLabel_CoverFlowOff_Thumbnail->Construct(Rectangle(0, 0, this->GetWidth(), 74), "");
	__pLabel_CoverFlowOff_Thumbnail->SetTextConfig(SIZE_OF_LABEL_TEXT, LABEL_TEXT_STYLE_NORMAL);
	__pLabel_CoverFlowOff_Thumbnail->SetTextColor(Color::GetColor(COLOR_ID_WHITE));
	__pLabel_CoverFlowOff_Thumbnail->SetTextConfig(32, LABEL_TEXT_STYLE_NORMAL);
	__pLabel_CoverFlowOff_Thumbnail->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
	__pLabel_CoverFlowOff_Thumbnail->SetBackgroundBitmap(*__pDivider_background);
	pCoverFlowOff_Thumbnail.AddControl(__pLabel_CoverFlowOff_Thumbnail);

	__pSortButton_CoverFlowOff_Thumbnail = new (std::nothrow) Button;
	__pSortButton_CoverFlowOff_Thumbnail->Construct(Rectangle(19, 8, SIZE_OF_SORT_BUTTON_X, 58), "");
	__pSortButton_CoverFlowOff_Thumbnail->SetNormalBackgroundBitmap(*__pDivider_sortbutton[0]);
	__pSortButton_CoverFlowOff_Thumbnail->SetPressedBackgroundBitmap(*__pDivider_sortbutton[1]);
	__pSortButton_CoverFlowOff_Thumbnail->SetText("購入日順");
	__pSortButton_CoverFlowOff_Thumbnail->SetTextSize(30);
	__pSortButton_CoverFlowOff_Thumbnail->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
	__pSortButton_CoverFlowOff_Thumbnail->SetActionId(ID_BUTTON_SORT);
	__pSortButton_CoverFlowOff_Thumbnail->AddActionEventListener(*this);
	pCoverFlowOff_Thumbnail.AddControl(__pSortButton_CoverFlowOff_Thumbnail);

	__pNewBookViewButton_CoverFlowOff_Thumbnail = new (std::nothrow) Button;
	__pNewBookViewButton_CoverFlowOff_Thumbnail->Construct(Rectangle(SIZE_OF_SORT_BUTTON_X+19+18, 8, 184, 58), "");
	__pNewBookViewButton_CoverFlowOff_Thumbnail->SetNormalBackgroundBitmap(*__pDivider_newbookbutton[0]);
	__pNewBookViewButton_CoverFlowOff_Thumbnail->SetPressedBackgroundBitmap(*__pDivider_newbookbutton[1]);
	__pNewBookViewButton_CoverFlowOff_Thumbnail->SetActionId(ID_BUTTON_NEWBOOK);
	__pNewBookViewButton_CoverFlowOff_Thumbnail->AddActionEventListener(*this);
	pCoverFlowOff_Thumbnail.AddControl(__pNewBookViewButton_CoverFlowOff_Thumbnail);

	__pCoverFlowOffButton_Thumbnail = new (std::nothrow) Button;
	__pCoverFlowOffButton_Thumbnail->Construct(Rectangle(this->GetWidth()-SIZE_OF_BUTTON_X, 0, SIZE_OF_BUTTON_X, 64), "");
	__pCoverFlowOffButton_Thumbnail->SetNormalBackgroundBitmap(*__pDivider_coverflow_off_button[0]);
	__pCoverFlowOffButton_Thumbnail->SetPressedBackgroundBitmap(*__pDivider_coverflow_off_button[1]);
	__pCoverFlowOffButton_Thumbnail->SetActionId(ID_BUTTON_COVERFLOW);
	__pCoverFlowOffButton_Thumbnail->AddActionEventListener(*this);
	pCoverFlowOff_Thumbnail.AddControl(__pCoverFlowOffButton_Thumbnail);

	//*********************************CoverFlow Off_List******************************************
	Panel&          pCoverFlowOff_List  = *__pBackgroundPanel_CoverFlowOff_List;
	pCoverFlowOff_List.SetBackgroundColor(0xff292929); // 0xff222222

	__pLabel_CoverFlowOff_List = new (std::nothrow) Label;
	__pLabel_CoverFlowOff_List->Construct(Rectangle(0, 0, this->GetWidth(), 74), "");
	__pLabel_CoverFlowOff_List->SetTextConfig(SIZE_OF_LABEL_TEXT, LABEL_TEXT_STYLE_NORMAL);
	__pLabel_CoverFlowOff_List->SetTextColor(Color::GetColor(COLOR_ID_WHITE));
	__pLabel_CoverFlowOff_List->SetTextConfig(32, LABEL_TEXT_STYLE_NORMAL);
	__pLabel_CoverFlowOff_List->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
	__pLabel_CoverFlowOff_List->SetBackgroundBitmap(*__pDivider_background);
	pCoverFlowOff_List.AddControl(__pLabel_CoverFlowOff_List);

	__pSortButton_CoverFlowOff_List = new (std::nothrow) Button;
	__pSortButton_CoverFlowOff_List->Construct(Rectangle(19, 8, SIZE_OF_SORT_BUTTON_X, 58), "");
	__pSortButton_CoverFlowOff_List->SetNormalBackgroundBitmap(*__pDivider_sortbutton[0]);
	__pSortButton_CoverFlowOff_List->SetPressedBackgroundBitmap(*__pDivider_sortbutton[1]);
	__pSortButton_CoverFlowOff_List->SetText("購入日順");
	__pSortButton_CoverFlowOff_List->SetTextSize(30);
	__pSortButton_CoverFlowOff_List->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
	__pSortButton_CoverFlowOff_List->SetActionId(ID_BUTTON_SORT);
	__pSortButton_CoverFlowOff_List->AddActionEventListener(*this);
	pCoverFlowOff_List.AddControl(__pSortButton_CoverFlowOff_List);

	__pNewBookViewButton_CoverFlowOff_List = new (std::nothrow) Button;
	__pNewBookViewButton_CoverFlowOff_List->Construct(Rectangle(SIZE_OF_SORT_BUTTON_X+19+18, 8, 184, 58), "");
	__pNewBookViewButton_CoverFlowOff_List->SetNormalBackgroundBitmap(*__pDivider_newbookbutton[0]);
	__pNewBookViewButton_CoverFlowOff_List->SetPressedBackgroundBitmap(*__pDivider_newbookbutton[1]);
	__pNewBookViewButton_CoverFlowOff_List->SetActionId(ID_BUTTON_NEWBOOK);
	__pNewBookViewButton_CoverFlowOff_List->AddActionEventListener(*this);
	pCoverFlowOff_List.AddControl(__pNewBookViewButton_CoverFlowOff_List);

	__pCoverFlowOffButton_List = new (std::nothrow) Button;
	__pCoverFlowOffButton_List->Construct(Rectangle(this->GetWidth()-SIZE_OF_BUTTON_X, 0, SIZE_OF_BUTTON_X, 64), "");
	__pCoverFlowOffButton_List->SetNormalBackgroundBitmap(*__pDivider_coverflow_off_button[0]);
	__pCoverFlowOffButton_List->SetPressedBackgroundBitmap(*__pDivider_coverflow_off_button[1]);
	__pCoverFlowOffButton_List->SetActionId(ID_BUTTON_COVERFLOW);
	__pCoverFlowOffButton_List->AddActionEventListener(*this);
	pCoverFlowOff_List.AddControl(__pCoverFlowOffButton_List);
}

void
MyHondanaMainForm::ContextOptionMenu(void)
{
	//*************************************************Thumbnail****************************************************
	__pContextMenu_Thumbnail = new (std::nothrow) ContextMenu();
	switch(GetOrientationStatus())
	{
		case ORIENTATION_STATUS_PORTRAIT:
		{
			__pContextMenu_Thumbnail->Construct(Point(665, 120),CONTEXT_MENU_STYLE_LIST, CONTEXT_MENU_ANCHOR_DIRECTION_DOWNWARD);
			__pContextMenu_Thumbnail->SetMaxVisibleItemsCount(6);
		}
			break;
		case ORIENTATION_STATUS_LANDSCAPE:
		{
			__pContextMenu_Thumbnail->Construct(Point(1225, 55),CONTEXT_MENU_STYLE_LIST, CONTEXT_MENU_ANCHOR_DIRECTION_DOWNWARD);
			__pContextMenu_Thumbnail->SetMaxVisibleItemsCount(5);
		}
			break;
		case ORIENTATION_STATUS_LANDSCAPE_REVERSE:
		{
			__pContextMenu_Thumbnail->Construct(Point(1225, 55),CONTEXT_MENU_STYLE_LIST, CONTEXT_MENU_ANCHOR_DIRECTION_DOWNWARD);
			__pContextMenu_Thumbnail->SetMaxVisibleItemsCount(5);
		}
			break;
	}
	__pContextMenu_Thumbnail->AddItem(L"表示切替", ID_CONTEXT_OPTION_ITEM1, *__pOptionmenu_list[0], __pOptionmenu_list[1]);
	__pContextMenu_Thumbnail->AddItem(L"更新", ID_CONTEXT_OPTION_ITEM2, *__pOptionmenu_update[0], __pOptionmenu_update[1]);
	__pContextMenu_Thumbnail->AddItem(L"削除", ID_CONTEXT_OPTION_ITEM3, *__pOptionmenu_delete[0], __pOptionmenu_delete[1]);
	__pContextMenu_Thumbnail->AddItem(L"まとめてダウンロード", ID_CONTEXT_OPTION_ITEM4, *__pOptionmenu_download[0], __pOptionmenu_download[1]);
	__pContextMenu_Thumbnail->AddItem(L"設定", ID_CONTEXT_OPTION_ITEM5, *__pOptionmenu_setting[0], __pOptionmenu_setting[1]);
	__pContextMenu_Thumbnail->AddItem(L"ヘルプ", ID_CONTEXT_OPTION_ITEM6, *__pOptionmenu_help[0], __pOptionmenu_help[1]);
	__pContextMenu_Thumbnail->SetColor(0xff232323);
	__pContextMenu_Thumbnail->AddActionEventListener(*this);

	//*************************************************List****************************************************
	__pContextMenu_List = new (std::nothrow) ContextMenu();
	switch(GetOrientationStatus())
	{
		case ORIENTATION_STATUS_PORTRAIT:
		{
			__pContextMenu_List->Construct(Point(665, 120),CONTEXT_MENU_STYLE_LIST, CONTEXT_MENU_ANCHOR_DIRECTION_DOWNWARD);
			__pContextMenu_List->SetMaxVisibleItemsCount(6);
		}
			break;
		case ORIENTATION_STATUS_LANDSCAPE:
		{
			__pContextMenu_List->Construct(Point(1225, 55),CONTEXT_MENU_STYLE_LIST, CONTEXT_MENU_ANCHOR_DIRECTION_DOWNWARD);
			__pContextMenu_List->SetMaxVisibleItemsCount(5);
		}
			break;
		case ORIENTATION_STATUS_LANDSCAPE_REVERSE:
		{
			__pContextMenu_List->Construct(Point(1225, 55),CONTEXT_MENU_STYLE_LIST, CONTEXT_MENU_ANCHOR_DIRECTION_DOWNWARD);
			__pContextMenu_List->SetMaxVisibleItemsCount(5);
		}
			break;
	}
	__pContextMenu_List->AddItem(L"表示切替", ID_CONTEXT_OPTION_ITEM1, *__pOptionmenu_thumbnail[0], __pOptionmenu_thumbnail[1]);
	__pContextMenu_List->AddItem(L"更新", ID_CONTEXT_OPTION_ITEM2, *__pOptionmenu_update[0], __pOptionmenu_update[1]);
	__pContextMenu_List->AddItem(L"削除", ID_CONTEXT_OPTION_ITEM3, *__pOptionmenu_delete[0], __pOptionmenu_delete[1]);
	__pContextMenu_List->AddItem(L"まとめてダウンロード", ID_CONTEXT_OPTION_ITEM4, *__pOptionmenu_download[0], __pOptionmenu_download[1]);
	__pContextMenu_List->AddItem(L"設定", ID_CONTEXT_OPTION_ITEM5, *__pOptionmenu_setting[0], __pOptionmenu_setting[1]);
	__pContextMenu_List->AddItem(L"ヘルプ", ID_CONTEXT_OPTION_ITEM6, *__pOptionmenu_help[0], __pOptionmenu_help[1]);
	__pContextMenu_List->SetColor(0xff282828);
	__pContextMenu_List->AddActionEventListener(*this);
}

void
MyHondanaMainForm::SortMenu(void)
{
	Rectangle clientRect= GetClientAreaBounds();
	Rectangle rect(0, 0, clientRect.width, clientRect.height);

	__pSortMenu = new (std::nothrow) Popup();
	__pSortMenu->Construct(false, Dimension(500, 400));
	__pSortMenu->SetColor(0xff222222);

	__pSortPanel = new (std::nothrow) SortPopupPanel(this);
	__pSortPanel->Construct(Rectangle(0, 0, clientRect.width, clientRect.height));
	__pSortMenu->AddControl(__pSortPanel);

	Invalidate(true);
}

void
MyHondanaMainForm::SortMenuHide(void)
{
	__pSortMenu->SetShowState(false);
	Invalidate(true);
}

void
MyHondanaMainForm::OnSortPanelItemSelected(int selectIdx)
{
	switch (selectIdx) {
	case 1:
		__pSortButton_CoverFlowOn_Thumbnail->SetText("購入日順");
		__pSortButton_CoverFlowOn_Thumbnail->SetTextSize(30);
		__pSortButton_CoverFlowOn_Thumbnail->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pSortButton_CoverFlowOff_Thumbnail->SetText("購入日順");
		__pSortButton_CoverFlowOff_Thumbnail->SetTextSize(30);
		__pSortButton_CoverFlowOff_Thumbnail->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pSortButton_CoverFlowOn_List->SetText("購入日順");
		__pSortButton_CoverFlowOn_List->SetTextSize(30);
		__pSortButton_CoverFlowOn_List->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pSortButton_CoverFlowOff_List->SetText("購入日順");
		__pSortButton_CoverFlowOff_List->SetTextSize(30);
		__pSortButton_CoverFlowOff_List->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		break;
	case 2:
		__pSortButton_CoverFlowOn_Thumbnail->SetText("作品名順");
		__pSortButton_CoverFlowOn_Thumbnail->SetTextSize(30);
		__pSortButton_CoverFlowOn_Thumbnail->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pSortButton_CoverFlowOff_Thumbnail->SetText("作品名順");
		__pSortButton_CoverFlowOff_Thumbnail->SetTextSize(30);
		__pSortButton_CoverFlowOff_Thumbnail->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pSortButton_CoverFlowOn_List->SetText("作品名順");
		__pSortButton_CoverFlowOn_List->SetTextSize(30);
		__pSortButton_CoverFlowOn_List->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pSortButton_CoverFlowOff_List->SetText("作品名順");
		__pSortButton_CoverFlowOff_List->SetTextSize(30);
		__pSortButton_CoverFlowOff_List->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		break;
	case 3:
		__pSortButton_CoverFlowOn_Thumbnail->SetText("作家名順");
		__pSortButton_CoverFlowOn_Thumbnail->SetTextSize(30);
		__pSortButton_CoverFlowOn_Thumbnail->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pSortButton_CoverFlowOff_Thumbnail->SetText("作家名順");
		__pSortButton_CoverFlowOff_Thumbnail->SetTextSize(30);
		__pSortButton_CoverFlowOff_Thumbnail->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pSortButton_CoverFlowOn_List->SetText("作家名順");
		__pSortButton_CoverFlowOn_List->SetTextSize(30);
		__pSortButton_CoverFlowOn_List->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pSortButton_CoverFlowOff_List->SetText("作家名順");
		__pSortButton_CoverFlowOff_List->SetTextSize(30);
		__pSortButton_CoverFlowOff_List->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		break;
	case 4:
		__pSortButton_CoverFlowOn_Thumbnail->SetText("保存済み");
		__pSortButton_CoverFlowOn_Thumbnail->SetTextSize(30);
		__pSortButton_CoverFlowOn_Thumbnail->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pSortButton_CoverFlowOff_Thumbnail->SetText("保存済み");
		__pSortButton_CoverFlowOff_Thumbnail->SetTextSize(30);
		__pSortButton_CoverFlowOff_Thumbnail->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pSortButton_CoverFlowOn_List->SetText("保存済み");
		__pSortButton_CoverFlowOn_List->SetTextSize(30);
		__pSortButton_CoverFlowOn_List->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		__pSortButton_CoverFlowOff_List->SetText("保存済み");
		__pSortButton_CoverFlowOff_List->SetTextSize(30);
		__pSortButton_CoverFlowOff_List->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
		break;
	default:
		break;
	}

	SortMenuHide();
}

void
MyHondanaMainForm::DeleteMenu(void)
{
	Rectangle clientRect= GetClientAreaBounds();
	Rectangle rect(0, 0, clientRect.width, clientRect.height);

	__pDeleteMenu = new (std::nothrow) Popup();
	__pDeleteMenu->Construct(true, Dimension(550, 500));
	__pDeleteMenu->SetTitleText(L"削除");
	__pDeleteMenu->SetTitleTextColor(Color::GetColor(COLOR_ID_WHITE));
	__pDeleteMenu->SetColor(0xff222222);


	__pDeletePanel = new (std::nothrow) DeletePopupPanel(this);
	__pDeletePanel->Construct(Rectangle(0, 0, clientRect.width, clientRect.height));

	__pDeleteMenu->AddControl(__pDeletePanel);

	Invalidate(true);
}

void
MyHondanaMainForm::DeleteMenuHide(void)
{
	__pDeleteMenu->SetShowState(false);
	Invalidate(true);
}

void
MyHondanaMainForm::OnDeletePanelItemSelected(int selectIdx)
{
	switch (selectIdx) {
	case 1:
		break;
	default:
		break;
	}

	DeleteMenuHide();
}

void
MyHondanaMainForm::UpdateMenu(void)
{
	__pUpdateMenu = new (std::nothrow) ProgressPopup();
	__pUpdateMenu->Construct(true,false);
	__pUpdateMenu->SetTitleText(L"Renewal");

	switch(GetOrientationStatus())
	{
		case ORIENTATION_STATUS_PORTRAIT:
			__pUpdateMenu->SetText(L"                갱신중입니다!");
			break;
		case ORIENTATION_STATUS_LANDSCAPE:
			__pUpdateMenu->SetText(L"                           갱신중입니다!");
			break;
		case ORIENTATION_STATUS_LANDSCAPE_REVERSE:
			__pUpdateMenu->SetText(L"                           갱신중입니다!");
			break;
	}
	__pUpdateMenu->AddProgressPopupEventListener(*this);
	Invalidate(true);
}

void
MyHondanaMainForm::OnProgressPopupCanceled(void)
{
	__pUpdateMenu->SetShowState(false);
	Invalidate(true);
}

void
MyHondanaMainForm::OnScreenOn(void)
{
	PowerManager::KeepScreenOnState(true, false);
}

void
MyHondanaMainForm::OnScreenOff(void)
{
}

void
MyHondanaMainForm::RemoveScrollEventListener(IScrollEventListener& listener)
{
}

void
MyHondanaMainForm::OnScrollEndReached(Tizen::Ui::Control& source, Tizen::Ui::Controls::ScrollEndEvent type)
{
}


void
MyHondanaMainForm::OnDividerPositionChanged(SplitPanel& source, float position)
{
}

void
MyHondanaMainForm::OnDividerDoublePressed(SplitPanel& source)
{
}

void
MyHondanaMainForm::OnAnimationStopped(const Tizen::Ui::Control& source)
{

}


// Json Parser Start --------------------------------------------------------------------------------------------
//Recursively traverse IJsonValue obtained by parser (using ParseN)
void
MyHondanaMainForm::TraverseFunction(IJsonValue* pValue)
{
	TryReturnVoid(pValue, "input jsonvalue pointer is null");
	iIndex = 0;

	switch (pValue->GetType())
	{
	case JSON_TYPE_OBJECT:
	{
		JsonObject* pObject = static_cast< JsonObject* >(pValue);
		IMapEnumeratorT< const String*, IJsonValue* >* pMapEnum = pObject->GetMapEnumeratorN();
		while (pMapEnum->MoveNext() == E_SUCCESS)
		{
			const String* key = null;
			IJsonValue* value = null;
			pMapEnum->GetKey(key);

			if(*key == L"access_dt")
			{
				AppLog("TraverseFunction() access_dt = %S", key->GetPointer());

				pMapEnum->GetValue(value);

				JsonString* pUpd_date = static_cast< JsonString* >(value);
				upd_date = new (std::nothrow) String(*pUpd_date);
			}

			if(*key == L"tablet_flg")
			{
				AppLog("TraverseFunction() tablet_flg = %S", key->GetPointer());
				pMapEnum->GetValue(value);

				String* tabletFlg = null;
				JsonBool* ptabletFlg = static_cast< JsonBool* >(value);
				if (*ptabletFlg == true)
					tabletFlg = new (std::nothrow) String("1");
				else
					tabletFlg = new (std::nothrow) String("0");
			}

			if(*key == L"total_count")
			{
				AppLog("TraverseFunction() total_count = %S", key->GetPointer());
				pMapEnum->GetValue(value);

				JsonString* ptotalCount = static_cast< JsonString* >(value);
				totalCount = new (std::nothrow) String(*ptotalCount);
			}

			if(*key == L"offset")
			{
				AppLog("TraverseFunction() offset = %S", key->GetPointer());
				pMapEnum->GetValue(value);

				JsonNumber* presponseOffset = static_cast< JsonNumber* >(value);
				responseOffset = new (std::nothrow) String((presponseOffset->ToString()));
			}

			String* pStr = null;
			pMapEnum->GetValue(value);
			if (value->GetType() == JSON_TYPE_OBJECT)
			{
				pStr = new (std::nothrow) String("Value is an Object");
			}
			else if (value->GetType() == JSON_TYPE_ARRAY)
			{
				pStr = new (std::nothrow) String("Value is an Array");
			}

			if(*key == L"last_target_device_type")
			{
				AppLog("ParseDataDisplay() last_target_device_type = %S", key->GetPointer());
				pMapEnum->GetValue(value);

				JsonString* plastTargetDeviceType = static_cast< JsonString* >(value);
				String* pStrlastTargetDeviceType = new (std::nothrow) String(*plastTargetDeviceType);

				arTitleInfo[iIndex].mLastTargetDeviceType = pStrlastTargetDeviceType;
				AppLog("ParseDataDisplay() key = last_target_device_type -> iIndex = %d", iIndex);
			}
			if(*key == L"title_nm")
			{
				AppLog("ParseDataDisplay() title_nm = %S", key->GetPointer());
				pMapEnum->GetValue(value);

				JsonString* ptitle_nm = static_cast< JsonString* >(value);
				String* pStrTitle_nm = new (std::nothrow) String(*ptitle_nm);

				arTitleInfo[iIndex].mTitleName = pStrTitle_nm;
				AppLog("ParseDataDisplay() key = title_nm -> iIndex = %d", iIndex);
			}
			if(*key == L"author_kana")
			{
				AppLog("ParseDataDisplay() author_kana = %S", key->GetPointer());
				pMapEnum->GetValue(value);

				JsonString* pauthorNameKana = static_cast< JsonString* >(value);
				String* pStrauthorNameKana = new (std::nothrow) String(*pauthorNameKana);

				arTitleInfo[iIndex].mAuthorNameKana = pStrauthorNameKana;
				AppLog("ParseDataDisplay() key = author_kana -> iIndex = %d", iIndex);
			}
			if(*key == L"buy_check_flg")		// Recheck~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
			{
				AppLog("ParseDataDisplay() buy_check_flg = %S", key->GetPointer());
				pMapEnum->GetValue(value);

				String* pStrBuy_check_flg = null;
				JsonBool* pbuy_check_flg = static_cast< JsonBool* >(value);
				if (*pbuy_check_flg == true)
					pStrBuy_check_flg = new (std::nothrow) String("true");
				else
					pStrBuy_check_flg = new (std::nothrow) String("false");

				arTitleInfo[iIndex].mBuyCheck = pStrBuy_check_flg;

				AppLog("ParseDataDisplay() key = buy_check_flg -> iIndex = %d", iIndex);
			}
			if(*key == L"new_item_id")
			{
				AppLog("ParseDataDisplay() new_item_id = %S", key->GetPointer());
				pMapEnum->GetValue(value);

				JsonString* pnew_item_id = static_cast< JsonString* >(value);
				String* pStrNew_item_id = new (std::nothrow) String(*pnew_item_id);

				arTitleInfo[iIndex].mNewItemId = pStrNew_item_id;
				AppLog("ParseDataDisplay() key = new_item_id -> iIndex = %d", iIndex);
			}
			if(*key == L"author_nm")
			{
				AppLog("ParseDataDisplay() author_nm = %S", key->GetPointer());
				pMapEnum->GetValue(value);

				JsonString* pauthorName = static_cast< JsonString* >(value);
				String* pStrauthorName = new (std::nothrow) String(*pauthorName);

				arTitleInfo[iIndex].mAuthorName = pStrauthorName;
				AppLog("ParseDataDisplay() key = author_nm -> iIndex = %d", iIndex);
			}
			if(*key == L"book_type")
			{
				AppLog("ParseDataDisplay() book_type = %S", key->GetPointer());
				pMapEnum->GetValue(value);

				JsonString* pbook_type = static_cast< JsonString* >(value);
				String* pStrBook_Type = new (std::nothrow) String(*pbook_type);

				arTitleInfo[iIndex].mBookType = pStrBook_Type;
				AppLog("ParseDataDisplay() key = book_type -> iIndex = %d", iIndex);
			}
			if(*key == L"title_kana")
			{
				AppLog("ParseDataDisplay() title_kana = %S", key->GetPointer());
				pMapEnum->GetValue(value);

				JsonString* ptitle_kana = static_cast< JsonString* >(value);
				String* pStrTitle_kana = new (std::nothrow) String(*ptitle_kana);

				arTitleInfo[iIndex].mTitleKana = pStrTitle_kana;
				AppLog("ParseDataDisplay() key = title_kana -> iIndex = %d", iIndex);
			}
			if(*key == L"title_id")
			{
				AppLog("ParseDataDisplay() title_id = %S", key->GetPointer());
				pMapEnum->GetValue(value);

				JsonString* ptitle_id = static_cast< JsonString* >(value);
				String* pStrTitle_id = new (std::nothrow) String(*ptitle_id);

				arTitleInfo[iIndex].mTitleId = pStrTitle_id;
				AppLog("ParseDataDisplay() key = title_id -> iIndex = %d", iIndex);
			}
			if(*key == L"release_dt")
			{
				AppLog("ParseDataDisplay() release_dt = %S", key->GetPointer());
				pMapEnum->GetValue(value);

				JsonString* pDate = static_cast< JsonString* >(value);
				String* pStrDate = new (std::nothrow) String(*pDate);

				arTitleInfo[iIndex].mDate = pStrDate;
				AppLog("ParseDataDisplay() key = release_dt -> iIndex = %d", iIndex);
				iIndex++;
			}
			TraverseFunction(value);
		}
		delete pMapEnum;
	}
	break;

	case JSON_TYPE_ARRAY:
	{
		JsonArray* pJsonArray = static_cast< JsonArray* >(pValue);
		pJsonArray->GetCount();
		IEnumeratorT< IJsonValue* >* pEnum = pJsonArray->GetEnumeratorN();
		while (pEnum->MoveNext() == E_SUCCESS)
		{
			IJsonValue* pValue = null;
			pEnum->GetCurrent(pValue);

			TraverseFunction(pValue);
		}
		delete pEnum;
	}
	break;

	case JSON_TYPE_NULL:
	{
		String* pStr = null;
		pStr = new (std::nothrow) String("null");
	}
	break;

	default:
		break;
	}
}

void
MyHondanaMainForm::ParseAndDisplay(void)
{
	File file;
	String filePath = App::GetInstance()->GetAppRootPath() + L"data/jsonSample.json";
//	String filePath = App::GetInstance()->GetAppDataPath() + L"data/jsonSample.json";

	//Read File Content into buffer
	result r = file.Construct(filePath, L"r");
	TryReturnVoid(r == E_SUCCESS, "file construction failure with [%s]", GetErrorMessage(r));

	FileAttributes att;
	r = File::GetAttributes(filePath, att);
	TryReturnVoid(r == E_SUCCESS, "file GetAttributes failure with [%s]", GetErrorMessage(r));

	long long size = att.GetFileSize();
	TryReturnVoid(size > 0, "file does not contain valid data, size of file [%ld]", size);

	ByteBuffer buf;
	r = buf.Construct(size + 1);
	TryReturnVoid(r == E_SUCCESS, "bytebuffer construct failure with [%s]", GetErrorMessage(r));

	r = file.Read(buf);
	TryReturnVoid(r == E_SUCCESS, "file read failure with [%s]", GetErrorMessage(r));

	//Call Json Parser
	IJsonValue* pJson = JsonParser::ParseN(buf);
	TryCatch(pJson, , "ParseN failed with [%s]", GetErrorMessage(GetLastResult()));

	TraverseFunction(pJson);
	AppLog("After traverse");

	//clean up allocated jsonValues
	if (pJson->GetType() == JSON_TYPE_OBJECT)
	{
		JsonObject* pObject = static_cast< JsonObject* >(pJson);
		pObject->RemoveAll(true);
	}
	else if (pJson->GetType() == JSON_TYPE_ARRAY)
	{
		JsonArray* pArray = static_cast< JsonArray* >(pJson);
		pArray->RemoveAll(true);
	}
	delete pJson;
	return;

CATCH:
	return;
}

// Json Parser End ----------------------------------------------------------------------------------------------

Tizen::Graphics::Bitmap*
MyHondanaMainForm::LoadBitmap(const String& fullname)
{
	result r = E_SUCCESS;
	Bitmap* pBitmap = null;
	Image* pImage = new (std::nothrow) Image();

	String mFullPath = App::GetInstance()->GetAppDataPath();
	String mFilesPath = L"files/files/thumbnail/";
	mFullPath.Append(mFilesPath);
	mFullPath.Append(fullname);

	TryReturn((pImage != null), null, "Failed instantiate Image object");

	r = pImage->Construct();

	if (mFullPath.EndsWith(L"jpg"))
	{
		pBitmap = pImage->DecodeN(mFullPath, BITMAP_PIXEL_FORMAT_RGB565);
	}
	else if (mFullPath.EndsWith(L"bmp"))
	{
		pBitmap = pImage->DecodeN(mFullPath, BITMAP_PIXEL_FORMAT_RGB565);
	}
	else if (mFullPath.EndsWith(L"png"))
	{
		pBitmap = pImage->DecodeN(mFullPath, BITMAP_PIXEL_FORMAT_ARGB8888);
	}
	else if (mFullPath.EndsWith(L"gif"))
	{
		pBitmap = pImage->DecodeN(mFullPath, BITMAP_PIXEL_FORMAT_RGB565);
	}
	delete pImage;

	return pBitmap;
}

void
MyHondanaMainForm::OnUserEventReceivedN(RequestId requestId, IList *pArgs)
{
	File file;

	AppLog ("OnUserEventReceivedN");
	String *pMessage;
	AppLog("2");


	//	r = file.Construct(App::GetInstance()->GetAppRootPath() + L"data/jsonSample.json", "w+");
	//Read File Content into buffer
	result r = E_SUCCESS;
	r = file.Construct(App::GetInstance()->GetAppDataPath() + L"data/jsonSample.json", "w+");

//	TryReturnVoid(r == E_SUCCESS, "file construction failure with [%s]", GetErrorMessage(r));


	switch(requestId)
	{
		case 100:
//			pMessage = static_cast<String *>(pArgs->GetAt(0));
			AppLog("3");

//			__pEditArea->SetText(*pMessage);
//			int iMsgSize = pMessage->GetLength();
//			r = file.Write(pMessage, iMsgSize);

			Invalidate(true);
			AppLog("4");
//			ParseAndDisplay();
			break;
	}
}

void
MyHondanaMainForm::OnResponseReceived(const String &responseStr)
{
	AppLog("OnResponseReceived[%d] : %ls", responseStr.GetLength(), responseStr.GetPointer());

//	__pEditArea->SetText(responseStr);
//	Invalidate(true);
}

void
MyHondanaMainForm::StartConect(const String& pUri)
{
	HashMap* map = new HashMap();
	map->Construct();
	map->Add(new String(L"offset"),new String(L"0"));

	map->Add(new String(L"IMEI"),new String(L"351990050045845"));

	map->Add(new String(URI), new String(pUri));
//	map->Add(new String(URI), new String(L"http://stg.book.dmkt-sp.jp/top?seed=730&type=232&data=NmO%2Bv82nzmtF28QCnwvFsesrrt9nHV6ur%2Bdz9csu9qe4yrdaqyxpxH5Do%2Bh1RuQecwfcdk7h5fP2kAYWxqKmfRXkOyOBDx3AFCFO5eH003AWAFdcmKyGHFYjO%2Bk2vca%2Bq1NyF1iyUWQjzdOpHCBDkgZgoktPSHlFVM3KbPM3Dwyp7b1u3CvJnc22XgmQ0j7qB3NLtBpto64NUtNf8SUKfOCoS1iSujQWz36cAKdGnkaoOUEaAe%2B5pDX%2FLN%2BOr97nU%2F%2B%2FfZmqgVmG%2B%2Fo7i%2F2l%2FijkNpyopA94dn%2FFwsYMWBSr9nUk113q2yLNUNKho%2B7prk%2FC72wrfNKwnHguBo6nXSwW6m78UicDKU9tggJeALDZ7Blbdk17pCIgLmth%2BzcNmwsOY30mAk%2BFegzjBCP3qxUoIjeCmgO7LkPSFGrIfddQZEdOjZy5%2FvjRZ6Calnnx&docomoIdFlg=&utm_source=01app&utm_medium=1&utm_campaign=1"));

	String mUserAgent = L"Mozilla/5.0 (Linux; Tizen 2.2; SEC-SC-001) AppleWebKit/537.3 (KHTML, like Gecko) Version/2.2 Mobile Safari/537.3";

	__pHttpService->postRequest(map, App::GetInstance(), mUserAgent);
}
