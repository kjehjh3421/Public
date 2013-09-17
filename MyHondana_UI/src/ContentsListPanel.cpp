/*
 * ContentsListPanel.cpp
 *
 *  Created on: Jul 1, 2013
 *      Author: Minjun
 */

#include "ContentsListPanel.h"
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

ContentsListPanel::ContentsListPanel()
	: __pContents(null)
	, __itemCount(0)
{
	// TODO Auto-generated constructor stub

}

ContentsListPanel::~ContentsListPanel() {
	// TODO Auto-generated destructor stub
}

void
ContentsListPanel::Initialize(Rectangle rect)
{
	__panelRect = rect;
	Construct(__panelRect);
	//SetBackgroundColor(Color::GetColor(COLOR_ID_GREY));

	__itemCount = 7;			// example
}

void
ContentsListPanel::SetPanelRect(Rectangle rect)
{
	__panelRect = rect;

	RequestRedraw();
}

result
ContentsListPanel::OnInitializing()
{
	result r = E_SUCCESS;
//	SetOrientation(ORIENTATION_AUTOMATIC);
//	AddOrientationEventListener(*this);

	__pContents = new ListView();
	__pContents->Construct(__panelRect, true, SCROLL_STYLE_FADE_OUT);
	__pContents->SetItemProvider(*this);
	__pContents->AddListViewItemEventListener(*this);

	AddControl(__pContents);

	return r;
}

result
ContentsListPanel::OnTerminating()
{
	result r = E_SUCCESS;

	return r;
}

void
ContentsListPanel::OnListViewContextItemStateChanged(ListView &listView,
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
ContentsListPanel::OnListViewItemStateChanged(ListView &listView,
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
ContentsListPanel::OnListViewItemSwept(ListView &listView, int index, SweepDirection direction)
{

}

ListItemBase*
ContentsListPanel::CreateItem(int index, int itemWidth)
{
	String itemText(L"目次 ");
	itemText.Append(index + 1);

	SimpleItem *pItem = new (std::nothrow) SimpleItem;
	FloatDimension itemDim(itemWidth, 100.0f);
	pItem->Construct(CoordinateSystem::AlignToDevice(itemDim), LIST_ANNEX_STYLE_NORMAL);
	pItem->SetElement(itemText);

	return pItem;
}

bool
ContentsListPanel::DeleteItem(int index, ListItemBase* pItem, int itemWidth)
{
	delete pItem;
	pItem = null;
	return true;
}

int
ContentsListPanel::GetItemCount(void)
{
	return __itemCount;
}


void
ContentsListPanel::OnOrientationChanged(const Control &source, OrientationStatus orientationStatus)
{
	this->RequestRedraw(true);
}
