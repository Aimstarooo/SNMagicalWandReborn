using Il2Cpp;
using Il2CppAssets.Scripts.AppControllers.Config;
using Il2CppGameModes.GameplayMode.Actors.Implementations.Neighbours.Configuration;
using Il2CppGameModes.GameplayMode.ActorSkills.NeighborSkills.Configuration;
using Il2CppHoloNetwork.NetworkObjects;
using Il2CppUi;
using MelonLoader;
using SNMagicalWand.Hooks;
using SNMagicalWand.WandUI;
using UnityEngine;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime;
using MelonLoader.NativeUtils;
using static MelonBypass;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppInterop.Runtime.Runtime;
[assembly: MelonInfo(typeof(SNMagicalWand.Main), "SNMagicalWandReborn", "2.1", "xcar")]
namespace SNMagicalWand
{


    public  class Main : MelonMod
    {
   

        public override void OnEarlyInitializeMelon()
        {

          
            MelonBypass.ApplyBypass();
          
        }
     
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            ObjectsCache.CleanUp();
        }



        private bool Enabled=true;
        public static bool UseEmoteOnAll=true;
   
    
        
        

        public override void OnGUI()
        {
            if (Camera.main == null) return;
            GUI.color = Color.black;
            if (Enabled)
            {
                InfoWindow.Render();
                if (GamemodeHook.CurrentMode == EnumPublicSealedvaNOGALOMEPRGAMASHCRUnique.LOBBY)
                {
                    LobbyMode.Render();
                   
                }
                else if (GamemodeHook.CurrentMode == EnumPublicSealedvaNOGALOMEPRGAMASHCRUnique.GAMEPLAY || GamemodeHook.CurrentMode == EnumPublicSealedvaNOGALOMEPRGAMASHCRUnique.PUNISHMENT_LEVEL)
                {
                   
                   
                    
                    GameplayWindow.Render();
                  
                }

            }
        }
        //private void w2(int _)
        //{
        //    if (Button("Sexo"))
        //    {
        //        LoggerInstance.Warning("Test");
        //    }
        //}

        //private void w(int _)
        //{
        //    GUILayout.Label("Players");

         
           
        //        lastbtn.height = 990;
        //        foreach (var item in ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1)
        //        {

        //            if (Button((item.prop_Boolean_4 ? "<color=red>" : "") + item.prop_ObjectPublicObInObBoPlObBoAc1StUnique_0.field_Public_ValueTypePublicSealedObBy_sVoStVoByVoUnique_2.Decrypt() + (item.prop_Boolean_4 ? "</color>" : "")))
        //            {

        //                selectedPlayer = item;
        //            }
        //        }

        //        GUILayout.Label("Options");
        //        if (Button("TPTo"))
        //        {
        //            ObjectPublicObLi1PlInPlInObLi1Unique.prop_Player_0.prop_Actor_0.transform.position = selectedPlayer.prop_Actor_0.transform.position;
        //        }
        //        //if (Button("TPTo"))
        //        //{
        //        //    selectedPlayer.prop_HoloNetObject_0.SendHoloMessage(Object2PublicVeObVoVeObVeObVeObVe4.Method_Public_Static_Object2PublicVeObVoVeObVeObVeObVe4_Vector3_PDM_0(ObjectPublicObLi1PlInPlInObLi1Unique.prop_Player_0.prop_Actor_0.transform.position));
        //        //}
        //        if (Button("Kill"))
        //        {
        //            StaticMethods.Kill(selectedPlayer.prop_HoloNetObject_0);
        //        }
        //        if (Button("KillAll"))
        //        {
        //            foreach (var item in ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1)
        //            {
        //                if (item.prop_HoloNetObject_0.IsLocal) continue;
        //                StaticMethods.Kill(item.prop_HoloNetObject_0);
        //            }
        //        }
        //        GUILayout.Label("Buffs");

