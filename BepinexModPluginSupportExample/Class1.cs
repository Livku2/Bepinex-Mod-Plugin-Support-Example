using BepInEx;
using BepinexModPluginSupportExample.PluginStuff;
using UnityEngine;
using PluginList = System.Collections.Generic.List<BepinexModPluginSupportExample.PluginStuff.Plugin>;

namespace BepinexModPluginSupportExample
{
    [BepInPlugin("BepinexModPluginSupportExample", "Livku", "1.0.0")]
    public class Class1 : BaseUnityPlugin
    {
        public static PluginList PluginList = new PluginList();

        void Update()
        {
            foreach (var plugin in PluginList)
            {
                foreach (var module in plugin.ModuleList)
                {
                    if(module.moduleType == ModuleType.toggle)
                    {
                        if (module.isToggled)
                        {
                            module.onUpdate();
                        }
                    }
                }
            }
        }

        void OnGUI()
        {
            int yVal = 20;
            int xVal = 20;

            foreach (var plugin in PluginList)
            {
                foreach(var module in plugin.ModuleList)
                {
                    switch (module.moduleType) {
                        case ModuleType.button:
                            if (GUI.Button(new Rect(xVal, yVal, 100, 30), module.ModName))
                            {
                                module.onPressed();
                            }
                            break;
                        case ModuleType.toggle:
                            module.isToggled = GUI.Toggle(new Rect(xVal, yVal, 100, 30), module.isToggled, module.ModName);
                            //you can do onEnable/Disable stuff in a custom toggle i guess
                            break;
                    }

                    var gotoNextLine = yVal >= 210;

                    if (gotoNextLine)
                    {
                        yVal = 20;
                        xVal += 120;
                    }
                    else yVal += 50;
                }
            }
        }
    }
}
