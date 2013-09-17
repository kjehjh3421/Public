
#include "DeletePopupPanel.h"
#include "MyHondanaMainForm.h"
#include "MyHondanaDeleteForm.h"
#include <FApp.h>
#include <FGraphics.h>
#include <FAppUiApp.h>
#include <FBase.h>
#include "SceneRegister.h"

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Base::Collection;
using namespace Tizen::Media;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Graphics;
using namespace Tizen::Ui::Scenes;

DeletePopupPanel::DeletePopupPanel(void)
{
}

DeletePopupPanel::DeletePopupPanel(IDeletePopupPanelListener * pListener)
{
	__pListener = pListener;
}

DeletePopupPanel::~DeletePopupPanel(void)
{
}

result
DeletePopupPanel::Construct(Tizen::Graphics::Rectangle rect)
{
	String str_title="しんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばるしんじゅくすわんかぶきちょうすかうとさばいばる";
	String str_author = "岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海 岩崎夏海";
	int title_length = str_title.GetLength();
	int author_length = str_author.GetLength();
	int line_height = 29;

	//**************************************************************PORTRAIT*****************************************************************

	int space_title_height_portrait = 0;
	int str_length_portrait = 28;
	if(title_length<=str_length_portrait)
		space_title_height_portrait = line_height;
	else if(title_length>str_length_portrait && title_length<=str_length_portrait*2)
		space_title_height_portrait = line_height*2;
	else if(title_length>str_length_portrait*2 && title_length<=str_length_portrait*3)
		space_title_height_portrait = line_height*3;
	else if(title_length>str_length_portrait*3 && title_length<=str_length_portrait*4)
		space_title_height_portrait = line_height*4;
	else if(title_length>str_length_portrait*4 && title_length<=str_length_portrait*5)
		space_title_height_portrait = line_height*5;
	else if(title_length>str_length_portrait*5 && title_length<=str_length_portrait*6)
		space_title_height_portrait = line_height*6;
	else if(title_length>str_length_portrait*6)
		space_title_height_portrait = line_height*7;

	Panel::Construct(rect);
	__pLabelTop = new (std::nothrow) Label();
	__pLabelTop->Construct(Rectangle(25, 0, 500, space_title_height_portrait), str_title);
	__pLabelTop->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pLabelTop->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
	__pLabelTop->SetTextConfig(35, LABEL_TEXT_STYLE_NORMAL);
	AddControl(*__pLabelTop);

	__pCheckButton = new (std::nothrow) CheckButton();
	__pCheckButton->Construct(Rectangle(65, 200, 100, 100), CHECK_BUTTON_STYLE_MARK, BACKGROUND_STYLE_NONE, false, L"", GROUP_STYLE_NONE);

	AddControl(*__pCheckButton);

	__pLabelBottom = new (std::nothrow) Label();
	__pLabelBottom->Construct(Rectangle(160, 205, 425, 100), L"マイ本棚からも削除");
	__pLabelBottom->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);
	__pLabelBottom->SetTextHorizontalAlignment(ALIGNMENT_LEFT);
	__pLabelBottom->SetTextConfig(35, LABEL_TEXT_STYLE_NORMAL);
	AddControl(*__pLabelBottom);

	__pCancelButton = new (std::nothrow) Button();
	__pCancelButton->Construct(Rectangle(0,325, 275, 100), L"キャンセル");
	__pCancelButton->SetActionId(ID_CANCEL_BUTTON);
	__pCancelButton->AddActionEventListener(*this);
	AddControl(*__pCancelButton);

	__pDeleteButton = new (std::nothrow) Button();
	__pDeleteButton->Construct(Rectangle(275, 325, 275, 100), L"タイトル選択へ");
	__pDeleteButton->SetActionId(ID_TITLE_SELECT_BUTTON);
	__pDeleteButton->AddActionEventListener(*this);
	AddControl(*__pDeleteButton);

	return E_SUCCESS;
}

void
DeletePopupPanel::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	switch (actionId)
	{
	case ID_CANCEL_BUTTON:
		{
			__pListener->OnDeletePanelItemSelected(-1);
		}
		break;
	case ID_TITLE_SELECT_BUTTON:
		{
			pSceneManager->GoForward(ForwardSceneTransition(SCENE_DELETE));
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

void
DeletePopupPanel::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	__pListener->OnDeletePanelItemSelected(-1);
}
