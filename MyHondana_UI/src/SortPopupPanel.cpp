
#include "SortPopupPanel.h"
#include <FApp.h>
#include <FGraphics.h>
#include <FAppUiApp.h>
#include <FBase.h>
#include "SceneRegister.h"
#include "MyHondanaMainForm.h"

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Base::Collection;
using namespace Tizen::Media;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Graphics;
using namespace Tizen::Ui::Scenes;

SortPopupPanel::SortPopupPanel(void)
{
}

SortPopupPanel::SortPopupPanel(ISortPopupPanelListener * pListener)
{
	__pListener = pListener;
}

SortPopupPanel::~SortPopupPanel(void)
{
}

result
SortPopupPanel::Construct(Tizen::Graphics::Rectangle rect)
{
	Panel::Construct(rect);

	int sort_button_height = 100;
	int sort_button_width = 500;

	__pCheckList_Date = new (std::nothrow) Button();
	__pCheckList_Date->Construct(Rectangle(0,0,sort_button_width,sort_button_height), L"購入日順");
	__pCheckList_Date->SetActionId(ID_SORT_DATE_CHECKED);
	__pCheckList_Date->SetColor(BUTTON_STATUS_NORMAL, 0xff232323);
	__pCheckList_Date->SetTextColor(0xff00ff00);
	__pCheckList_Date->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pCheckList_Date->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);

	__pCheckList_Date->AddActionEventListener(*this);
	AddControl(*__pCheckList_Date);

	__pCheckList_Title = new (std::nothrow) Button();
	__pCheckList_Title->Construct(Rectangle(0,sort_button_height,sort_button_width,sort_button_height), L"作品名順");
	__pCheckList_Title->SetActionId(ID_SORT_TITLE_CHECKED);
	__pCheckList_Title->SetColor(BUTTON_STATUS_NORMAL, 0xff232323);
	__pCheckList_Title->SetTextColor(0xffffffff);
	__pCheckList_Title->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pCheckList_Title->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pCheckList_Title->AddActionEventListener(*this);
	AddControl(*__pCheckList_Title);

	__pCheckList_Author = new (std::nothrow) Button();
	__pCheckList_Author->Construct(Rectangle(0,sort_button_height*2,sort_button_width,sort_button_height), L"作家名順");
	__pCheckList_Author->SetActionId(ID_SORT_AUTHOR_CHECKED);
	__pCheckList_Author->SetColor(BUTTON_STATUS_NORMAL, 0xff232323);
	__pCheckList_Author->SetTextColor(0xffffffff);
	__pCheckList_Author->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pCheckList_Author->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pCheckList_Author->AddActionEventListener(*this);
	AddControl(*__pCheckList_Author);

	__pCheckList_Save = new (std::nothrow) Button();
	__pCheckList_Save->Construct(Rectangle(0,sort_button_height*3,sort_button_width,sort_button_height), L"保存済み");
	__pCheckList_Save->SetActionId(ID_SORT_SAVE_CHECKED);
	__pCheckList_Save->SetColor(BUTTON_STATUS_NORMAL, 0xff232323);
	__pCheckList_Save->SetTextColor(0xffffffff);
	__pCheckList_Save->SetTextHorizontalAlignment(ALIGNMENT_CENTER);
	__pCheckList_Save->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pCheckList_Save->AddActionEventListener(*this);
	AddControl(*__pCheckList_Save);

	Invalidate(true);

	return E_SUCCESS;
}

