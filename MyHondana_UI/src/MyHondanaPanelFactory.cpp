#include "MyHondanaPanelFactory.h"

using namespace Tizen::Ui::Controls;
using namespace Tizen::Ui::Scenes;


MyHondanaPanelFactory::MyHondanaPanelFactory(void)
{
}

MyHondanaPanelFactory::~MyHondanaPanelFactory(void)
{
}

Tizen::Ui::Controls::Panel*
MyHondanaPanelFactory::CreatePanelN(const Tizen::Base::String& panelId, const Tizen::Ui::Scenes::SceneId& sceneId)
{

	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	Tizen::Ui::Controls::Panel* pNewPanel = null;

	// TODO:
	// Add your panel creation code here
	return pNewPanel;
}
