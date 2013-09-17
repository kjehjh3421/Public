/*
 * MyHondanaViewerMoveForm.cpp
 *
 *  Created on: Jun 28, 2013
 *      Author: Minjun
 */

#include <new>
#include <FApp.h>
#include <FGraphics.h>
#include <FAppUiApp.h>
#include <FBase.h>
#include "MyHondanaViewerMoveForm.h"
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

MyHondanaViewerMoveForm::MyHondanaViewerMoveForm()
	: __pContentsPanel(null)
	, __pBookmarkPanel(null)
{
	// TODO Auto-generated constructor stub

}

MyHondanaViewerMoveForm::~MyHondanaViewerMoveForm() {
	// TODO Auto-generated destructor stub
}

bool
MyHondanaViewerMoveForm::Initialize(void)
{
	RelativeLayout layout;
	layout.Construct();
	Construct(layout, FORM_STYLE_NORMAL | FORM_STYLE_HEADER | FORM_STYLE_INDICATOR);

	return true;
}

void
MyHondanaViewerMoveForm::ConstructPanel(bool isReset)
{
	Rectangle clientRect = GetClientAreaBounds();
	Rectangle rect(0, 0, clientRect.width, clientRect.height);

	// New lists are set
	if (isReset)
	{
		if (__pContentsPanel != null)
		{
			Rectangle rect(0, 0, clientRect.width, clientRect.height-124);
			delete __pContentsPanel;
			__pContentsPanel = new ContentsListPanel();
			__pContentsPanel->Initialize(rect);
		}

		if (__pBookmarkPanel != null)
		{
			Rectangle rect(0, 0, clientRect.width, clientRect.height-224);
			delete __pBookmarkPanel;
			__pBookmarkPanel = new BookmarkListPanel();
			__pBookmarkPanel->Initialize(rect);
		}
	}
	// Old lists are set
	else
	{
		// Contents list panel
		if (__pContentsPanel == null)
		{
			__pContentsPanel = new ContentsListPanel();
			__pContentsPanel->Initialize(rect);
		}

		if (__pBookmarkPanel == null)
		{
			__pBookmarkPanel = new BookmarkListPanel();
			__pBookmarkPanel->Initialize(rect);
		}
	}

	AddControl(*__pContentsPanel);
	AddControl(*__pBookmarkPanel);

	__pContentsPanel->SetShowState(true);
	__pBookmarkPanel->SetShowState(false);
}

result
MyHondanaViewerMoveForm::OnInitializing(void)
{
	result r = E_SUCCESS;
	Control::OnInitializing();

	SetFormBackEventListener(this);
	SetOrientation(ORIENTATION_AUTOMATIC);
	AddOrientationEventListener(*this);

	SetHeader();
	ConstructPanel(false);

	return r;
}

void
MyHondanaViewerMoveForm::SetHeader(void)
{
	AppResource *pAppResource = App::GetInstance()->GetAppResource();

	// Create header
	Header * pHeader = GetHeader();
	if (pHeader != null) {
		pHeader->SetStyle(HEADER_STYLE_SEGMENTED_WITH_TITLE);
		pHeader->SetTitleText(L"移動移動移動移動移動移動移動移動移動移動移動移動移動移動移動移動移動移動移動移動移動移動移動移動移動移動移動");
		HeaderItem contentsItem;
		HeaderItem bookmarkItem;
		contentsItem.Construct(IDC_SEG_CONT);
		contentsItem.SetText(L"目次");
		pHeader->AddItem(contentsItem);
		bookmarkItem.Construct(IDC_SEG_BOOK);
		bookmarkItem.SetText(L"しおり");
		pHeader->AddItem(bookmarkItem);
		pHeader->SetBackgroundBitmap(pAppResource->GetBitmapN(L"header_background.png"));
	}
	pHeader->AddActionEventListener(*this);
}

result
MyHondanaViewerMoveForm::OnTerminating()
{
	result r = E_SUCCESS;

	return r;
}

void
MyHondanaViewerMoveForm::OnActionPerformed(const Control &source, int actionId)
{
	AppLog("OnActionPerformed");

	switch(actionId)
	{
		case IDC_SEG_CONT:
			AppLog("CONTENTS SEGMENTATION");
			__pContentsPanel->SetShowState(true);
			__pBookmarkPanel->SetShowState(false);
			break;
		case IDC_SEG_BOOK:
			AppLog("BOOKMARK SEGMENTATION");
			__pContentsPanel->SetShowState(false);
			__pBookmarkPanel->SetShowState(true);
			break;
	}
}

void
MyHondanaViewerMoveForm::OnFormBackRequested(Form& source)
{
	AppLog("OnFormBackRequested");
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	pSceneManager->GoBackward(BackwardSceneTransition());
}

void
MyHondanaViewerMoveForm::OnOrientationChanged(const Control &source, OrientationStatus orientationStatus)
{

	ConstructPanel(false);
	this->RequestRedraw(true);
}

void
MyHondanaViewerMoveForm::OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId, const Tizen::Ui::Scenes::SceneId& nextSceneId)
{
}

void
MyHondanaViewerMoveForm::OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId, const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs)
{
}
