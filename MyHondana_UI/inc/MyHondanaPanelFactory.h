#ifndef _MYHONDANA_PANEL_FACTORY_H_
#define _MYHONDANA_PANEL_FACTORY_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class MyHondanaPanelFactory
	: public Tizen::Ui::Scenes::IPanelFactory
{
public:
	MyHondanaPanelFactory(void);
	virtual ~MyHondanaPanelFactory(void);

	virtual Tizen::Ui::Controls::Panel* CreatePanelN(const Tizen::Base::String& panelId, const Tizen::Ui::Scenes::SceneId& sceneId);
};

#endif // _MYHONDANA_PANEL_FACTORY_H_
