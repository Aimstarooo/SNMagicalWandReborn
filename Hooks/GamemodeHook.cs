using HarmonyLib;
using Il2Cpp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Yoga;

namespace SNMagicalWand.Hooks
{
    [HarmonyPatch(typeof(ObjectPublicDi2ObLiOb1AcBoAcObUnique), nameof(ObjectPublicDi2ObLiOb1AcBoAcObUnique.Method_Public_Void_EnumPublicSealedvaNOGALOMEPRGAMASHCRUnique_0))]
    class GamemodeHook
    {
        public static EnumPublicSealedvaNOGALOMEPRGAMASHCRUnique CurrentMode { get; private set; }
        [HarmonyPostfix]
        public static void Postfix([HarmonyArgument(0)] ref EnumPublicSealedvaNOGALOMEPRGAMASHCRUnique enu)
        {
            CurrentMode = enu;
        }
    }
}