        //        if (Button("God"))
        //        {
        //            StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.INVINCIBLE);
        //        }
        //        if (Button("UnGod"))
        //        {
        //            StaticMethods.DeBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.INVINCIBLE);
        //        }
        //        if (Button("GodAll"))
        //        {
        //            foreach (var item in ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1)
        //            {
        //                StaticMethods.ApplyBuff(item.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.INVINCIBLE);
        //            }
        //        }
        //        if (Button("GodAllExceptNeighbor"))
        //        {
        //            foreach (var item in ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1)
        //            {
        //                if (item.prop_Boolean_4) continue;
        //                StaticMethods.ApplyBuff(item.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.INVINCIBLE);
        //            }
        //        }
        //        if (Button("UnGodAll"))
        //        {
        //            foreach (var item in ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1)
        //            {
        //                StaticMethods.DeBuff(item.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.INVINCIBLE);
        //            }
        //        }
        //        if (Button("Knock"))
        //        {
        //            StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.KNOCK);
        //        }
        //        if (Button("KnockAll"))
        //        {
        //            foreach (var item in ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1)
        //            {
        //                if (item.prop_HoloNetObject_0.IsLocal) continue;
        //                StaticMethods.ApplyBuff(item.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.KNOCK);
        //            }
        //        }
        //        if (Button("Tomato"))
        //        {
        //            StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.TOMATO);
        //        }
        //        if (Button("TomatoAll"))
        //        {
        //            foreach (var item in ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1)
        //            {
        //                if (item.prop_HoloNetObject_0.IsLocal) continue;
        //                StaticMethods.ApplyBuff(item.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.TOMATO);
        //            }
        //        }

        //        if (Button("Catch"))
        //        {

        //            StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.CATCH);

        //        }
        //        if (Button("StopCatch"))
        //        {
        //            StaticMethods.DeBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.CATCH);
        //        }
        //        if (Button("AddNeigborAbilities"))
        //        {
        //            StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.CONTROL_GATES_BUFF);
        //            StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.SECRET_DOOR_CONTROL);

        //        }
        //        if (Button("AddNeigborAbilitiesAll"))
        //        {
        //            foreach (var item in ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1)
        //            {
        //                StaticMethods.ApplyBuff(item.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.CONTROL_GATES_BUFF);
        //                StaticMethods.ApplyBuff(item.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.SECRET_DOOR_CONTROL);
        //            }
        //        }
        //        if (Button("RemoveNeigborAbilities"))
        //        {
        //            StaticMethods.DeBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.CONTROL_GATES_BUFF);
        //            StaticMethods.DeBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.SECRET_DOOR_CONTROL);

        //        }
        //        if (Button("RemoveNeigborAbilitiesAll"))
        //        {
        //            foreach (var item in ObjectPublicObLi1PlInPlInObLi1Unique.prop_List_1_Player_1)
        //            {
        //                StaticMethods.DeBuff(item.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.CONTROL_GATES_BUFF);
        //                StaticMethods.DeBuff(item.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.SECRET_DOOR_CONTROL);
        //            }
        //        }
        //        if (Button("DisableSkills"))
        //        {
        //            StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.DISABLE_SKILLS);
        //        }
        //        if (Button("EnableSkillsBack"))
        //        {
        //            StaticMethods.DeBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.DISABLE_SKILLS);
        //        }
        //        if (Button("DisableEveryting"))
        //        {
        //            StaticMethods.ApplyBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.DISABLE_ALL);
        //        }
        //        if (Button("EnableEverytingBack"))
        //        {
        //            StaticMethods.DeBuff(selectedPlayer.prop_HoloNetObject_0, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique.DISABLE_ALL);
        //        }
        //        GUILayout.Label("EndMatch");
        //        if (Button("KIDS_WIN"))
        //        {
        //            StaticMethods.EndMatch(EnumPublicSealedvaALBATIQU5vUnique.BASEMENT_ENTERED);
        //        }
        //        if (Button("NEIGHBOR_WIN"))
        //        {
        //            StaticMethods.EndMatch(EnumPublicSealedvaALBATIQU5vUnique.ALL_CHILDREN_DEAD);
        //        }
        //        if (Button("QUESTION_MARK"))
        //        {
        //            StaticMethods.EndMatch(EnumPublicSealedvaALBATIQU5vUnique.QUEST_COMPLETED);
        //        }
        //        GUILayout.Label("Events");
        //        if (Button("Mayak"))
        //        {
        //            GameObject.FindObjectOfType<LeversQuestCounter>().prop_HoloNetObject_0.SendHoloMessage(Object2PublicTVo1.Method_Public_Static_T_0<Object3PublicVo156>());
        //        }
        //        if (Button("Rocket"))
        //        {
        //            GameObject.FindObjectOfType<RocketLaunchButton>().prop_HoloNetObject_0.SendHoloMessage(Object2PublicTVo1.Method_Public_Static_T_0<Object3PublicVo89>());
        //        }
        //        GUILayout.Label("Test");
        //        if (Button("OpenBasement"))
        //        {
        //            var key = GameObject.FindObjectsOfType<KeyInventoryItem>().First();
        //            foreach (var item in GameObject.FindObjectsOfType<BasementDoorLockInteractable>())
        //            {
        //                item.prop_HoloNetObject_0.SendHoloMessage(Object2PublicObKeObPlUnique.Method_Public_Static_Object2PublicObKeObPlUnique_KeyInventoryItem_Player_0(key, ObjectPublicObLi1PlInPlInObLi1Unique.prop_Player_0));
        //            }
        //            GameObject.FindObjectOfType<BasementDoorInteractable>().prop_HoloNetObject_0.SendHoloMessage(Object2PublicTVo1.Method_Public_Static_T_0<Object3PublicVo152>());
        //        }
        //        if (Button("CrashWindows"))
        //        {
        //            foreach (var item in GameObject.FindObjectsOfType<Window>())
        //            {
        //                item.prop_HoloNetObject_0.SendHoloMessage(Object2PublicVeObVeVoObVeObVeObVe1.Method_Public_Static_Object2PublicVeObVeVoObVeObVeObVe1_Vector3_Vector3_PDM_0(Vector3.zero, Vector3.zero));
        //            }
        //        }
        //        if (Button("EnterSNRoom"))
        //        {
        //            var door = GameObject.FindObjectsOfType<SecretRoomDoorInteractable>().First();
        //            if (door)
        //                door.prop_HoloNetObject_0.SendHoloMessage(Object2PublicVeObPlUnique.Method_Public_Static_Object2PublicVeObPlUnique_Vector3_Player_PDM_0(door.transform.position, selectedPlayer));
        //        }
        //        if (Button("Flashlight[RED]"))
        //        {
        //            foreach (var item in GameObject.FindObjectsOfType<FlashlightInventoryItem>())
        //            {
        //                item.prop_HoloNetObject_0.SendHoloMessage(Object2PublicSiSiSiUnique.Method_Public_Static_Object2PublicSiSiSiUnique_Color_PDM_0(Color.red));
        //            }
        //        }
            
       

