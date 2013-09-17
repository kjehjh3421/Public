#ifndef _DELETECHECKPOPUPPANEL_H_
#define _DELETECHECKPOPUPPANEL_H_

#include <FBase.h>
#include <FUi.h>
#include <FMedia.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

using namespace Tizen::Ui::Controls;

class IDeleteCheckPopupPanelListener
{
public:
	virtual ~IDeleteCheckPopupPanelListener() {}

	virtual void OnDeleteCheckPopupPanelItemSelected(int selectIdx) = 0;
};

class DeleteCheckPopupPanel
	: public Tizen::Ui::Controls::Panel
	, public Tizen::Ui::IActionEventListener
{
public:
	DeleteCheckPopupPanel(void);
	DeleteCheckPopupPanel(IDeleteCheckPopupPanelListener * pListener);
	virtual ~DeleteCheckPopupPanel(void);

	bool Initialize(void);
	virtual void OnActionPerformed(const Tizen::Ui::Control& source, int actionId);

	result Construct(Tizen::Graphics::Rectangle rect);

private:
	static const int ID_FORMAT_NULL = -1;
	static const int ID_FORMAT_CHECK = 100;
	static const int ID_CANCEL_BUTTON = 101;
	static const int ID_TITLE_SELECT_BUTTON = 102;

	static const int DELETELIST_ITEM_COUNT = 4;

	IDeleteCheckPopupPanelListener* __pListener;

	Tizen::Ui::Controls::Label* __pLabelTop;
	Tizen::Ui::Controls::CheckButton* __pCheckButton;
	Tizen::Ui::Controls::Label* __pLabelBottom;
	Tizen::Ui::Controls::Button* __pCancelButton;
	Tizen::Ui::Controls::Button* __pTitleSelectButton;
//	Tizen::Ui::Controls::Panel* __pDeletePanel;
};

#endif // _DELETECHECKPOPUPPANEL_H_
