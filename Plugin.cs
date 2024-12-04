using BepInEx;
using System;
using UnityEngine;

namespace ByeByeBeachBall
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public static GameObject BeachBall;
    
        void Start()
        {
            BeachBall = GameObject.Find("Anchor/Ball");

            if (BeachBall != null)
            {
                BeachBall.SetActive(false);
            }
            else
            {
                Logger.LogError("BeachBall not found in the scene. Check the object path.");
            }
	    
            GorillaTagger.OnPlayerSpawned();
            HarmonyPatches.ApplyHarmonyPatches();
        }
    }
}
