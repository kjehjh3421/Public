#ifndef _MYHONDANA_DELETE_FORM_H_
#define _MYHONDANA_DELETE_FORM_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

#include "DeleteCheckPopupPanel.h"

class MyHondanaDeleteForm
	: public Tizen::Ui::Controls::Form
	, public Tizen::Ui::IActionEventListener
	, public Tizen::Ui::IOrientationEventListener
	, public Tizen::Ui::Controls::IFormBackEventListener
	, public Tizen::Ui::Controls::IFormMenuEventListener
	, public Tizen::Ui::Scenes::ISceneEventListener
	// List View
	, public Tizen::Ui::Controls::IListViewItemEventListener
	, public Tizen::Ui::Controls::IListViewItemProvider
	// Delete Check Popup Listener
	, public IDeleteCheckPopupPanelListener

{
public:
	MyHondanaDeleteForm(void);
	virtual ~MyHondanaDeleteForm(void);
	bool Initialize(void);
	void GetBitmap(void);

	virtual result OnInitializing(void);
	virtual result OnTerminating(void);

	virtual void OnActionPerformed(const Tizen::Ui::Control& source, int actionId);
	virtual void OnFormBackRequested(Tizen::Ui::Controls::Form& source);
	virtual void OnFormMenuRequested(Tizen::Ui::Controls::Form& source);
	virtual void OnOrientationChanged(const Tizen::Ui::Control &source, Tizen::Ui::OrientationStatus orientationStatus);

	virtual void OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId, const Tizen::Ui::Scenes::SceneId& nextSceneId);
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

	// IDeleteCheckPopupPanelListener
	virtual void OnDeleteCheckPopupPanelItemSelected(int selectIdx);



private:
	void SetHeader(void);
	void SetFooter(void);
	void SetSplitPanel(void);
	void SetListView(void);
	void SetButton(void);
	void DeleteCheckPopup(void);

private:
	DeleteCheckPopupPanel* __pDeleteCheckPopupPanel;

	Tizen::Ui::Controls::ScrollPanel* __pDeleteBackgroundPanel;
	Tizen::Ui::Controls::Panel* __pDeleteBackgroundPanel_Bottom;
	Tizen::Ui::Controls::ScrollPanel* __pDeleteBackgroundPanel_Landscape;
	Tizen::Ui::Controls::Panel* __pDeleteBackgroundPanel_Bottom_Landscape;

	Tizen::Ui::Controls::ListView* __pListView;
	Tizen::Ui::Controls::Label* __pFileSizeLabel;
	Tizen::Ui::Controls::Button* __pCancelButton;
	Tizen::Ui::Controls::Button* __pDeleteButton;
	Tizen::Ui::Controls::ListView* __pListView_Landscape;
	Tizen::Ui::Controls::Label* __pFileSizeLabel_Landscape;
	Tizen::Ui::Controls::Button* __pCancelButton_Landscape;
	Tizen::Ui::Controls::Button* __pDeleteButton_Landscape;

	Tizen::Graphics::Bitmap* __pCover;
	Tizen::Graphics::Bitmap* __pBook;
	Tizen::Graphics::Bitmap* __pListNewBook;
	Tizen::Graphics::Bitmap* __pGridNewBook;
	Tizen::Graphics::Bitmap* __pListBottomText;
	Tizen::Graphics::Bitmap* __pGridBottomText;
	Tizen::Graphics::Bitmap* __pHeaderBackground;

	const int LIST_VIEW_MAIN_MENU_COUNT = 20;

	static const int ID_FORMAT_NULL = -1;
	static const int ID_FORMAT_STRING = 500;
	static const int ID_FORMAT_STRING2 = ID_FORMAT_STRING + 1;
	static const int ID_FORMAT_STRING3 = ID_FORMAT_STRING + 2;
	static const int ID_FORMAT_BITMAP = ID_FORMAT_STRING + 3;
	static const int ID_FORMAT_BITMAP2 = ID_FORMAT_STRING + 4;
	static const int ID_FORMAT_BITMAP3 = ID_FORMAT_STRING + 5;

public:
	static const RequestId REQUEST_ID_SEND = 0;
	void DeleteCheckPopupHide(void);
	Tizen::Ui::Controls::Popup* __pDeleteCheckPopup;
};

#endif	//_MYHONDANA_DELETE_FORM_H_
