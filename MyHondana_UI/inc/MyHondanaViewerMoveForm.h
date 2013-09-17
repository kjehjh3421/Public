/*
 * MyHondanaViewerMoveForm.h
 *
 *  Created on: Jun 28, 2013
 *      Author: Minjun
 */

#ifndef MYHONDANAVIEWERMOVEFORM_H_
#define MYHONDANAVIEWERMOVEFORM_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

#include "ContentsListPanel.h"
#include "BookmarkListPanel.h"

extern const wchar_t* FORM_VIEWERMOVE;
extern const wchar_t* SCENE_VIEWERMOVE;

class MyHondanaViewerMoveForm
	: public Tizen::Ui::Controls::Form
	, public Tizen::Ui::IActionEventListener
	, public Tizen::Ui::Controls::IFormBackEventListener
	, public Tizen::Ui::Scenes::ISceneEventListener
	, public Tizen::Ui::IOrientationEventListener
{
public:
	MyHondanaViewerMoveForm();
	virtual ~MyHondanaViewerMoveForm();

	bool Initialize(void);
	void ConstructPanel(bool isReset);

	// Form
	virtual result OnInitializing(void);
	virtual result OnTerminating();

	// IActionEventListener
	virtual void OnActionPerformed(const Tizen::Ui::Control &source, int actionId);
	// IFormBackEventListener
	virtual void OnFormBackRequested(Tizen::Ui::Controls::Form& source);
	virtual void OnOrientationChanged(const Tizen::Ui::Control &source, Tizen::Ui::OrientationStatus orientationStatus);
	virtual void OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId,
										const Tizen::Ui::Scenes::SceneId& nextSceneId);
	virtual void OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId, const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs);


private:
	void SetHeader(void);

	ContentsListPanel							*__pContentsPanel;
	BookmarkListPanel							*__pBookmarkPanel;

	static const int							IDC_SEG_CONT		= 100;
	static const int							IDC_SEG_BOOK		= 101;
};

#endif /* MYHONDANAVIEWERMOVEFORM_H_ */
