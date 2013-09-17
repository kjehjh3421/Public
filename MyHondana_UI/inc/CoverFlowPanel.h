#ifndef _COVERFLOWPANEL_H_
#define _COVERFLOWPANEL_H_

#include <FBase.h>
#include <FUi.h>
#include <FMedia.h>

class CoverFlowPanel
	: public Tizen::Ui::Controls::Panel
	, public Tizen::Ui::IActionEventListener
	, public Tizen::Base::Runtime::ITimerEventListener

	, public Tizen::Ui::Controls::IIconListViewItemProvider
	, public Tizen::Ui::Controls::IIconListViewItemEventListener
{
public:
	CoverFlowPanel(void);
	virtual ~CoverFlowPanel(void);

	result Construct(Tizen::Graphics::Rectangle rect);

	virtual void OnActionPerformed(const Tizen::Ui::Control& source, int actionId);
	virtual void OnTimerExpired(Tizen::Base::Runtime::Timer& timer);
	void GetBitmap(void);

	// IIconListViewItemEventListener
	virtual void OnIconListViewItemStateChanged (Tizen::Ui::Controls::IconListView &view, int index, Tizen::Ui::Controls::IconListViewItemStatus status);

	//IIconListViewItemProvider
	virtual Tizen::Ui::Controls::IconListViewItem* CreateItem(int index);
	virtual bool DeleteItem(int index, Tizen::Ui::Controls::IconListViewItem* pItem);

	virtual int GetItemCount(void);

public:
	static const RequestId REQUEST_ID_SEND = 0;

private:
	static const int ID_FORMAT_NULL = -1;
	static const int ID_FORMAT_STRING = 500;
	static const int ID_FORMAT_STRING2 = ID_FORMAT_STRING + 1;
	static const int ID_FORMAT_STRING3 = ID_FORMAT_STRING + 2;
	static const int ID_FORMAT_BITMAP = ID_FORMAT_STRING + 3;
	static const int ID_FORMAT_BITMAP2 = ID_FORMAT_STRING + 4;
	static const int ID_FORMAT_BITMAP3 = ID_FORMAT_STRING + 5;

	static const int COVERFLOW_ITEM_COUNT = 21;

	Tizen::Ui::Controls::IconListView* __pCoverFlowView;
	Tizen::Ui::Controls::Label* __pShadow;

	Tizen::Graphics::Bitmap* __pCover;
	Tizen::Graphics::Bitmap* __pBook;
	Tizen::Graphics::Bitmap* __pgotonewBook;
	Tizen::Graphics::Bitmap* __pBackgroud;

};

#endif // _COVERFLOWPANEL_H_
