#ifndef _SORTPOPUPPANEL_H_
#define _SORTPOPUPPANEL_H_

#include <FBase.h>
#include <FUi.h>
#include <FMedia.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class ISortPopupPanelListener
{
public:
	virtual ~ISortPopupPanelListener() {}

	virtual void OnSortPanelItemSelected(int selectIdx) = 0;
};

class SortPopupPanel
	: public Tizen::Ui::Controls::Panel
	, public Tizen::Ui::IActionEventListener
	, public Tizen::Ui::Controls::IFormBackEventListener
{
public:
	SortPopupPanel(void);
	SortPopupPanel(ISortPopupPanelListener * pListener);
	virtual ~SortPopupPanel(void);

	result Construct(Tizen::Graphics::Rectangle rect);
	bool Initialize(void);
	virtual void OnActionPerformed(const Tizen::Ui::Control& source, int actionId);
	virtual void OnFormBackRequested(Tizen::Ui::Controls::Form& source);

public:


private:

	ISortPopupPanelListener* __pListener;

	Tizen::Ui::Controls::Panel* __pSortListPanel;

	Tizen::Ui::Controls::Button* __pCheckList_Date;
	Tizen::Ui::Controls::Button* __pCheckList_Title;
	Tizen::Ui::Controls::Button* __pCheckList_Author;
	Tizen::Ui::Controls::Button* __pCheckList_Save;

//	Tizen::Ui::Controls::CheckButton* __pCheckList_Date;
//	Tizen::Ui::Controls::CheckButton* __pCheckList_Title;
//	Tizen::Ui::Controls::CheckButton* __pCheckList_Author;
//	Tizen::Ui::Controls::CheckButton* __pCheckList_Save;

	static const int ID_SORT_DATE_CHECKED = 500;
	static const int ID_SORT_DATE_UNCHECKED = ID_SORT_DATE_CHECKED + 1;
	static const int ID_SORT_DATE_SELECTED = ID_SORT_DATE_CHECKED + 2;
	static const int ID_SORT_TITLE_CHECKED = ID_SORT_DATE_CHECKED + 3;
	static const int ID_SORT_TITLE_UNCHECKED = ID_SORT_DATE_CHECKED + 4;
	static const int ID_SORT_TITLE_SELECTED = ID_SORT_DATE_CHECKED + 5;
	static const int ID_SORT_AUTHOR_CHECKED = ID_SORT_DATE_CHECKED + 6;
	static const int ID_SORT_AUTHOR_UNCHECKED = ID_SORT_DATE_CHECKED + 7;
	static const int ID_SORT_AUTHOR_SELECTED = ID_SORT_DATE_CHECKED + 8;
	static const int ID_SORT_SAVE_CHECKED = ID_SORT_DATE_CHECKED + 9;
	static const int ID_SORT_SAVE_UNCHECKED = ID_SORT_DATE_CHECKED + 10;
	static const int ID_SORT_SAVE_SELECTED = ID_SORT_DATE_CHECKED + 11;


	static const int SORTLIST_ITEM_COUNT = 4;
};

#endif // _SORTPOPUPPANEL_H_
