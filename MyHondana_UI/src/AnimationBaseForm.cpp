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

#include "AnimationBaseForm.h"

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Graphics;
using namespace Tizen::Ui::Animations;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Ui::Scenes;

AnimationBaseForm::AnimationBaseForm(void)
//	 _pSettingPopup(null)
	: __position(ANIMATION_POS_START)
{
}

AnimationBaseForm::~AnimationBaseForm(void)
{
//	if (_pSettingPopup)
//	{
//		delete _pSettingPopup;
//		_pSettingPopup = null;
//	}
}

result
AnimationBaseForm::Initialize(void)
{
	result r = E_SUCCESS;

	Form::Construct(FORM_STYLE_NORMAL | FORM_STYLE_INDICATOR | FORM_STYLE_HEADER | FORM_STYLE_FOOTER);
	SetFormBackEventListener(this);

	Footer* pFooter = GetFooter();
	pFooter->SetStyle(FOOTER_STYLE_BUTTON_TEXT);
	pFooter->SetBackButton();

	InitializeFooter();

//	_pSettingPopup = new (std::nothrow) SettingPopup();
//	_pSettingPopup->Construct(_animationPropertyInfo);
//	_pSettingPopup->SetShowState(false);
//	_pSettingPopup->Show();

	return r;
}


result
AnimationBaseForm::Play(void)
{
	result r = E_SUCCESS;

	return r;
}

result
AnimationBaseForm::Stop(void)
{
	result r = E_SUCCESS;

	return r;
}

AnimationDirection
AnimationBaseForm::GetAnimationDirection(void)
{
	if (__position == ANIMATION_POS_START)
	{
		//if (_animationPropertyInfo.IsHoldEndEnabled() == true && _animationPropertyInfo.IsAutoReverseEnabled() == true)
		if (_animationPropertyInfo.IsAutoReverseEnabled() == true)
		{
			__position = ANIMATION_POS_START;
			return ANIMATION_FORWARD;
		}

		if (_animationPropertyInfo.IsHoldEndEnabled() == true)
		{
			__position = ANIMATION_POS_END;
		}
		else
		{
			__position = ANIMATION_POS_START;
		}

		return ANIMATION_FORWARD;
	}
	else
	{
		//if (_animationPropertyInfo.IsHoldEndEnabled() == true && _animationPropertyInfo.IsAutoReverseEnabled() == true)
		if (_animationPropertyInfo.IsAutoReverseEnabled() == true)
		{
			__position = ANIMATION_POS_END;
			return ANIMATION_BACKWARD;
		}

		if (_animationPropertyInfo.IsHoldEndEnabled() == true)
		{
			__position = ANIMATION_POS_START;
		}
		else
		{
			__position = ANIMATION_POS_END;
		}

		return ANIMATION_BACKWARD;
	}
}

void
AnimationBaseForm::OnFormBackRequested(Form& source)
{
	SceneManager::GetInstance()->GoBackward(BackwardSceneTransition());
}

void
AnimationBaseForm::OnActionPerformed(const Control& source, int actionId)
{
	switch (actionId)
	{
	case ID_FOOTER_BUTTON_PLAY:
		if (IsAnimating() == false)
		{
			Play();
		}

		break;

	case ID_FOOTER_BUTTON_STOP:
		if (IsAnimating() == true)
		{
			Stop();
		}
		break;

	case ID_FOOTER_BUTTON_SETTINGS:
//		_pSettingPopup->SetShowState(true);
//		_pSettingPopup->Show();
		break;

	default:
		break;
	}
}

void
AnimationBaseForm::InitializeFooter(void)
{
	FooterItem playItem;
	playItem.Construct(ID_FOOTER_BUTTON_PLAY);
	playItem.SetText(L"Play");

	FooterItem stopItem;
	stopItem.Construct(ID_FOOTER_BUTTON_STOP);
	stopItem.SetText(L"Stop");

	FooterItem settingsItem;
	settingsItem.Construct(ID_FOOTER_BUTTON_SETTINGS);
	settingsItem.SetText(L"Settings");

	Footer* pFooter = GetFooter();
	pFooter->AddItem(playItem);
	pFooter->AddItem(stopItem);
	pFooter->AddItem(settingsItem);
	pFooter->AddActionEventListener(*this);
}

bool
AnimationBaseForm::IsAnimating(void)
{
	for (int i = 0; i < GetControlCount(); i++)
	{
		Control* pControl = GetControl(i);
		ControlAnimator* pAnimator = pControl->GetControlAnimator();
		if (pAnimator != null)
		{
			if (pAnimator->GetStatus() == ANIMATOR_STATUS_PLAYING)
			{
				return true;
			}
		}
	}

	return false;
}

