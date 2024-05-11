using Il2Cpp;
using Il2CppGameModes.LobbyMode;
using Il2CppGameModes.Shared.Models.Customization;
using UnityEngine;

namespace SNMagicalWand.WandUI
{
    internal class LobbyMode
    {
        private static LobbyPlayer selectedLobbyPlayer;
        public static void Render()
        {
            WandUIBase.Window("Lobby", new Rect(0, 300, 125, 150));

            if (WandUIBase.FirstButton("ForceStart", WandUIBase.NormalButtonSize))
            {
                ObjectPublicDoBoObBoUnique.Method_Public_Static_Void_Object1PublicObVoObUnique_EnumPublicSealedva5v1_0(Object2PublicObVoObObObObObObObOb4.Method_Public_Static_Object2PublicObVoObObObObObObObOb4_PDM_0());
            }
            if (WandUIBase.NextVerticalButton("ForceHost", WandUIBase.NormalButtonSize))
            {
                ObjectPublicAbstractSealedObInObSeBoObSiDoSiBoUnique.Method_Public_Static_Boolean_ObjectPublicObInBoStBoHaStObInHaUnique_PDM_1(
         ObjectPublicAbstractSealedObInObSeBoObSiDoSiBoUnique.prop_ObjectPublicObInBoStBoHaStObInHaUnique_0);
            }
            if (WandUIBase.NextVerticalButton("NullNickname", WandUIBase.NormalButtonSize))
            {
           
             //   Melon<Main>.Logger.Warning(ObjectPublicObStObLi1ObMaLi1BoUnique.prop_ObjectPublicObStObLi1ObMaLi1BoUnique_0.field_Public_ObjectPublicObInObBoPlObBoAc1StUnique_0.field_Public_ValueTypePublicSealedObBy_sVoStVoByVoUnique_0.Decrypt());
                ObjectPublicObStObLi1ObMaLi1BoUnique.prop_ObjectPublicObStObLi1ObMaLi1BoUnique_0.field_Public_ObjectPublicObInObBoPlObBoAc1StUnique_0.field_Public_ValueTypePublicSealedObBy_sVoStVoByVoUnique_2 = "".Encrypt();
                var r = Object2PublicObBoObObObObObUnique.Method_Public_Static_Object2PublicObBoObObObObObUnique_ObjectPublicObInObBoPlObBoAc1StUnique_ObjectPublicISerializableObLoObAcLoUnique_ObjectPublicISerializableObLoObAcLoUnique_ObjectPublicISerializableObLoObAcLoUnique_EnumPublicSealedvaWISPSUAU5vUnique_EnumPublicSealedvaNOCHHE4vUnique_Boolean_0(
                   ObjectPublicObStObLi1ObMaLi1BoUnique.prop_ObjectPublicObStObLi1ObMaLi1BoUnique_0.field_Public_ObjectPublicObInObBoPlObBoAc1StUnique_0, LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0,
                    LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_1, LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_2,
                    EnumPublicSealedvaWISPSUAU5vUnique.SPRING, EnumPublicSealedvaNOCHHE4vUnique.NONE, false);
                LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.prop_HoloNetObject_0.SendHoloMessage(r);
            }
            if (WandUIBase.NextVerticalButton("UnlockSkins", WandUIBase.NormalButtonSize))
            {
                foreach (var item in Resources.FindObjectsOfTypeAll<CustomizationItemInfo>())
                {

                    item.isDefaultValue = true;
                }
                foreach (var item in Resources.FindObjectsOfTypeAll<CustomizationEmotionsInfo>())
                {
                    item.isDefaultValue = true;
                    item.isContext = false;
                    item.allowedActorType = EnumPublicSealedvaEXNECUSPITAN8vNEUnique.ANY;
                    item.hasIcon = true;
                }
            }
            // lastbtn = GUILayout.Window(32, lastbtn, (GUI.WindowFunction)w, new GUIContent("Cheat by xcar"), GUISkin.current.window);
            WandUIBase.Window("Players", new Rect(850, 400, 650, 200));
            if (ObjectPublicAbstractSealedObInObSeBoObSiDoSiBoUnique.field_Public_Static_Boolean_2)
                for (int i = 0; i < LobbyController.prop_LobbyController_0.players.prop_List_1_LobbyPlayer_0.Count; i++)
                {
                    string s = "<color=yellow>" + LobbyController.prop_LobbyController_0.players.prop_List_1_LobbyPlayer_0[i].field_Public_LobbyCharacter_0.prop_LobbyCharacterUi_0.nameText.text + "</color>";
                    if (i == 0 ? WandUIBase.FirstButton(s, WandUIBase.ThickButtonSize) : WandUIBase.NextHorizontalButton(s, WandUIBase.ThickButtonSize))
                    {

                        selectedLobbyPlayer = LobbyController.prop_LobbyController_0.players.prop_List_1_LobbyPlayer_0[i];
                    }
                }


            WandUIBase.Space();


            if (WandUIBase.NextHorizontalButton("<color=red>SetHost</color>", WandUIBase.NormalButtonSize))
            {
                ObjectPublicAbstractSealedObInObSeBoObSiDoSiBoUnique.Method_Public_Static_Boolean_ObjectPublicObInBoStBoHaStObInHaUnique_PDM_1(
     selectedLobbyPlayer.prop_HoloNetObject_0.field_Private_ObjectPublicAbstractISerializableInObBoLiBoOb1BoObBoUnique_0.Cast<Object1PublicISerializableObBoObBoUnique>().prop_ObjectPublicObInBoStBoHaStObInHaUnique_0);
            }
            if (WandUIBase.NextHorizontalButton("<color=red>Destroy</color>", WandUIBase.NormalButtonSize))
            {
                selectedLobbyPlayer.prop_HoloNetObject_0.DestroyHolo();
            }
            //       if (WandUIBase.NextHorizontalButton("<color=red>Disconnect</color>", WandUIBase.NormalButtonSize))
            //       {
            //           ObjectPublicAbstractSealedObInObSeBoObSiDoSiBoUnique.Method_Public_Static_Boolean_ObjectPublicObInBoStBoHaStObInHaUnique_PDM_0(
            //selectedLobbyPlayer.prop_HoloNetObject_0.field_Private_ObjectPublicAbstractISerializableInObBoLiBoOb1BoObBoUnique_0.Cast<Object1PublicISerializableObBoObBoUnique>().prop_ObjectPublicObInBoStBoHaStObInHaUnique_0);
            //       }
            //if (WandUIBase.NextHorizontalButton("<color=red>NullNickname</color>", WandUIBase.NormalButtonSize))
            //{

            //    ObjectPublicObInObBoPlObBoAc1StUnique plrinfo = ObjectPublicObStObLi1ObMaLi1BoUnique.prop_ObjectPublicObStObLi1ObMaLi1BoUnique_0.Method_Public_ObjectPublicObInObBoPlObBoAc1StUnique_String_PDM_0(
            //        selectedLobbyPlayer.prop_ValueTypePublicSealedObBy_sVoStVoByVoUnique_2.Decrypt());
            //    if (plrinfo == null)
            //    {
            //        LoggerInstance.Error("PLayerInfo is null");
            //        return;
            //    }
            //    plrinfo.field_Public_ValueTypePublicSealedObBy_sVoStVoByVoUnique_2 = "".Encrypt();
            //    var r = Object2PublicObBoObObObObObUnique.Method_Public_Static_Object2PublicObBoObObObObObUnique_ObjectPublicObInObBoPlObBoAc1StUnique_ObjectPublicISerializableObLoObAcLoUnique_ObjectPublicISerializableObLoObAcLoUnique_ObjectPublicISerializableObLoObAcLoUnique_EnumPublicSealedvaWISPSUAU5vUnique_EnumPublicSealedvaNOCHHE4vUnique_Boolean_0(
            //   plrinfo, selectedLobbyPlayer.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0,
            //        selectedLobbyPlayer.field_Public_ObjectPublicISerializableObLoObAcLoUnique_1, selectedLobbyPlayer.field_Public_ObjectPublicISerializableObLoObAcLoUnique_2,
            //        EnumPublicSealedvaWISPSUAU5vUnique.SPRING, EnumPublicSealedvaNOCHHE4vUnique.NONE, false);
            //    selectedLobbyPlayer.prop_HoloNetObject_0.SendHoloMessage(r);

            //}
            WandUIBase.Space();
            if (WandUIBase.NextHorizontalButton("NotReady", WandUIBase.NormalButtonSize))
            {
                selectedLobbyPlayer.prop_HoloNetObject_0.SendHoloMessage(Object2PublicObVoObObObObObObObOb2.Method_Public_Static_Object2PublicObVoObObObObObObObOb2_EnumPublicSealedva9v0_0(EnumPublicSealedva9v0.EnumValue0));
            }
            if (WandUIBase.NextHorizontalButton("Ready", WandUIBase.NormalButtonSize))
            {
                selectedLobbyPlayer.prop_HoloNetObject_0.SendHoloMessage(Object2PublicObVoObObObObObObObOb2.Method_Public_Static_Object2PublicObVoObObObObObObObOb2_EnumPublicSealedva9v0_0(EnumPublicSealedva9v0.EnumValue1));
            }

            if (WandUIBase.NextHorizontalButton("Downloading", WandUIBase.NormalButtonSize))
            {
                selectedLobbyPlayer.prop_HoloNetObject_0.SendHoloMessage(Object2PublicObVoObObObObObObObOb2.Method_Public_Static_Object2PublicObVoObObObObObObObOb2_EnumPublicSealedva9v0_0(EnumPublicSealedva9v0.EnumValue7));
            }
        }
    }
}
