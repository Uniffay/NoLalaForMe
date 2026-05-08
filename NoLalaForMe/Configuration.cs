using Dalamud.Configuration;
using Dalamud.Plugin;
using System;
using static NoLalaForMe.Utils.Constant;

namespace NoLalaForMe
{
    [Serializable]
    internal class Configuration : IPluginConfiguration
    {
        public int Version { get; set; } = 0;
        public Race SelectedRace { get; set; } = Race.VIERA;
        public bool enabled { get; set; } = true;
        public bool stayOn { get; set; } = false;
        public bool nameHQ { get; set; } = true;

        // the below exist just to make saving less cumbersome
        [NonSerialized]
        private IDalamudPluginInterface? pluginInterface;

        public void Initialize(IDalamudPluginInterface pluginInterface)
        {
            this.pluginInterface = pluginInterface;
        }

        public void Save()
        {
            pluginInterface!.SavePluginConfig(this);
        }
    }
}
