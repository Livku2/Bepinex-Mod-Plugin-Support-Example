using Action = System.Action;

namespace BepinexModPluginSupportExample.PluginStuff
{
    public enum ModuleType
    {
        button,
        toggle
    }

    public class Module
    {
        public Action onEnable { get; set; }
        public Action onDisable { get; set; }
        public Action onUpdate { get; set; }
        public Action onPressed { get; set; }

        public bool isToggled { get; set; }
        public string ModName { get; set; }
        public ModuleType moduleType { get; set; }
    }
}
