using BepinexModPluginSupportExample.PluginStuff;
using MyModuleList = System.Collections.Generic.List<BepinexModPluginSupportExample.PluginStuff.Module>;
using UnityEngine;
using BepInEx;

namespace PluginExample
{
    [BepInPlugin("PluginExample", "Livku", "1.0.0")]
    public class Class1 : BaseUnityPlugin
    {
        void Awake()
        {
            var myPlugin = new Plugin()
            {
                ModuleList = new MyModuleList()
                {
                    new Module { moduleType = ModuleType.button, onPressed = Application.Quit, ModName = "Quit Game"},
                    new Module { moduleType = ModuleType.button, onPressed = Application.Quit, ModName = "Quit Game 2"},
                    new Module { moduleType = ModuleType.button, onPressed = Application.Quit, ModName = "Quit Game 3"},
                    new Module { moduleType = ModuleType.button, onPressed = Application.Quit, ModName = "Quit Game 4"},
                    new Module { moduleType = ModuleType.button, onPressed = Application.Quit, ModName = "Quit Game 5"},
                    new Module { moduleType = ModuleType.button, onPressed = Application.Quit, ModName = "Quit Game 6"},
                    new Module { moduleType = ModuleType.toggle, onUpdate = Application.Quit, ModName = "Quit Game Toggle"},
                },
                PluginName = "Test",
            };

            
            BepinexModPluginSupportExample.Class1.PluginList.Add(myPlugin);


        }
    }
}
