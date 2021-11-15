using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;

namespace TestingPlugin
{
    public class TestingPlugin : Plugin<Config>
    {
    	public override string Author { get; } = "Killla";
		public override string Name { get; } = "Template Plugin";
		public override string Prefix { get; } = "TP";
		public override Version RequiredExiledVersion { get; } = new Version(3, 0, 0);
        
        public override void OnEnabled()
        {
            EventHandlers.PlayerEventHandlers.OnEnabled();
            EventHandlers.ServerEventHandlers.OnEnabled();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            EventHandlers.PlayerEventHandlers.OnDisabled();
            EventHandlers.ServerEventHandlers.OnDisabled();
            base.OnDisabled();

        }
    }
}
