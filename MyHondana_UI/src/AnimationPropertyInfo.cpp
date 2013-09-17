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

#include "AnimationPropertyInfo.h"

using namespace Tizen::Ui::Animations;

AnimationPropertyInfo::AnimationPropertyInfo(void)
	: __delay(DEFAULT_DELAY)
	, __duration(DEFAULT_DURATION)
	, __offset(DEFAULT_OFFSET)
	, __scaleRatio(DEFAULT_SCALE_RATIO)
	, __repeatCount(DEFAULT_REPEAT_COUNT)
	, __isAutoReverse(DEFAULT_AUTO_REVERSE)
	, __isSetHoldEnd(DEFAULT_SET_HOLD_END)
	, __interpolatorType(ANIMATION_INTERPOLATOR_LINEAR)
{
}

AnimationPropertyInfo::~AnimationPropertyInfo(void)
{
}

void
AnimationPropertyInfo::SetDelay(int delay)
{
	__delay = delay;
}

int
AnimationPropertyInfo::GetDelay(void) const
{
	return __delay;
}

void
AnimationPropertyInfo::SetDuration(int duration)
{
	__duration = duration;
}

int
AnimationPropertyInfo::GetDuration(void) const
{
	return __duration;
}

void
AnimationPropertyInfo::SetOffset(int offset)
{
	__offset = offset;
}

int
AnimationPropertyInfo::GetOffset(void) const
{
	return __offset;
}

void
AnimationPropertyInfo::SetScaleRatio(int scaleRatio)
{
	__scaleRatio = scaleRatio;
}

int
AnimationPropertyInfo::GetScaleRatio(void) const
{
	return __scaleRatio;
}

void
AnimationPropertyInfo::SetRepeatCount(int repeatCount)
{
	__repeatCount = repeatCount;
}

int
AnimationPropertyInfo::GetRepeatCount(void) const
{
	return __repeatCount;
}

void
AnimationPropertyInfo::SetAutoReverseEnabled(bool autoReverse)
{
	__isAutoReverse = autoReverse;
}

bool
AnimationPropertyInfo::IsAutoReverseEnabled(void) const
{
	return __isAutoReverse;
}

void
AnimationPropertyInfo::SetHoldEndEnabled(bool holdEnd)
{
	__isSetHoldEnd = holdEnd;
}

bool
AnimationPropertyInfo::IsHoldEndEnabled(void) const
{
	return __isSetHoldEnd;
}

void
AnimationPropertyInfo::SetInterpolatorType(AnimationInterpolatorType interpolatorType)
{
	__interpolatorType = interpolatorType;
}

AnimationInterpolatorType
AnimationPropertyInfo::GetInterpolatorType(void) const
{
	return __interpolatorType;
}

void
AnimationPropertyInfo::SetDefaultValue(void)
{
	__delay = DEFAULT_DELAY;
	__duration = DEFAULT_DURATION;
	__offset = DEFAULT_OFFSET;
	__scaleRatio = DEFAULT_SCALE_RATIO;
	__repeatCount = DEFAULT_REPEAT_COUNT;
	__isAutoReverse = DEFAULT_AUTO_REVERSE;
	__isSetHoldEnd = DEFAULT_SET_HOLD_END;
	__interpolatorType = ANIMATION_INTERPOLATOR_LINEAR;
}

void
AnimationPropertyInfo::ApplyGlobalSettings(AnimationBase& animation)
{
	animation.SetInterpolatorType(__interpolatorType);
	if (__interpolatorType == ANIMATION_INTERPOLATOR_BEZIER)
	{
		animation.SetBezierControlPoints(0.5f, 0.5f, 0.5f, 0.5f);
	}

	animation.SetAutoReverseEnabled(__isAutoReverse);
	animation.SetHoldEndEnabled(__isSetHoldEnd);
	animation.SetDelay(__delay);
	animation.SetDuration(__duration);
	animation.SetOffset(__offset);
	animation.SetRepeatCount(__repeatCount);
	animation.SetScaleRatio(__scaleRatio);
}






