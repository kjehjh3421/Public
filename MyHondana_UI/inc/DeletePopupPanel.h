#ifndef _DELETEPOPUPPANEL_H_
#define _DELETEPOPUPPANEL_H_

#include <FBase.h>
#include <FUi.h>
#include <FMedia.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class IDeletePopupPanelListener
{
public:
	virtual ~IDeletePopupPanelListener() {}

	virtual void OnDeletePanelItemSelected(int selectIdx) = 0;
};

class DeletePopupPanel
	: public Tizen::Ui::Controls::Panel
	, public Tizen::Ui::IActionEventListener
	, public Tizen::Ui::Controls::IFormBackEventListener

{
public:
	DeletePopupPanel(void);
	DeletePopupPanel(IDeletePopupPanelListener * pListener);
	virtual ~DeletePopupPanel(void);

	bool Initialize(void);
	virtual void OnActionPerformed(const Tizen::Ui::Control& source, int actionId);
	virtual void OnFormBackRequested(Tizen::Ui::Controls::Form& source);

	result Construct(Tizen::Graphics::Rectangle rect);

private:
	static const int ID_FORMAT_NULL = -1;
	static const int ID_FORMAT_CHECK = 100;
	static const int ID_CANCEL_BUTTON = 101;
	static const int ID_TITLE_SELECT_BUTTON = 102;

	static const int DELETELIST_ITEM_COUNT = 4;

	IDeletePopupPanelListener* __pListener;

	Tizen::Ui::Controls::Label* __pLabelTop;
	Tizen::Ui::Controls::CheckButton* __pCheckButton;
	Tizen::Ui::Controls::Label* __pLabelBottom;
	Tizen::Ui::Controls::Button* __pCancelButton;
	Tizen::Ui::Controls::Button* __pDeleteButton;
//	Tizen::Ui::Controls::Panel* __pDeletePanel;
};

#endif // _DELETEPOPUPPANEL_H_
