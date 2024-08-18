using ModuleList = System.Collections.Generic.List<BepinexModPluginSupportExample.PluginStuff.Module>;

namespace BepinexModPluginSupportExample.PluginStuff
{
    public class Plugin
    {
        public ModuleList ModuleList { get; set; }

        public string PluginName { get; set; }
    }
}
