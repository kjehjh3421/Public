#include "CoverFlowPanel.h"
#include "MyHondanaDetailForm.h"
#include <FApp.h>
#include <FGraphics.h>
#include <FAppUiApp.h>
#include <FBase.h>
#include "SceneRegister.h"

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Base::Collection;
using namespace Tizen::Media;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Graphics;
using namespace Tizen::Ui::Scenes;
using namespace Tizen::Base::Runtime;

//const int size_X = 153;
//const int size_Y = 320;

//const int size_X = 144;
//const int size_Y = 285;
//const int size_X = 96;
//const int size_Y = 200;
const int size_X = 120;
const int size_Y = 260;

const wchar_t LIST_IMAGE_PATH1[] = L"default_cover.png";
const wchar_t LIST_IMAGE_PATH2[] = L"book16.png";
const wchar_t LIST_IMAGE_PATH3[] = L"goto_new_book.png";
const wchar_t LIST_IMAGE_PATH4[] = L"BitmapA.bmp";


CoverFlowPanel::CoverFlowPanel(void)
	: __pCoverFlowView(null)
	, __pCover(null)
	, __pBook(null)
	, __pgotonewBook(null)
	, __pBackgroud(null)
{

}
CoverFlowPanel::~CoverFlowPanel(void)
{
	delete __pCover;
	delete __pBook;
	delete __pgotonewBook;
	delete __pBackgroud;
}

result
CoverFlowPanel::Construct(Tizen::Graphics::Rectangle rect)
{

	Panel::Construct(rect);
	AppResource* pAppResource = Application::GetInstance()->GetAppResource();
	__pShadow = new(std::nothrow) Label();
	__pShadow->Construct(Rectangle(0,0, rect.width, 8), L"");
	__pShadow->SetBackgroundBitmap(*pAppResource->GetBitmapN(L"shadow_720x8.png"));
//	__pShadow->SetBackgroundColor(0xff11ff11);
	AddControl(*__pShadow);

	// Create a CustomList
	__pCoverFlowView = new (std::nothrow) IconListView();
	__pCoverFlowView->Construct(Rectangle(0, 8, rect.width, size_Y + 28), Dimension(size_X, size_Y), ICON_LIST_VIEW_STYLE_NORMAL, ICON_LIST_VIEW_SCROLL_DIRECTION_HORIZONTAL, ICON_LIST_SCROLL_STYLE_FADE_OUT);
	__pCoverFlowView->SetItemBorderStyle(ICON_LIST_VIEW_ITEM_BORDER_STYLE_NONE);
	__pCoverFlowView->SetItemProvider(*this);
	__pCoverFlowView->SetMargin(MARGIN_TYPE_LEFT, 20);
	__pCoverFlowView->SetMargin(MARGIN_TYPE_RIGHT, 20);
	__pCoverFlowView->SetItemSpacing(20, 0);
	__pCoverFlowView->SetItemTextSize(17);
	__pCoverFlowView->SetBackgroundColor(0xff212121);
	__pCoverFlowView->SetTextVerticalAlignment(ICON_LIST_VIEW_ITEM_TEXT_VERTICAL_ALIGNMENT_INSIDE_TOP);
	__pCoverFlowView->SetName(L"CoverFlowPanel");
	__pCoverFlowView->SetTouchAnimationEnabled(false);


	__pCoverFlowView->AddIconListViewItemEventListener(*this);
	AddControl(*__pCoverFlowView);
	GetBitmap();

	return E_SUCCESS;
}

void
CoverFlowPanel::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
	switch(actionId)
	{
		default:
			break;
	}
}

void
CoverFlowPanel::OnTimerExpired(Tizen::Base::Runtime::Timer &  timer)
{
}

