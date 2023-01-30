using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OBSWebsocketDotNet;
using OBSWebsocketDotNet.Types;

namespace EynwaObsController.Functions
{
    public class ObsController
    {
        public int MuteTime = 10000;
        protected OBSWebsocket _obs;
        public ObsController()
        {
            _obs = new OBSWebsocket();
            _obs.Connect("ws://127.0.0.1:4444", "");
        }

        public async Task Mute()
        {
            _obs.SetMute("Mic/Aux", true);
            _obs.ResetSceneItem("Tagueule", "Event");
            await Task.Delay(MuteTime);
            _obs.SetMute("Mic/Aux", false);
        }

        public async Task Popopo()
        {
            _obs.ResetSceneItem("Popopo", "Event");
        }

        public async Task Later()
        {
            _obs.ResetSceneItem("Later", "Event");
        }

        public async Task Gg()
        {
            _obs.ResetSceneItem("GGVideo", "Event");
        }

        public async Task Rip()
        {
            //var scenes = _obs.GetSceneList().Scenes.Find(x => x.Name == "Event");
            //var scene = scenes.Items.Find(x => x.SourceName == "mp4").GroupChildren.Find(x => x.SourceName == "pluie");
            //scene.Render = true;
            _obs.ResetSceneItem("pluie", "Event");
            _obs.ResetSceneItem("rip", "Event");
            var scenes = _obs.GetSceneList().Scenes.Find(x => x.Name == "partage d'écran");
            _obs.SetSourceFilterVisibility("ONLY CAM", "gris", true);
            _obs.SetSourceFilterVisibility("JEUX", "gris", true);
            _obs.SetSourceFilterVisibility("CAM LAUNCHER", "gris", true);
            await Task.Delay(9000);
            _obs.SetSourceFilterVisibility("ONLY CAM", "gris", false);
            _obs.SetSourceFilterVisibility("JEUX", "gris", false);
            _obs.SetSourceFilterVisibility("CAM LAUNCHER", "gris", false);
        }
    }
}
