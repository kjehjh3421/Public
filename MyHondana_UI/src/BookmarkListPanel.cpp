/*
 * BookmarkListPanel.cpp
 *
 *  Created on: Jul 1, 2013
 *      Author: Minjun
 */

#include "BookmarkListPanel.h"
#include <new>
#include <FApp.h>
#include <FGraphics.h>
#include <FAppUiApp.h>
#include <FBase.h>
#include "SceneRegister.h"
#include "AppResourceId.h"
#include "FUiLayout.h"
#include "FUiRelativeLayout.h"
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

BookmarkListPanel::BookmarkListPanel()
	: __pBookmark(null)
	, __itemCount(0)
{
	// TODO Auto-generated constructor stub

}

BookmarkListPanel::~BookmarkListPanel() {
	// TODO Auto-generated destructor stub
}

void
BookmarkListPanel::Initialize(Rectangle rect)
{
	__panelRect = rect;

	Construct(__panelRect);
	//SetBackgroundColor(Color::GetColor(COLOR_ID_WHITE));

	__itemCount = 21;			// example
}

void
BookmarkListPanel::SetPanelRect(Rectangle rect)
{
	__panelRect = rect;

	RequestRedraw();
}

result
BookmarkListPanel::OnInitializing()
{
	result r = E_SUCCESS;
//	SetOrientation(ORIENTATION_AUTOMATIC);
//	AddOrientationEventListener(*this);

	__pBookmark = new ListView();
	__pBookmark->Construct(__panelRect, true, SCROLL_STYLE_FADE_OUT);
	__pBookmark->SetItemProvider(*this);
	__pBookmark->AddListViewItemEventListener(*this);

	AddControl(__pBookmark);

	return r;
}

result
BookmarkListPanel::OnTerminating()
{
	result r = E_SUCCESS;

	return r;
}

void
BookmarkListPanel::OnListViewContextItemStateChanged(ListView &listView,
		int index, int elementId, ListContextItemStatus state)
{
	switch (state)
	{
		case LIST_CONTEXT_ITEM_STATUS_SELECTED:
			AppLog("context selected event");
			break;
		case LIST_CONTEXT_ITEM_STATUS_HIGHLIGHTED:
			AppLog("context highlighted event");
			break;
		default:
			AppLog("context unknown event");
			break;
	}
}

void
BookmarkListPanel::OnListViewItemStateChanged(ListView &listView,
		int index, int elementId, ListItemStatus status)

{
	switch(status)
	{
		case LIST_ITEM_STATUS_SELECTED:
			AppLog("selected event");
			break;
		case LIST_ITEM_STATUS_HIGHLIGHTED:
			AppLog("highlighted event");
			break;
		case LIST_ITEM_STATUS_CHECKED:
			AppLog("checked event");
			break;
		case LIST_ITEM_STATUS_UNCHECKED:
			AppLog("unchecked event");
			break;
		case LIST_ITEM_STATUS_MORE:
			AppLog("more event");
			break;
		default:
			AppLog("unknown event");
			break;
	}
}

void
BookmarkListPanel::OnListViewItemSwept(ListView &listView, int index,
		Tizen::Ui::Controls::SweepDirection direction)
{

}

ListItemBase*
BookmarkListPanel::CreateItem(int index, int itemWidth)
{
	String itemText(L"しおり ");
	itemText.Append(index + 1);

	FloatDimension itemDim(itemWidth, 100.0f);
	SimpleItem *pItem = new (std::nothrow) SimpleItem;
	pItem->Construct(CoordinateSystem::AlignToDevice(itemDim), LIST_ANNEX_STYLE_NORMAL);
	pItem->SetElement(itemText);

	return pItem;
}

bool
BookmarkListPanel::DeleteItem(int index, ListItemBase* pItem, int itemWidth)
{
	delete pItem;
	pItem = null;
	return true;
}

int
BookmarkListPanel::GetItemCount(void)
{
	return __itemCount;
}


void
BookmarkListPanel::OnOrientationChanged(const Control &source, OrientationStatus orientationStatus)
{
	this->RequestRedraw(true);
}
