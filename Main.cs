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