void
SortPopupPanel::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
	switch (actionId)
	{
	case ID_SORT_DATE_CHECKED:
	{
		__pCheckList_Date->SetTextColor(0xff00ff00);
		if(__pCheckList_Title->GetTextColor()==0xff00ff00)
		{
			__pCheckList_Title->SetTextColor(0xffffffff);
			__pCheckList_Title->RequestRedraw(true);
		}
		else if(__pCheckList_Author->GetTextColor()==0xff00ff00)
		{
			__pCheckList_Author->SetTextColor(0xffffffff);
			__pCheckList_Author->RequestRedraw(true);
		}
		else if(__pCheckList_Save->GetTextColor()==0xff00ff00)
		{
			__pCheckList_Save->SetTextColor(0xffffffff);
			__pCheckList_Save->RequestRedraw(true);
		}
		__pListener->OnSortPanelItemSelected(1);
//		__pCheckList_Date->SetSelected(true);
//		__pCheckList_Title->SetSelected(false);
//		__pCheckList_Author->SetSelected(false);
//		__pCheckList_Save->SetSelected(false);
	}
		break;
	case ID_SORT_TITLE_CHECKED:
	{
		__pCheckList_Title->SetTextColor(0xff00ff00);
		if(__pCheckList_Date->GetTextColor()==0xff00ff00)
		{
			__pCheckList_Date->SetTextColor(0xffffffff);
			__pCheckList_Date->RequestRedraw(true);
		}
		else if(__pCheckList_Author->GetTextColor()==0xff00ff00)
		{
			__pCheckList_Author->SetTextColor(0xffffffff);
			__pCheckList_Author->RequestRedraw(true);
		}
		else if(__pCheckList_Save->GetTextColor()==0xff00ff00)
		{
			__pCheckList_Save->SetTextColor(0xffffffff);
			__pCheckList_Save->RequestRedraw(true);
		}
		__pListener->OnSortPanelItemSelected(2);
//		__pCheckList_Date->SetTextColor(0xffffffff);
//		__pCheckList_Title->SetTextColor(0xffff1111);
//		__pCheckList_Author->SetTextColor(0xffffffff);
//		__pCheckList_Save->SetTextColor(0xffffffff);
//		__pCheckList_Date->SetSelected(false);
//		__pCheckList_Title->SetSelected(true);
//		__pCheckList_Author->SetSelected(false);
//		__pCheckList_Save->SetSelected(false);
	}
		break;
	case ID_SORT_AUTHOR_CHECKED:
	{
		__pCheckList_Author->SetTextColor(0xff00ff00);
		if(__pCheckList_Date->GetTextColor()==0xff00ff00)
		{
			__pCheckList_Date->SetTextColor(0xffffffff);
			__pCheckList_Date->RequestRedraw(true);
		}
		else if(__pCheckList_Title->GetTextColor()==0xff00ff00)
		{
			__pCheckList_Title->SetTextColor(0xffffffff);
			__pCheckList_Title->RequestRedraw(true);
		}

		else if(__pCheckList_Save->GetTextColor()==0xff00ff00)
		{
			__pCheckList_Save->SetTextColor(0xffffffff);
			__pCheckList_Save->RequestRedraw(true);
		}
		__pListener->OnSortPanelItemSelected(3);

//		__pCheckList_Date->SetTextColor(0xffffffff);
//		__pCheckList_Title->SetTextColor(0xffffffff);
//		__pCheckList_Author->SetTextColor(0xffff1111);
//		__pCheckList_Save->SetTextColor(0xffffffff);
//		__pCheckList_Date->SetSelected(false);
//		__pCheckList_Title->SetSelected(false);
//		__pCheckList_Author->SetSelected(true);
//		__pCheckList_Save->SetSelected(false);
	}
		break;
	case ID_SORT_SAVE_CHECKED:
	{
		//MyHondanaMainForm* __pSortMenuHide = new (std::nothrow) MyHondanaMainForm();
		__pCheckList_Save->SetTextColor(0xff00ff00);
		if(__pCheckList_Date->GetTextColor()==0xff00ff00)
		{
			__pCheckList_Date->SetTextColor(0xffffffff);
			__pCheckList_Date->RequestRedraw(true);
		}
		else if(__pCheckList_Title->GetTextColor()==0xff00ff00)
		{
			__pCheckList_Title->SetTextColor(0xffffffff);
			__pCheckList_Title->RequestRedraw(true);
		}

		else if(__pCheckList_Author->GetTextColor()==0xff00ff00)
		{
			__pCheckList_Author->SetTextColor(0xffffffff);
			__pCheckList_Author->RequestRedraw(true);
		}
		__pListener->OnSortPanelItemSelected(4);
	}
		break;

//	case ID_SORT_DATE_UNCHECKED:
//	{
//		__pCheckList_Date->SetTextColor(0xffff1111);
//		__pCheckList_Title->SetTextColor(0xffffffff);
//		__pCheckList_Author->SetTextColor(0xffffffff);
//		__pCheckList_Save->SetTextColor(0xffffffff);
//		__pCheckList_Date->SetSelected(true);
//		__pCheckList_Title->SetSelected(false);
//		__pCheckList_Author->SetSelected(false);
//		__pCheckList_Save->SetSelected(false);
//	}
//		break;
//	case ID_SORT_TITLE_UNCHECKED:
//	{
//		__pCheckList_Date->SetTextColor(0xffffffff);
//		__pCheckList_Title->SetTextColor(0xffff1111);
//		__pCheckList_Author->SetTextColor(0xffffffff);
//		__pCheckList_Save->SetTextColor(0xffffffff);
//		__pCheckList_Date->SetSelected(false);
//		__pCheckList_Title->SetSelected(true);
//		__pCheckList_Author->SetSelected(false);
//		__pCheckList_Save->SetSelected(false);
//	}
//		break;
//	case ID_SORT_AUTHOR_UNCHECKED:
//	{
//		__pCheckList_Date->SetTextColor(0xffffffff);
//		__pCheckList_Title->SetTextColor(0xffffffff);
//		__pCheckList_Author->SetTextColor(0xffff1111);
//		__pCheckList_Save->SetTextColor(0xffffffff);
//		__pCheckList_Date->SetSelected(false);
//		__pCheckList_Title->SetSelected(false);
//		__pCheckList_Author->SetSelected(true);
//		__pCheckList_Save->SetSelected(false);
//	}
	default:
		break;
	}
}

void
SortPopupPanel::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	__pListener->OnSortPanelItemSelected(-1);
}
