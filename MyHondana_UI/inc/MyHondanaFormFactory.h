#ifndef _MYHONDANA_FORM_FACTORY_H_
#define _MYHONDANA_FORM_FACTORY_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

extern const wchar_t* FORM_MAIN;
extern const wchar_t* FORM_DETAIL;
extern const wchar_t* FORM_MARKET;
extern const wchar_t* FORM_DELETE;
extern const wchar_t* FORM_SETTING;
extern const wchar_t* FORM_LOGIN;
extern const wchar_t* FORM_VIEWER;
extern const wchar_t* FORM_VIEWERMOVE;
extern const wchar_t* FORM_HELP;

class MyHondanaFormFactory
	: public Tizen::Ui::Scenes::IFormFactory
{
public:
	MyHondanaFormFactory(void);
	virtual ~MyHondanaFormFactory(void);

	virtual Tizen::Ui::Controls::Form* CreateFormN(const Tizen::Base::String& formId, const Tizen::Ui::Scenes::SceneId& sceneId);
};

#endif // _MYHONDANA_FORM_FACTORY_H_
