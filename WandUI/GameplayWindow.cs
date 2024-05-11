using Il2Cpp;
using Il2CppGameModes.GameplayMode.Levels.Basement.Objectives;
using Il2CppGameModes.GameplayMode.Misc;
using Il2CppGameModes.GameplayMode.Players;
using UnityEngine;

namespace SNMagicalWand.WandUI
{
    internal class GameplayWindow
    {
        private static Player selectedPlayer;

        static void DrawPlayerESP()
        {
            var color = GUI.color;
     
                foreach (var item in ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1)
                {
                    if (item.prop_HoloNetObject_0.IsLocal || item.prop_Boolean_1) continue;
                   
                    Vector3 lol = Camera.main.WorldToScreenPoint(item.prop_Actor_0.transform.position);
                    if (lol.z > 0f)
                    {
                        GUI.color = Color.gray;
                        var style = new GUIStyle(GUISkin.current.box);
                        style.normal.background = Texture2D.whiteTexture;
                        GUI.Box(new Rect(lol.x, Screen.height - lol.y + 7f, 150, 50), "<color=magenta>" + item.field_Private_ObjectPublicObInObBoPlObBoAc1StUnique_0.field_Public_ValueTypePublicSealedObBy_sVoStVoByVoUnique_2.Decrypt() + "</color>",
                           style);
                        if (item.prop_Boolean_4)
                        {
                            GUI.color = Color.red;
                            GUI.Label(new Rect(lol.x + 55, Screen.height - lol.y + 20f, 100, 50), "NEIGHBOR");
                        }
                        else
                        {

                            GUI.color = Color.green;
                            GUI.Label(new Rect(lol.x + 55, Screen.height - lol.y + 20f, 100, 50), "KID");
                        }


                    }
                }
            GUI.color = color;
        }
        static void DrawOtherESP()
        {
            var color = GUI.color;
            var door = ObjectsCache.GetObject<BasementDoorInteractable>();
            Vector3 lol2 = Camera.main.WorldToScreenPoint(door.transform.position);
            if (lol2.z > 0f)
            {
                GUI.color = Color.magenta;
                GUI.Label(new Rect(lol2.x, Screen.height - lol2.y, 100, 50), "BASEMENT");
            }
            GUI.color = color;
        }
        static void DrawKeyESP()
        {
            var color = GUI.color;
            var keys = ObjectsCache.GetObjects<KeyInventoryItem>();
         
            foreach (var item in keys)
            {
               
                if (item.keyType == EnumPublicSealedvaBLREYECAQUCARO12CAUnique.BLUE || item.keyType == EnumPublicSealedvaBLREYECAQUCARO12CAUnique.RED || item.keyType == EnumPublicSealedvaBLREYECAQUCARO12CAUnique.YELLOW)
                {
                    Vector3 lol2 = Camera.main.WorldToScreenPoint(item.transform.position);
                    if (lol2.z > 0f)
                    {
                        GUI.color = item.keyType == EnumPublicSealedvaBLREYECAQUCARO12CAUnique.BLUE ? Color.cyan : item.keyType == EnumPublicSealedvaBLREYECAQUCARO12CAUnique.RED ? Color.red : Color.yellow;
                        GUI.Label(new Rect(lol2.x, Screen.height - lol2.y, 130, 50), item.name.Replace("(Clone)", "").Replace("Item_", ""));
                    }
                }
            }
           
            GUI.color = color;
        }
        public static void Render()
        {
            try
            {

                DrawPlayerESP();


                DrawOtherESP();
                DrawKeyESP();
            }
            catch (Exception)
            {

            }
            WandUIBase.Window("Idk", new Rect(0, 130, 180, 200));
      
            if (WandUIBase.FirstButton("TPTo", WandUIBase.NormalButtonSize))
            {
                ObjectPublicObLi1PlInPlInObLi1Unique.prop_Player_0.prop_Actor_0.transform.position = selectedPlayer.prop_Actor_0.transform.position;
            }
            if (WandUIBase.NextVerticalButton("Kill", WandUIBase.NormalButtonSize))
            {
                StaticMethods.Kill(selectedPlayer.prop_HoloNetObject_0);
            }
            if (WandUIBase.NextVerticalButton("KillAll", WandUIBase.NormalButtonSize))
            {
                foreach (var item in ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1)
                {
                    if (item.prop_HoloNetObject_0.IsLocal) continue;
                    StaticMethods.Kill(item.prop_HoloNetObject_0);
                }
            }
            WandUIBase.Window("EndMatch", new Rect(0, 350, 200, 160));
            if (WandUIBase.FirstButton("Kids", new Size(90, 30)))
            {
                StaticMethods.EndMatch(EnumPublicSealedvaALBATIQU5vUnique.BASEMENT_ENTERED);
            }
            if (WandUIBase.NextHorizontalButton("Neighbor", new Size(90, 30)))
            {
                StaticMethods.EndMatch(EnumPublicSealedvaALBATIQU5vUnique.ALL_CHILDREN_DEAD);
            }

            WandUIBase.Space();

            if (WandUIBase.NextHorizontalButton("Time", new Size(90, 30)))
            {
                StaticMethods.EndMatch(EnumPublicSealedvaALBATIQU5vUnique.TIME_IS_UP);
            }

            if (WandUIBase.NextHorizontalButton("?", new Size(90, 30)))
            {
                StaticMethods.EndMatch(EnumPublicSealedvaALBATIQU5vUnique.QUEST_COMPLETED);
            }
            WandUIBase.Window("Mic", new Rect(0, 630, 200, 300));
            if (WandUIBase.FirstButton("OpenBasement", WandUIBase.NormalButtonSize))
            {

                var key = GameObject.FindObjectsOfType<KeyInventoryItem>().First();
                foreach (var item in GameObject.FindObjectsOfType<BasementDoorLockInteractable>())
                {
                    item.prop_HoloNetObject_0.SendHoloMessage(Object2PublicObKeObPlUnique.Method_Public_Static_Object2PublicObKeObPlUnique_KeyInventoryItem_Player_0(key, ObjectPublicObLi1PlInPlInObLi1Unique.prop_Player_0));
                }
                GameObject.FindObjectOfType<BasementDoorInteractable>().prop_HoloNetObject_0.SendHoloMessage(Object2PublicTVo1.Method_Public_Static_T_0<Object3PublicVo152>());

            }
      
            if (WandUIBase.NextVerticalButton("CrashWindows", WandUIBase.NormalButtonSize))
            {
                foreach (var item in GameObject.FindObjectsOfType<Window>())
                {
                    item.prop_HoloNetObject_0.SendHoloMessage(Object2PublicVeObVeVoObVeObVeObVe1.Method_Public_Static_Object2PublicVeObVeVoObVeObVeObVe1_Vector3_Vector3_PDM_0(Vector3.zero, Vector3.zero));
                }
            }
          


            WandUIBase.Window("Buffs", new Rect(300, 10, 330, 550));


            if (WandUIBase.FirstButton("Blind", WandUIBase.NormalButtonSize))
            {
                StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.BLIND);
            }
            if (WandUIBase.NextHorizontalButton("Tomato", WandUIBase.NormalButtonSize))
            {
                StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.TOMATO);
            }
            if (WandUIBase.NextHorizontalButton("Catch", WandUIBase.NormalButtonSize))
            {
                StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.CATCH);
            }
            WandUIBase.Space();
            if (WandUIBase.NextHorizontalButton("Fear", WandUIBase.NormalButtonSize))
            {
                StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.CHASE_FEAR);
            }
            WandUIBase.Space();
            if (WandUIBase.NextHorizontalButton("CTRL_Gates", WandUIBase.NormalButtonSize))
            {
                StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.CONTROL_GATES_BUFF);
            }
            if (WandUIBase.NextHorizontalButton("CTRL_SNDoor", WandUIBase.NormalButtonSize))
            {
                StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.SECRET_DOOR_CONTROL);
            }
            WandUIBase.Space();
            if (WandUIBase.NextHorizontalButton("DisableAll", WandUIBase.NormalButtonSize))
            {
                StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.DISABLE_ALL);
            }
            if (WandUIBase.NextHorizontalButton("DisableStamina", WandUIBase.NormalButtonSize))
            {
                StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.DISABLE_STAMINA_DRAIN);
            }
            WandUIBase.Space();
            if (WandUIBase.NextHorizontalButton("DisableEmotions", WandUIBase.NormalButtonSize))
            {
                StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.DISABLE_EMOTIONS);
            }
            if (WandUIBase.NextHorizontalButton("DisableInventory", WandUIBase.NormalButtonSize))
            {
                StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.DISABLE_INVENTORY);
            }
            if (WandUIBase.NextHorizontalButton("DisableSkills", WandUIBase.NormalButtonSize))
            {
                StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.DISABLE_SKILLS);
            }
            WandUIBase.Space();
            if (WandUIBase.NextHorizontalButton("SPEED", WandUIBase.NormalButtonSize))
            {
                StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.SPEEDUP);
            }


            WandUIBase.Space();
            if (WandUIBase.NextHorizontalButton("Godmode", WandUIBase.NormalButtonSize))
            {
                StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.INVINCIBLE);
            }
            if (WandUIBase.NextHorizontalButton("UnGodmode", WandUIBase.NormalButtonSize))
            {
                StaticMethods.DeBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.INVINCIBLE);
            }
            WandUIBase.Window("Players", new Rect(650, 10, 650, 100));
            for (int i = 0; i < ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1.Count; i++)
            {
                Player plr = ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1[i];
                string str = $"{(plr.prop_Boolean_4 ? "<color=red>" : "<color=yellow>")}{plr.field_Private_ObjectPublicObInObBoPlObBoAc1StUnique_0.field_Public_ValueTypePublicSealedObBy_sVoStVoByVoUnique_2.Decrypt()}{"</color>"}";
                if (i == 0 ? WandUIBase.FirstButton(str, WandUIBase.ThickButtonSize) : WandUIBase.NextHorizontalButton(str, WandUIBase.ThickButtonSize))
                {
                    selectedPlayer = ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1[i];
                }
            }
        }
    }
}