IconListViewItem*
CoverFlowPanel::CreateItem(int index)
{
	AppResource* pAppResource = Application::GetInstance()->GetAppResource();

	String itemText(L"");
	IconListViewItem* pIconListview = new (std::nothrow) IconListViewItem();

		AppLogDebug("GetName() = CoverFlowPanel");

		struct {
			const Tizen::Graphics::Bitmap* bookbitmap;
			const Tizen::Base::String  		itemText;
		} COVERFLOW_ITEM[]= {
			 { pAppResource->GetBitmapN(L"book01.png"), L"立ち読みした本1" }
			,{ pAppResource->GetBitmapN(L"book02.png"), L"立ち読みした本2" }
			,{ pAppResource->GetBitmapN(L"book03.png"), L"立ち読みした本3" }
			,{ pAppResource->GetBitmapN(L"book04.png"), L"立ち読みした本4" }
			,{ pAppResource->GetBitmapN(L"book05.png"), L"立ち読みした本5" }
			,{ pAppResource->GetBitmapN(L"book06.png"), L"立ち読みした本6" }
			,{ pAppResource->GetBitmapN(L"book07.png"), L"立ち読みした本7" }
			,{ pAppResource->GetBitmapN(L"book08.png"), L"立ち読みした本8" }
			,{ pAppResource->GetBitmapN(L"book09.png"), L"立ち読みした本9" }
			,{ pAppResource->GetBitmapN(L"book10.png"), L"立ち読みした本10" }
			,{ pAppResource->GetBitmapN(L"book11.png"), L"立ち読みした本11" }
			,{ pAppResource->GetBitmapN(L"book12.png"), L"立ち読みした本12" }
			,{ pAppResource->GetBitmapN(L"book13.png"), L"立ち読みした本13" }
			,{ pAppResource->GetBitmapN(L"book14.png"), L"立ち読みした本14" }
			,{ pAppResource->GetBitmapN(L"book15.png"), L"立ち読みした本15" }
			,{ pAppResource->GetBitmapN(L"book16.png"), L"立ち読みした本16" }
			,{ pAppResource->GetBitmapN(L"book17.png"), L"立ち読みした本17" }
			,{ pAppResource->GetBitmapN(L"book18.png"), L"立ち読みした本18" }
			,{ pAppResource->GetBitmapN(L"book19.png"), L"立ち読みした本19" }
			,{ pAppResource->GetBitmapN(L"book20.png"), L"立ち読みした本20" }
			,{ pAppResource->GetBitmapN(L"book11.png"), L"立ち読みした本21" }
		};


		pIconListview->Construct(*COVERFLOW_ITEM[index].bookbitmap, &COVERFLOW_ITEM[index].itemText); //&itemText);
//		pIconListview->SetOverlayBitmap(ID_FORMAT_BITMAP2, __pgotonewBook, ALIGNMENT_CENTER, ALIGNMENT_BOTTOM);

		return pIconListview;
}




bool
CoverFlowPanel::DeleteItem(int index, IconListViewItem* pItem)
{
	delete pItem;
	pItem = null;
	return true;
}

int
CoverFlowPanel::GetItemCount(void)
{
	return COVERFLOW_ITEM_COUNT;
}

void
CoverFlowPanel::GetBitmap(void)
{
	AppResource* pAppResource = Application::GetInstance()->GetAppResource();
	__pCover = pAppResource->GetBitmapN(LIST_IMAGE_PATH1);
	__pBook = pAppResource->GetBitmapN(LIST_IMAGE_PATH2);
	__pgotonewBook = pAppResource->GetBitmapN(LIST_IMAGE_PATH3);
	__pBackgroud = pAppResource->GetBitmapN(LIST_IMAGE_PATH4);
}

void
CoverFlowPanel::OnIconListViewItemStateChanged(IconListView& view, int index, IconListViewItemStatus status)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	ArrayList* pList = new (std::nothrow) ArrayList();
	pList->Add(*(new (std::nothrow) Integer(index)));

	MyHondanaDetailForm* pDetailForm = new (std::nothrow) MyHondanaDetailForm;
	pDetailForm->Initialize();
	pDetailForm->AddControl(*pDetailForm);
	pDetailForm->SendUserEvent(CoverFlowPanel::REQUEST_ID_SEND, pList);

	pSceneManager->GoForward(ForwardSceneTransition(SCENE_DETAIL));
}

