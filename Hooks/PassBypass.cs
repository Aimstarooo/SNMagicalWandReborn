using HarmonyLib;
using Il2CppGameModes.LobbyMode;
using Il2CppUi.Screens.CustomGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMagicalWand.Hooks
{
    [HarmonyPatch(typeof(CustomGameScreen), nameof(CustomGameScreen.Method_Private_Void_List_1_InterfacePublicAbstractTyBoVoTyBoObVoUnique_0))]

    class PassBypass
    {
        [HarmonyPrefix]
        public static bool Prefix(ref CustomGameScreen __instance)
        {
            LobbyController.prop_LobbyController_0.Method_Public_Void_ObjectPublicStObInObBoBoInObBoObUnique_0(__instance.field_Private_ObjectPublicStObInObBoBoInObBoObUnique_0);
            return false;
        }
    }
}
