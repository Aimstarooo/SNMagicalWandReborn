using HarmonyLib;
using Il2Cpp;
using Il2CppGameModes.LobbyMode;

namespace SNMagicalWand.Hooks
{
    [HarmonyPatch(typeof(LobbyPlayer), nameof(LobbyPlayer.Method_Private_Void_Object2PublicStObVoStObStObStObSt0_PDM_0))]
    internal class LocalEmoteExecuted
    {
        [HarmonyPostfix]
        public static void Postfix(ref LobbyPlayer __instance,[HarmonyArgument(0)] ref Object2PublicStObVoStObStObStObSt0  emote)
        {
            if (__instance.prop_HoloNetObject_0.IsLocal)
            {
                if (Main.UseEmoteOnAll)
                {
                    foreach (var item in LobbyController.prop_LobbyController_0.players.prop_List_1_LobbyPlayer_0)
                    {
                        if (item.prop_HoloNetObject_0.IsLocal) continue;
                        item.prop_HoloNetObject_0.SendHoloMessage(emote);
                    }
                }
            }
        }
    }
}