AnimationPropertyInfo2::AnimationPropertyInfo2(void)
	: __delay2(DEFAULT_DELAY2)
	, __duration2(DEFAULT_DURATION2)
	, __offset2(DEFAULT_OFFSET2)
	, __scaleRatio2(DEFAULT_SCALE_RATIO2)
	, __repeatCount2(DEFAULT_REPEAT_COUNT2)
	, __isAutoReverse2(DEFAULT_AUTO_REVERSE2)
	, __isSetHoldEnd2(DEFAULT_SET_HOLD_END2)
	, __interpolatorType2(ANIMATION_INTERPOLATOR_LINEAR)
{
}

AnimationPropertyInfo2::~AnimationPropertyInfo2(void)
{
}

void
AnimationPropertyInfo2::SetDelay(int delay)
{
	__delay2 = delay;
}

int
AnimationPropertyInfo2::GetDelay(void) const
{
	return __delay2;
}

void
AnimationPropertyInfo2::SetDuration(int duration)
{
	__duration2 = duration;
}

int
AnimationPropertyInfo2::GetDuration(void) const
{
	return __duration2;
}

void
AnimationPropertyInfo2::SetOffset(int offset)
{
	__offset2 = offset;
}

int
AnimationPropertyInfo2::GetOffset(void) const
{
	return __offset2;
}

void
AnimationPropertyInfo2::SetScaleRatio(int scaleRatio)
{
	__scaleRatio2 = scaleRatio;
}

int
AnimationPropertyInfo2::GetScaleRatio(void) const
{
	return __scaleRatio2;
}

void
AnimationPropertyInfo2::SetRepeatCount(int repeatCount)
{
	__repeatCount2 = repeatCount;
}

int
AnimationPropertyInfo2::GetRepeatCount(void) const
{
	return __repeatCount2;
}

void
AnimationPropertyInfo2::SetAutoReverseEnabled(bool autoReverse)
{
	__isAutoReverse2 = autoReverse;
}

bool
AnimationPropertyInfo2::IsAutoReverseEnabled(void) const
{
	return __isAutoReverse2;
}

void
AnimationPropertyInfo2::SetHoldEndEnabled(bool holdEnd)
{
	__isSetHoldEnd2 = holdEnd;
}

bool
AnimationPropertyInfo2::IsHoldEndEnabled(void) const
{
	return __isSetHoldEnd2;
}

void
AnimationPropertyInfo2::SetInterpolatorType(AnimationInterpolatorType interpolatorType)
{
	__interpolatorType2 = interpolatorType;
}

AnimationInterpolatorType
AnimationPropertyInfo2::GetInterpolatorType(void) const
{
	return __interpolatorType2;
}

void
AnimationPropertyInfo2::SetDefaultValue(void)
{
	__delay2 = DEFAULT_DELAY2;
	__duration2 = DEFAULT_DURATION2;
	__offset2 = DEFAULT_OFFSET2;
	__scaleRatio2 = DEFAULT_SCALE_RATIO2;
	__repeatCount2 = DEFAULT_REPEAT_COUNT2;
	__isAutoReverse2 = DEFAULT_AUTO_REVERSE2;
	__isSetHoldEnd2 = DEFAULT_SET_HOLD_END2;
	__interpolatorType2 = ANIMATION_INTERPOLATOR_LINEAR;
}

void
AnimationPropertyInfo2::ApplyGlobalSettings(AnimationBase& animation)
{
	animation.SetInterpolatorType(__interpolatorType2);
	if (__interpolatorType2 == ANIMATION_INTERPOLATOR_BEZIER)
	{
		animation.SetBezierControlPoints(0.5f, 0.5f, 0.5f, 0.5f);
	}

	animation.SetAutoReverseEnabled(__isAutoReverse2);
	animation.SetHoldEndEnabled(__isSetHoldEnd2);
	animation.SetDelay(__delay2);
	animation.SetDuration(__duration2);
	animation.SetOffset(__offset2);
	animation.SetRepeatCount(__repeatCount2);
	animation.SetScaleRatio(__scaleRatio2);
}

