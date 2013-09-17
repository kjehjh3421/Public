/*
 * ContentsListPanel.h
 *
 *  Created on: Jul 1, 2013
 *      Author: Minjun
 */

#ifndef CONTENTSLISTPANEL_H_
#define CONTENTSLISTPANEL_H_

#include <FBase.h>
#include <FUi.h>
#include <FGraphics.h>

class ContentsListPanel
	: public Tizen::Ui::Controls::Panel
	, public Tizen::Ui::Controls::IListViewItemEventListener
	, public Tizen::Ui::Controls::IListViewItemProvider
	, public Tizen::Ui::IOrientationEventListener
{
public:
	ContentsListPanel();
	virtual ~ContentsListPanel();

	void Initialize(Tizen::Graphics::Rectangle rect);
	void SetPanelRect(Tizen::Graphics::Rectangle rect);

	virtual result OnInitializing();
	virtual result OnTerminating();

	// IListViewItemEventListener
	virtual void OnListViewContextItemStateChanged(Tizen::Ui::Controls::ListView &listView,
			int index, int elementId, Tizen::Ui::Controls::ListContextItemStatus state);
	virtual void OnListViewItemStateChanged(Tizen::Ui::Controls::ListView &listView,
			int index, int elementId, Tizen::Ui::Controls::ListItemStatus status);
	virtual void OnListViewItemSwept(Tizen::Ui::Controls::ListView &listView, int index,
			Tizen::Ui::Controls::SweepDirection direction);

	// IListViewItemProvider
	virtual Tizen::Ui::Controls::ListItemBase* CreateItem(int index, int itemWidth);
	virtual bool DeleteItem(int index, Tizen::Ui::Controls::ListItemBase* pItem, int itemWidth);
	virtual int GetItemCount(void);

	virtual void OnOrientationChanged(const Tizen::Ui::Control &source, Tizen::Ui::OrientationStatus orientationStatus);

private:
	Tizen::Ui::Controls::ListView				*__pContents;
	int											__itemCount;
	Tizen::Graphics::Rectangle					__panelRect;
};

#endif /* CONTENTSLISTPANEL_H_ */
