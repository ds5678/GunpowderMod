using MelonLoader;
using Harmony;
using UnityEngine;

namespace GunpowderMod
{
    internal class GunpowderMod : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log($"[{InfoAttribute.Name}] Version {InfoAttribute.Version} loaded!");
        }
    }
}