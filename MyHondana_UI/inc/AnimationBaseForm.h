//
// Tizen C++ SDK
// Copyright (c) 2012 Samsung Electronics Co., Ltd.
//
// Licensed under the Flora License, Version 1.0 (the License);
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://floralicense.org/license/
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an AS IS BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

/**
 * @file	AnimationBaseForm.h
 * @brief	This is the header file for the AnimationBaseForm class.
 *
 * This header file contains the declarations of the AnimationBaseForm class.
 */

#ifndef _ANIMATION_BASE_FORM_H_
#define _ANIMATION_BASE_FORM_H_

#include <FApp.h>
#include <FBase.h>
#include <FGraphics.h>
#include <FUi.h>

#include "AnimationPropertyInfo.h"
//#include "SettingPopup.h"

enum AnimationDirection
{
	ANIMATION_FORWARD,
	ANIMATION_BACKWARD
};

enum AnimationPosition
{
	ANIMATION_POS_START,
	ANIMATION_POS_END
};

class AnimationBaseForm
	: public Tizen::Ui::Controls::Form
	, public Tizen::Ui::Controls::IFormBackEventListener
	, public Tizen::Ui::IActionEventListener
{
public:
	AnimationBaseForm(void);
	virtual ~AnimationBaseForm(void);
	result Initialize(void);

	virtual result Play(void);
	virtual result Stop(void);

	virtual void OnFormBackRequested(Tizen::Ui::Controls::Form& source);
	virtual void OnActionPerformed(const Tizen::Ui::Control& source, int actionId);

protected:
	AnimationDirection GetAnimationDirection(void);
	virtual bool IsAnimating(void);

private:
	virtual void InitializeFooter(void);

protected:
	AnimationPropertyInfo _animationPropertyInfo;
	AnimationPropertyInfo2 _animationPropertyInfo2;
//	SettingPopup* _pSettingPopup;

	static const int FOOTER_ITEM_INDEX_PLAY = 0;
	static const int FOOTER_ITEM_INDEX_STOP = 1;
	static const int FOOTER_ITEM_INDEX_SETTINGS = 2;

private:
	AnimationPosition __position;

	static const int ID_FOOTER_BUTTON_PLAY = 101;
	static const int ID_FOOTER_BUTTON_STOP = 102;
	static const int ID_FOOTER_BUTTON_SETTINGS = 103;
};

#endif // _ANIMATION_BASE_FORM_H_
