#ifndef _MYHONDANA_MAIN_FORM_H_
#define _MYHONDANA_MAIN_FORM_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>
#include <FWebJson.h>

#include "CoverFlowPanel.h"
#include "SortPopupPanel.h"
#include "DeletePopupPanel.h"
#include "HttpCommunicationService.h"
#include "AnimationBaseForm.h"

using namespace Tizen::Web::Json;
using namespace Tizen::Base;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Graphics;

class MyHondanaMainForm
//	: public Tizen::Ui::Controls::Form
//	: public Tizen::Ui::IActionEventListener
	: public Tizen::Ui::IOrientationEventListener
//	, public Tizen::Ui::Controls::IFormBackEventListener
	, public Tizen::Ui::Controls::IFormMenuEventListener
	, public Tizen::System::IScreenEventListener
	, public Tizen::Ui::Controls::IScrollEventListener
	, public Tizen::Ui::IProgressPopupEventListener
	// List View
	, public Tizen::Ui::Controls::IListViewItemEventListener
	, public Tizen::Ui::Controls::IListViewItemProvider
	// Grid View
	, public Tizen::Ui::Controls::IIconListViewItemProvider
	, public Tizen::Ui::Controls::IIconListViewItemEventListener
	// Sort Popup Listener
	, public ISortPopupPanelListener
	// Delete Popup Listener
	, public IDeletePopupPanelListener

	, public Tizen::Ui::IAnimationEventListener
	, public IHttpResponseEventListener
	, public Tizen::Base::Runtime::ITimerEventListener
	, public AnimationBaseForm
{
public:
// -----------------------------------------------
	class TitleInfo {
	public:
		String* mTitleId;
		String* mTitleKana;
		String* mTitleName;
		String* mBookType;
		String* mBuyCheck;
		String* mNewItemId;
		String* mDate;
		String* mLastTargetDeviceType;
		String* mAuthorName;
		String* mAuthorNameKana;
	}; /* TitleInfo */

	class ContentInfo {
	public:
		String* mTitleId;
		String* mContentId;
		String* mContentNo;
		String* mContentName;
		String* mContentType;
		String* mFileName;
		String* mContentFormat;
		String* mDownloadExpireDate;
		String* mPurchasedDate;
		String* mPurchaseTargetDeviceType;
		String* mDeletedFlag;
	}; /* ContentInfo */

	TitleInfo arTitleInfo[100];

	void ParseAndDisplay(void);
	void TraverseFunction(IJsonValue* pValue);
	int iIndex;

	String* upd_date;
	String* tabletFlg;
	String* totalCount;
	String* responseOffset;

	void StartConect(const String& pUri);
// -----------------------------------------------

	MyHondanaMainForm(void);
	virtual ~MyHondanaMainForm(void);
	bool Initialize(void);
	void GetBitmap(void);
	void OnButtonDraw(void);

	virtual result Play(void);
	virtual result OnInitializing(void);
	virtual result OnTerminating(void);

	virtual void OnActionPerformed(const Tizen::Ui::Control& source, int actionId);
	virtual void OnFormBackRequested(Tizen::Ui::Controls::Form& source);
	virtual void OnFormMenuRequested(Tizen::Ui::Controls::Form& source);
	virtual void OnOrientationChanged(const Tizen::Ui::Control &source, Tizen::Ui::OrientationStatus orientationStatus);
	virtual void OnDividerPositionChanged(Tizen::Ui::Controls::SplitPanel& source, float position);
	virtual void OnDividerDoublePressed(Tizen::Ui::Controls::SplitPanel& source);
	virtual void OnScreenOn(void);
	virtual void OnScreenOff(void);
	virtual void OnAnimationStopped(const Tizen::Ui::Control& source);

	void RemoveScrollEventListener(IScrollEventListener& listener);
	virtual void OnScrollEndReached(Tizen::Ui::Control& source, Tizen::Ui::Controls::ScrollEndEvent type);

	virtual void OnProgressPopupCanceled(void);

	//IListViewItemEventListener
	virtual void OnListViewContextItemStateChanged(Tizen::Ui::Controls::ListView &listView, int index, int elementId, Tizen::Ui::Controls::ListContextItemStatus state);
	virtual void OnListViewItemStateChanged(Tizen::Ui::Controls::ListView &listView, int index, int elementId, Tizen::Ui::Controls::ListItemStatus status);
	virtual void OnListViewItemSwept(Tizen::Ui::Controls::ListView &listView, int index, Tizen::Ui::Controls::SweepDirection direction);
	virtual void OnListViewItemLongPressed(Tizen::Ui::Controls::ListView &listView, int index, int elementId, bool& invokeListViewItemCallback);

	//IListViewItemProvider
	virtual Tizen::Ui::Controls::ListItemBase* CreateItem (int index, int itemWidth);
	virtual bool  DeleteItem (int index, Tizen::Ui::Controls::ListItemBase *pItem, int itemWidth);

	virtual int GetItemCount(void);

	// IIconListViewItemEventListener
	virtual void OnIconListViewItemStateChanged (Tizen::Ui::Controls::IconListView &view, int index, Tizen::Ui::Controls::IconListViewItemStatus status);
	virtual void OnIconListViewOverlayBitmapSelected (Tizen::Ui::Controls::IconListView &iconListView, int index, int overlayBitmapId);

	//IIconListViewItemProvider
	virtual Tizen::Ui::Controls::IconListViewItem* CreateItem(int index);
	virtual bool DeleteItem(int index, Tizen::Ui::Controls::IconListViewItem* pItem);

	// IHttpResponseEventListener
	virtual void OnResponseReceived(const Tizen::Base::String &responseStr);
	virtual void OnUserEventReceivedN(RequestId requestId, Tizen::Base::Collection::IList *pArgs);

	// ISortPopupPanelListener
	virtual void OnSortPanelItemSelected(int selectIdx);

	// IDeletePopupPanelListener
	virtual void OnDeletePanelItemSelected(int selectIdx);

	virtual void OnTimerExpired(Tizen::Base::Runtime::Timer& timer);

private:

	void SetHeader(void);
	void SetFooter(void);
	void SetSplitPanel(void);
	void SetListView(void);
	void SetThumbnailView(void);
	void SetButton(void);
	void SortMenu(void);
	void DeleteMenu(void);
	void UpdateMenu(void);
	void ContextOptionMenu(void);
	void SetBookList(void);
	Bitmap* LoadBitmap(const String& fullname);

private:
	SortPopupPanel* __pSortPanel;
	DeletePopupPanel* __pDeletePanel;

	Tizen::Ui::Controls::ProgressPopup* __pUpdateMenu;

	Tizen::Ui::Controls::ContextMenu* __pContextMenu_Thumbnail;
	Tizen::Ui::Controls::ContextMenu* __pContextMenu_List;
	Tizen::Ui::Controls::OptionMenu* __pOptionKey_Thumbnail;
	Tizen::Ui::Controls::OptionMenu* __pOptionKey_List;


	// Portrait
	CoverFlowPanel* __pCoverFlowOn_Thumbnail;
	CoverFlowPanel* __pCoverFlowOn_List;
	CoverFlowPanel* __pCoverFlowOff_Thumbnail;
	CoverFlowPanel* __pCoverFlowOff_List;

	ScrollPanel* __pBackgroundPanel_CoverFlowOn_List;
	ScrollPanel* __pBackgroundPanel_CoverFlowOff_List;
	ScrollPanel* __pBackgroundPanel_CoverFlowOn_Thumbnail;
	ScrollPanel* __pBackgroundPanel_CoverFlowOff_Thumbnail;
	ListView* __pListView_CoverFlowOn;
	ListView* __pListView_CoverFlowOff;
	IconListView* __pThumbnailView_CoverFlowOn;
	IconListView* __pThumbnailView_CoverFlowOff;
	Label* __pLabel_CoverFlowOn_Thumbnail;
	Label* __pLabel_CoverFlowOn_List;
	Label* __pLabel_CoverFlowOff_Thumbnail;
	Label* __pLabel_CoverFlowOff_List;
	Button* __pSortButton_CoverFlowOn_Thumbnail;
	Button* __pSortButton_CoverFlowOn_List;
	Button* __pSortButton_CoverFlowOff_Thumbnail;
	Button* __pSortButton_CoverFlowOff_List;
	Button* __pNewBookViewButton_CoverFlowOn_Thumbnail;
	Button* __pNewBookViewButton_CoverFlowOn_Thumbnail1;
	Button* __pNewBookViewButton_CoverFlowOn_List;
	Button* __pNewBookViewButton_CoverFlowOff_Thumbnail;
	Button* __pNewBookViewButton_CoverFlowOff_List;
	Button* __pCoverFlowOnButton_Thumbnail;
	Button* __pCoverFlowOnButton_List;
	Button* __pCoverFlowOffButton_Thumbnail;
	Button* __pCoverFlowOffButton_List;
	//**************************************BITMAP***************************************
	//**Thumbnail View / List View
	Bitmap* __pListNewBook;
	Bitmap* __pGridNewBook;
	Bitmap* __pListBottomText;
	Bitmap* __pGridBottomText;
	Bitmap* __pBookCover[20];

	//**Header
	Bitmap* __pHeader_background;
	Bitmap* __pButton_market[2];
	Bitmap* __pButton_contextmenu[2];

	//**Option Menu / Context Menu
	Bitmap* __pOptionmenu_thumbnail[2];
	Bitmap* __pOptionmenu_list[2];
	Bitmap* __pOptionmenu_update[2];
	Bitmap* __pOptionmenu_delete[2];
	Bitmap* __pOptionmenu_download[2];
	Bitmap* __pOptionmenu_setting[2];
	Bitmap* __pOptionmenu_help[2];

	//**Button Animation
	Bitmap* __pBitmapNewBookNormal[3];

	//**Divider Bar
	Bitmap* __pThumbnail_background_greyblack;
	Bitmap* __pThumbnail_background[2];
	Bitmap* __pDivider_background;
	Bitmap* __pDivider_sortbutton[2];
	Bitmap* __pDivider_newbookbutton[2];
	Bitmap* __pDivider_coverflow_on_button[2];
	Bitmap* __pDivider_coverflow_off_button[2];

	Bitmap* __pOverlay;

	//************************************************************************************
	HttpCommunicationService *__pHttpService;

	Tizen::Base::Runtime::Timer __timer;

	int __nNewBookButtonImageNum;
	bool chkNewBook;
	int iCntTimer = 25;

	const int LIST_VIEW_MAIN_MENU_COUNT = 21;

	static const int ID_FORMAT_NULL = -1;
	static const int ID_FORMAT_STRING = 500;
	static const int ID_FORMAT_STRING2 = ID_FORMAT_STRING + 1;
	static const int ID_FORMAT_STRING3 = ID_FORMAT_STRING + 2;
	static const int ID_FORMAT_BITMAP = ID_FORMAT_STRING + 3;
	static const int ID_FORMAT_BITMAP2 = ID_FORMAT_STRING + 4;
	static const int ID_FORMAT_BITMAP3 = ID_FORMAT_STRING + 5;
	static const int ID_FORMAT_BITMAP4 = ID_FORMAT_STRING + 6;
	static const int ID_FORMAT_BITMAP5 = ID_FORMAT_STRING + 7;

	static const int BUTTON_OFFSET_X = 30;
	static const int BUTTON_OFFSET_Y = 80;

	static const int LEFT_BUTTON_ADD_X = 30;
	static const int LEFT_BUTTON_ADD_Y = 20;
	static const int LEFT_BUTTON_ADD_WIDTH = 35;
	static const int LEFT_BUTTON_ADD_HEIGHT = 40;

	static const int CENTER_BUTTON_ADD_X = 20;
	static const int CENTER_BUTTON_ADD_Y = 20;
	static const int CENTER_BUTTON_ADD_WIDTH = 35;
	static const int CENTER_BUTTON_ADD_HEIGHT = 40;

	static const int RIGHT_BUTTON_ADD_X = 10;
	static const int RIGHT_BUTTON_ADD_Y = 20;
	static const int RIGHT_BUTTON_ADD_WIDTH = 35;
	static const int RIGHT_BUTTON_ADD_HEIGHT = 40;

	static const int BUTTON_WIDTH = 100;
	static const int BUTTON_WIDTH_X = 40;
	static const int BUTTON_HEIGHT = 170;

public:
	Animation* __pAnimation;
	int __transactionId;
	static const RequestId REQUEST_ID_SEND = 0;
	void SortMenuHide();
	void DeleteMenuHide();
	Tizen::Ui::Controls::Popup* __pSortMenu;
	Tizen::Ui::Controls::Popup* __pDeleteMenu;

};

#endif	//_MYHONDANA_MAIN_FORM_H_
