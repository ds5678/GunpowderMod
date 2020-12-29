using Harmony;
using MelonLoader;
using UnhollowerBaseLib;
using UnityEngine;

namespace GunpowderMod
{
    internal static class Patches
    {

        [HarmonyPatch(typeof(GameManager), "Awake")]
        public class GameManager_Awake
        {
            [HarmonyPatch(typeof(Panel_Crafting), "ItemPassesFilter")]
            private static class RecipesInToolsRecipes
            {
                internal static void Postfix(Panel_Crafting __instance, BlueprintItem bpi)
                {
                    if (bpi?.m_CraftedResult?.name == "GEAR_GunpowderCan")
                    {
                        bpi.m_RequiredCraftingLocation = CraftingLocation.Workbench;
                    }
                }
            }
            private static GearItem GetGearItemPrefab(string name) => Resources.Load(name).Cast<GameObject>().GetComponent<GearItem>();

        }
    }
}