
#include "DeleteCheckPopupPanel.h"
#include "MyHondanaDeleteForm.h"
#include <FApp.h>
#include <FGraphics.h>
#include <FAppUiApp.h>
#include <FApp.h>
#include <FGraphics.h>
#include <FAppUiApp.h>
#include <FBase.h>
#include <FSystem.h>
#include "SceneRegister.h"

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Base::Collection;
using namespace Tizen::Media;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Graphics;
using namespace Tizen::Ui::Scenes;

using namespace Tizen::System;
using namespace Tizen::Io;

DeleteCheckPopupPanel::DeleteCheckPopupPanel(void)
{
}

DeleteCheckPopupPanel::DeleteCheckPopupPanel(IDeleteCheckPopupPanelListener * pListener)
{
	__pListener = pListener;
}

DeleteCheckPopupPanel::~DeleteCheckPopupPanel(void)
{
}

result
DeleteCheckPopupPanel::Construct(Tizen::Graphics::Rectangle rect)
{
	result r = E_SUCCESS;
	Panel::Construct(rect);
	__pLabelTop = new (std::nothrow) Label();
	__pLabelTop->Construct(Rectangle(25, 0, 500, 200), L"選択した書籍を削除します。削除しますか？");
	__pLabelTop->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pLabelTop->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
	__pLabelTop->SetTextConfig(35, LABEL_TEXT_STYLE_NORMAL);
	AddControl(*__pLabelTop);

	__pCancelButton = new (std::nothrow) Button();
	__pCancelButton->Construct(Rectangle(0,180, 275, 100), L"キャンセル");
	__pCancelButton->SetActionId(ID_CANCEL_BUTTON);
	__pCancelButton->AddActionEventListener(*this);
	AddControl(*__pCancelButton);

	__pTitleSelectButton = new (std::nothrow) Button();
	__pTitleSelectButton->Construct(Rectangle(275, 180, 275, 100), L"削除");
	__pTitleSelectButton->SetActionId(ID_TITLE_SELECT_BUTTON);
	__pTitleSelectButton->AddActionEventListener(*this);
	AddControl(*__pTitleSelectButton);

	return r;
}

void
DeleteCheckPopupPanel::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	switch (actionId)
	{
	case ID_CANCEL_BUTTON:
		{
			__pListener->OnDeleteCheckPopupPanelItemSelected(-1);
		}
		break;
	case ID_TITLE_SELECT_BUTTON:
		{
		}
		break;
	case ID_FORMAT_CHECK:
		{
//			pSceneManager->GoForward(ForwardSceneTransition(SCENE_DELETE));
		}
		break;
	default:
		break;
	}
}
