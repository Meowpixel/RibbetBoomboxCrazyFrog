using BepInEx;
using UnityEngine;
using LCSoundTool;

namespace RibbetBoomboxCrazyFrog
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            AudioClip crazyFrogLoop;
            AudioClip crazyFrogFull;


            crazyFrogLoop = SoundTool.GetAudioClip("Meowpixel-CrazyFrogBoombox", "crazyFrogLoop.mp3");
            crazyFrogFull = SoundTool.GetAudioClip("Meowpixel-CrazyFrogBoombox", "crazyFrogFull.mp3");


            //using a for loop to do this breaks it for some reason
            SoundTool.ReplaceAudioClip("BoomboxMusic1", crazyFrogLoop);
            SoundTool.ReplaceAudioClip("BoomboxMusic2", crazyFrogLoop);
            SoundTool.ReplaceAudioClip("BoomboxMusic3", crazyFrogLoop);
            SoundTool.ReplaceAudioClip("BoomboxMusic4", crazyFrogLoop);
            SoundTool.ReplaceAudioClip("BoomboxMusic5Zedfox", crazyFrogFull);
        }
    }
}
