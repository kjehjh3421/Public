
#ifndef _MYHONDANAVIEWERFORM_H_
#define _MYHONDANAVIEWERFORM_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>
#include "AnimationBaseForm.h"

class MyHondanaViewerForm
//	: public Tizen::Ui::Controls::Form
//	, public Tizen::Ui::IActionEventListener
	: public Tizen::Ui::IOrientationEventListener
//	, public Tizen::Ui::Controls::IFormBackEventListener
	, public Tizen::Ui::Controls::IFormMenuEventListener
	, public Tizen::Ui::Scenes::ISceneEventListener
	, public Tizen::Ui::IAdjustmentEventListener
	, public Tizen::Ui::Controls::ISliderEventListener
	, public AnimationBaseForm
{

// Construction
public:
	MyHondanaViewerForm(void);
	virtual ~MyHondanaViewerForm(void);
	bool Initialize(void);
	virtual result OnInitializing(void);
	virtual result OnTerminating(void);
	virtual result Play(void);

	virtual void OnActionPerformed(const Tizen::Ui::Control& source, int actionId);
	virtual void OnFormBackRequested(Tizen::Ui::Controls::Form& source);
	virtual void OnFormMenuRequested(Tizen::Ui::Controls::Form& source);
	virtual void OnOrientationChanged(const Tizen::Ui::Control &source, Tizen::Ui::OrientationStatus orientationStatus);
	virtual void OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId, const Tizen::Ui::Scenes::SceneId& nextSceneId);
	virtual void OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId, const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs);
	virtual void OnSliderBarMoved(Tizen::Ui::Controls::Slider& source, int value);
	virtual void OnAdjustmentValueChanged(const Tizen::Ui::Control& source, int adjustment);
	virtual void OnUserEventReceivedN(RequestId requestId, Tizen::Base::Collection::IList *pArgs);

// Implementation
private:
	void SetHeader(void);
	void SetButton(void);
	void SetPanel(void);
	void ShowMessageBox(void);
	void ShowMessageBoxPopup(void);
	void SetButton2(void);
	void ToastPopup(void);

	Tizen::Ui::Controls::Panel* __pBackgroundPanel;
	Tizen::Ui::Controls::Button* __pButton1;
	Tizen::Ui::Controls::Button* __pButton2;
	Tizen::Ui::Controls::Button* __pButton3;
	Tizen::Ui::Controls::Button* __pButton4;
	Tizen::Ui::Controls::Label* __pLabel;
	Tizen::Ui::Controls::Label* __pLabel_LeftNum;
	Tizen::Ui::Controls::Label* __pLabel_CenterNum;
	Tizen::Ui::Controls::Label* __pLabel_RightNum;
	Tizen::Ui::Controls::Slider* __pSlider;
	Tizen::Ui::Controls::Button* __pBookMarkButton;

//	Tizen::Ui::Controls::Panel* __pBackgroundPanel_Landscape;
//	Tizen::Ui::Controls::Button* __pButton1_Landscape;
//	Tizen::Ui::Controls::Button* __pButton2_Landscape;
//	Tizen::Ui::Controls::Button* __pButton3_Landscape;
//	Tizen::Ui::Controls::Button* __pButton4_Landscape;
//	Tizen::Ui::Controls::Label* __pLabel_Landscape;
//	Tizen::Ui::Controls::Label* __pLabel_LeftNum_Landscape;
//	Tizen::Ui::Controls::Label* __pLabel_CenterNum_Landscape;
//	Tizen::Ui::Controls::Label* __pLabel_RightNum_Landscape;
//	Tizen::Ui::Controls::Slider* __pSlider_Landscape;
//	Tizen::Ui::Controls::Button* __pBookMarkButton_Landscape;

	Tizen::Ui::Controls::Popup* __pToast_Popup;
	Tizen::Ui::Controls::Label* __pLabel_Toast;

	Tizen::Ui::Controls::Label* __pLabel_MsgBox;
	Tizen::Ui::Controls::Label* __pLabel_Popup;
	bool __isVisible;

private:

	static const int ID_BUTTON1 = 100;
	static const int ID_BUTTON2 = 101;
	static const int ID_BUTTON3 = 102;
	static const int ID_BUTTON4 = 103;
	static const int ID_BUTTON5 = 104;
	static const int ID_PROGRESS = 105;

	static const int ID_FORMAT_NULL = -1;
	static const int ID_FORMAT_STRING = 500;
	static const int ID_FORMAT_STRING2 = ID_FORMAT_STRING + 1;
	static const int ID_FORMAT_STRING3 = ID_FORMAT_STRING + 2;
	static const int ID_FORMAT_BITMAP = ID_FORMAT_STRING + 3;
	static const int ID_FORMAT_BITMAP2 = ID_FORMAT_STRING + 4;
	static const int ID_FORMAT_BITMAP3 = ID_FORMAT_STRING + 5;

public:
	int __transactionId;
	int CurrentPage;
//	int MAX_PAGE = 1;
//	int MIN_PAGE = 155;
//	int page = __pSlider->GetValue();

};

#endif