        //}

        public override void OnUpdate()

        {
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                Enabled = !Enabled;
            }
            if (Input.GetKeyDown(KeyCode.F1))
            {

                RenderSettings.ambientLight = RenderSettings.ambientLight == Color.white ? Color.clear : Color.white;
            }
            if (Input.GetKeyDown(KeyCode.F2))
            {
                UI.prop_Canvas_0.enabled = !UI.prop_Canvas_0.enabled;
            }
            if (Input.GetKeyDown(KeyCode.F3))
            {
                Resources.FindObjectsOfTypeAll<PunishmentConfig>().First().punishWhenLeave = 0;
                Resources.FindObjectsOfTypeAll<PunishmentConfig>().First().maxPunishStartGameDelay = 0;
           
                foreach (var item in Resources.FindObjectsOfTypeAll<NeighborRageSkillConfig>())
                {
         
                    item.lockedFromStart = false;
                    item.decreaseSpeed = 0;
                    item.maxRage = new Il2CppCodeStage.AntiCheat.ObscuredTypes.ObscuredInt( int.MaxValue);
                }

                foreach (var item in Resources.FindObjectsOfTypeAll<NeighborConfig>())
                {
                    item.doorBreaking.doorBreakDamage = byte.MaxValue;
                  
                    item.catching.catchDelay = 0;
                   
                }
                //foreach (var item in GameObject.FindObjectsOfType<RifleInventoryItem>())
                //{
                //    item.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 3f;
                  
                //    item.Method_Public_Void_Boolean_PDM_0(true);
                //}
              
                //foreach (var item in Resources.FindObjectsOfTypeAll<CustomizationItemInfo>())
                //{
                //    item.isDefaultValue = true;
                //    LoggerInstance.Warning(item.actorClassId);
                //    item.actorClassId = "BasicNeighbor";
                //    item.classId = EnumPublicSealedva16Unique.EnumValue8;
                //}
                //LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_1.prop_ActorClassInfo_0.isNeighborClass = new Il2CppCodeStage.AntiCheat.ObscuredTypes.ObscuredBool(false);
                //LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_2.prop_ActorClassInfo_0.isNeighborClass = new Il2CppCodeStage.AntiCheat.ObscuredTypes.ObscuredBool(false);
                //LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0.prop_ActorClassInfo_0.isNeighborClass = new Il2CppCodeStage.AntiCheat.ObscuredTypes.ObscuredBool(false);
                //LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0.field_Public_ValueTypePublicSealedObBy_sVoStVoByVoUnique_0 = "BasicNeighbor".Encrypt();
                //legs = "Engineer_LEGS_Frozen".Encrypt();
                //accessory = "Engineer_ACCESSORY_Frozen".Encrypt();
                //torso = "Engineer_TORSO_Frozen".Encrypt();
                //head = "Engineer_HEAD_Basic".Encrypt();
                // LoggerInstance.Warning(LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_1.prop_ActorClassInfo_0.Id);

                // LoggerInstance.Warning(LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0.field_Public_ValueTypePublicSealedObBy_sVoStVoByVoUnique_0.Decrypt());
                // LoggerInstance.Warning(LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0.prop_ActorClassInfo_0.Id);

                // //LoggerInstance.Warning(LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0.prop_ActorClassInfo_0.includeToBuild);
                // LoggerInstance.Warning(LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0.prop_ActorClassInfo_0.isNeighborClass);
                //LoggerInstance.Warning(LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0.prop_ActorClassInfo_0.classId);
                //LoggerInstance.Warning(LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0.field_Public_ObjectPublicObLi1DiOb2InCuDi2Unique_0.field_Public_ValueTypePublicSealedObBy_sVoStVoByVoUnique_0.Decrypt());
                //  LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0.field_Public_ObjectPublicObLi1DiOb2InCuDi2Unique_0.field_Public_List_1_ValueTypePublicSealedObBy_sVoStVoByVoUnique_0.Clear();
                //LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0.field_Public_ObjectPublicObLi1DiOb2InCuDi2Unique_0.field_Public_List_1_ValueTypePublicSealedObBy_sVoStVoByVoUnique_0.Add(legs);
                //LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0.field_Public_ObjectPublicObLi1DiOb2InCuDi2Unique_0.field_Public_List_1_ValueTypePublicSealedObBy_sVoStVoByVoUnique_0.Add(head);
                //LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0.field_Public_ObjectPublicObLi1DiOb2InCuDi2Unique_0.field_Public_List_1_ValueTypePublicSealedObBy_sVoStVoByVoUnique_0.Add(torso);
                //LobbyController.prop_LobbyController_0.players.prop_LobbyPlayer_0.field_Public_ObjectPublicISerializableObLoObAcLoUnique_0.field_Public_ObjectPublicObLi1DiOb2InCuDi2Unique_0.field_Public_List_1_ValueTypePublicSealedObBy_sVoStVoByVoUnique_0.Add(accessory);


                // ObjectPublicObStObLi1ObMaLi1BoUnique.prop_ObjectPublicObStObLi1ObMaLi1BoUnique_0.field_Public_ObjectPublicObInObBoPlObBoAc1StUnique_0.field_Public_ValueTypePublicSealedObBy_sVoStVoByVoUnique_2 = "".Encrypt();



                //foreach(var item in ObjectPublicAbstractSealedObInObSeBoObSiDoSiBoUnique.prop_Object1PublicObBoDi2InStObBoInDiUnique_0.field_Private_Hashtable_0)
                // {
                //     LoggerInstance.Warning(item.Key.ToString()+": "+item.Value.GetType());
                // }
            }

           
            if (GamemodeHook.CurrentMode == EnumPublicSealedvaNOGALOMEPRGAMASHCRUnique.GAMEPLAY || GamemodeHook.CurrentMode == EnumPublicSealedvaNOGALOMEPRGAMASHCRUnique.PUNISHMENT_LEVEL)
            {
                if (Input.GetKeyDown(KeyCode.H))
                {
                    if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward,out RaycastHit hit, 4))
                    {
                       
                        if (hit.collider.gameObject.GetComponentInParent<HoloNetObject>())
                        {
                            hit.collider.gameObject.GetComponentInParent<HoloNetObject>().DestroyHolo();
                        }
                    }
                }
               
                if (Input.GetKeyDown(KeyCode.R))
                {

                    ObjectPublicObLi1PlInPlInObLi1Unique.prop_Player_0.prop_Actor_0.GetComponent<Collider>().enabled = false;
                }
                if (Input.GetKeyUp(KeyCode.R))
                {
                    ObjectPublicObLi1PlInPlInObLi1Unique.prop_Player_0.prop_Actor_0.GetComponent<Collider>().enabled = true;
                }
                if (Input.GetKey(KeyCode.R))
                {
                    ObjectPublicObLi1PlInPlInObLi1Unique.prop_Player_0.prop_Actor_0.transform.position += (Camera.main.transform.forward * Input.GetAxisRaw("Vertical") + Camera.main.transform.right * Input.GetAxisRaw("Horizontal")).normalized * 10f * Time.deltaTime;
                }
            }
        }

       
       
      
      
    }
   
}
