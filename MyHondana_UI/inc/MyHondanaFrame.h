#ifndef _MYHONDANA_FRAME_H_
#define _MYHONDANA_FRAME_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class MyHondanaFrame
	: public Tizen::Ui::Controls::Frame
{
public:
	MyHondanaFrame(void);
	virtual ~MyHondanaFrame(void);


	virtual result OnInitializing(void);
	virtual result OnTerminating(void);

	void CheckLogin(void);
};

#endif	//_MYHONDANA_FRAME_H_
