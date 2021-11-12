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
