
#ifndef _MYHONDANADETAILFORM_H_
#define _MYHONDANADETAILFORM_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>
#include "DeletePopupPanel.h"

class MyHondanaDetailForm
	: public Tizen::Ui::Controls::Form
	, public Tizen::Ui::IActionEventListener
	, public Tizen::Ui::IOrientationEventListener
	, public Tizen::Ui::Controls::IFormBackEventListener
	, public Tizen::Ui::Controls::IFormMenuEventListener
	// List View
	, public Tizen::Ui::Controls::IListViewItemEventListener
	, public Tizen::Ui::Controls::IListViewItemProvider

	, public Tizen::Ui::Scenes::ISceneEventListener

	, public Tizen::Ui::IUiLinkEventListener
	, public Tizen::Ui::ITextBlockEventListener

{

// Construction
public:
	MyHondanaDetailForm(void);
	virtual ~MyHondanaDetailForm(void);
	bool Initialize(void);
	void GetBitmap(void);
	virtual result OnInitializing(void);
	virtual result OnTerminating(void);

	virtual void OnActionPerformed(const Tizen::Ui::Control& source, int actionId);
	virtual void OnFormBackRequested(Tizen::Ui::Controls::Form& source);
	virtual void OnFormMenuRequested(Tizen::Ui::Controls::Form& source);
	virtual void OnOrientationChanged(const Tizen::Ui::Control &source, Tizen::Ui::OrientationStatus orientationStatus);
	virtual void OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId,
										const Tizen::Ui::Scenes::SceneId& nextSceneId);
	virtual void OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId, const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs);

	//IListViewItemEventListener
	virtual void OnListViewContextItemStateChanged(Tizen::Ui::Controls::ListView &listView, int index, int elementId, Tizen::Ui::Controls::ListContextItemStatus state);
	virtual void OnListViewItemStateChanged(Tizen::Ui::Controls::ListView &listView, int index, int elementId, Tizen::Ui::Controls::ListItemStatus status);
	virtual void OnListViewItemSwept(Tizen::Ui::Controls::ListView &listView, int index, Tizen::Ui::Controls::SweepDirection direction);
	virtual void OnListViewItemLongPressed(Tizen::Ui::Controls::ListView &listView, int index, int elementId, bool& invokeListViewItemCallback);

	//IListViewItemProvider
	virtual Tizen::Ui::Controls::ListItemBase* CreateItem (int index, int itemWidth);
	virtual bool  DeleteItem (int index, Tizen::Ui::Controls::ListItemBase *pItem, int itemWidth);
	virtual int GetItemCount(void);

	virtual void OnUserEventReceivedN(RequestId requestId, Tizen::Base::Collection::IList *pArgs);

	virtual void OnLinkClicked(Tizen::Ui::Control &source, const Tizen::Base::String &text, Tizen::Base::Utility::LinkType linkType, const Tizen::Base::String &link);
	virtual void OnTextBlockSelected(Tizen::Ui::Control &source, int start, int end);
// Implementation
private:
	void SetHeader(void);
	void SetListView(void);
	void DeleteMenu(void);
	void OptionMenu(void);

private:

	DeletePopupPanel* __pDeletePanel;

	Tizen::Ui::Controls::Popup* __pDeleteMenu;

	Tizen::Ui::Controls::Panel*  __pDetailViewPanel;
	Tizen::Ui::Controls::ScrollPanel* __pDetailViewScrollPanel;
	Tizen::Ui::Controls::ContextMenu* __pOptionMenu;
	
//	Tizen::Ui::Controls::Label* __pDetailTitle;
	Tizen::Ui::Controls::TextBox* __pDetailTitle;
	Tizen::Ui::Controls::Button* __pDetailTitleURL;
	Tizen::Ui::Controls::Label* __pDetailAuthor;
	Tizen::Ui::Controls::ListView* __pListView;

//	Tizen::Ui::Controls::Label* __pDetailTitle_Landscape;
	Tizen::Ui::Controls::TextBox* __pDetailTitle_Landscape;
	Tizen::Ui::Controls::Button* __pDetailTitleURL_Landscape;
	Tizen::Ui::Controls::Label* __pDetailAuthor_Landscape;
	Tizen::Ui::Controls::ListView* __pListView_Landscape;

	Tizen::Base::Collection::ArrayList* __Indexlist;

	Tizen::Graphics::Bitmap* __pCover;
	Tizen::Graphics::Bitmap* __pBook;
	Tizen::Graphics::Bitmap* __pListNewBook;
	Tizen::Graphics::Bitmap* __pGridNewBook;
	Tizen::Graphics::Bitmap* __pListBottomText;
	Tizen::Graphics::Bitmap* __pGridBottomText;
	Tizen::Graphics::Bitmap* __pHeaderBackground;

	const int LIST_VIEW_MAIN_MENU_COUNT = 21;

	static const int ID_FORMAT_NULL = -1;
	static const int ID_FORMAT_STRING = 500;
	static const int ID_FORMAT_STRING2 = ID_FORMAT_STRING + 1;
	static const int ID_FORMAT_STRING3 = ID_FORMAT_STRING + 2;
	static const int ID_FORMAT_BITMAP = ID_FORMAT_STRING + 3;
	static const int ID_FORMAT_BITMAP2 = ID_FORMAT_STRING + 4;
	static const int ID_FORMAT_BITMAP3 = ID_FORMAT_STRING + 5;


};

#endif
