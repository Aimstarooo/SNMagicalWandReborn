using HarmonyLib;
using Il2Cpp;
using MelonLoader;

namespace SNMagicalWand.Hooks
{
    [HarmonyPatch(typeof(LobbyPlayer), nameof(LobbyPlayer.Method_Public_Void_Object2PublicObVoObObObObObObObOb0_PDM_0))]
    class AntiKick
    {
        [HarmonyPrefix]
        public static bool Prefix(ref LobbyPlayer __instance)
        {
            if (!__instance.prop_HoloNetObject_0.IsLocal)
            {
                return true;
            }
           Melon<Main>.Logger.Warning("Kick attempt blocked!");
            return false;
        }
    }
}
