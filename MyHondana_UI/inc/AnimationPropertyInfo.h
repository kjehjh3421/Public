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
 * @file	AnimationPropertyInfo.h
 * @brief	This is the header file for the AnimationPropertyInfo class.
 *
 * This header file contains the declarations of the AnimationPropertyInfo class.
 */

#ifndef _ANIMATION_PROPERTY_INFO_H_
#define _ANIMATION_PROPERTY_INFO_H_

#include <FUi.h>
class AnimationPropertyInfo
{
public:
	AnimationPropertyInfo(void);
	~AnimationPropertyInfo(void);

	void SetDelay(int delay);
	int GetDelay(void) const;

	void SetDuration(int duration);
	int GetDuration(void) const;

	void SetOffset(int offset);
	int GetOffset(void) const;

	void SetScaleRatio(int scaleRatio);
	int GetScaleRatio(void) const;

	void SetRepeatCount(int repeatCount);
	int GetRepeatCount(void) const;

	void SetAutoReverseEnabled(bool autoReverse);
	bool IsAutoReverseEnabled(void) const;

	void SetHoldEndEnabled(bool holdEnd);
	bool IsHoldEndEnabled(void) const;

	void SetInterpolatorType(Tizen::Ui::Animations::AnimationInterpolatorType interpolatorType);
	Tizen::Ui::Animations::AnimationInterpolatorType GetInterpolatorType(void) const;

	void SetDefaultValue(void);
	void ApplyGlobalSettings(Tizen::Ui::Animations::AnimationBase& animation);

public:
	static const int DEFAULT_DELAY = 0;
	static const int DEFAULT_DURATION = 1000;
	static const int DEFAULT_OFFSET = 0;
	static const int DEFAULT_SCALE_RATIO = 1;
	static const int DEFAULT_REPEAT_COUNT = 4;
	static const bool DEFAULT_AUTO_REVERSE = false;
	static const bool DEFAULT_SET_HOLD_END = true;

private:
	int __delay;
	int __duration;
	int __offset;
	int __scaleRatio;
	int __repeatCount;
	bool __isAutoReverse;
	bool __isSetHoldEnd;
	Tizen::Ui::Animations::AnimationInterpolatorType __interpolatorType;
};

class AnimationPropertyInfo2
{
public:
	AnimationPropertyInfo2(void);
	~AnimationPropertyInfo2(void);

	void SetDelay(int delay);
	int GetDelay(void) const;

	void SetDuration(int duration);
	int GetDuration(void) const;

	void SetOffset(int offset);
	int GetOffset(void) const;

	void SetScaleRatio(int scaleRatio);
	int GetScaleRatio(void) const;

	void SetRepeatCount(int repeatCount);
	int GetRepeatCount(void) const;

	void SetAutoReverseEnabled(bool autoReverse);
	bool IsAutoReverseEnabled(void) const;

	void SetHoldEndEnabled(bool holdEnd);
	bool IsHoldEndEnabled(void) const;

	void SetInterpolatorType(Tizen::Ui::Animations::AnimationInterpolatorType interpolatorType);
	Tizen::Ui::Animations::AnimationInterpolatorType GetInterpolatorType(void) const;

	void SetDefaultValue(void);
	void ApplyGlobalSettings(Tizen::Ui::Animations::AnimationBase& animation);

public:
	static const int DEFAULT_DELAY2 = 2000;
	static const int DEFAULT_DURATION2 = 2000;
	static const int DEFAULT_OFFSET2 = 0;
	static const int DEFAULT_SCALE_RATIO2 = 1;
	static const int DEFAULT_REPEAT_COUNT2 = 1;
	static const bool DEFAULT_AUTO_REVERSE2 = false;
	static const bool DEFAULT_SET_HOLD_END2 = true;

private:
	int __delay2;
	int __duration2;
	int __offset2;
	int __scaleRatio2;
	int __repeatCount2;
	bool __isAutoReverse2;
	bool __isSetHoldEnd2;
	Tizen::Ui::Animations::AnimationInterpolatorType __interpolatorType2;
};

#endif // _ANIMATION_PROPERTY_INFO_H_

