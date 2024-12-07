using BepInEx;
using System;
using UnityEngine;

namespace ByeByeBeachBall
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        bool inRoom;

        void Start()
        {
            GorillaTagger.OnPlayerSpawned(Initialized);
        }

        void Initialized()
        {
            GameObject BechBall = GameObject.Find("Anchor/Ball");
            BechBall.SetActive(false);
        }
    }
}
