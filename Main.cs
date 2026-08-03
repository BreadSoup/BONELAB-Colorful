using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using Il2CppTMPro;
using System.IO;
using BoneLib.BoneMenu;
using System;
using BoneLib.BoneMenu;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using BoneLib;
using SLZ.VRMK;
using System.Security.Policy;
using System.Collections.Generic;
using Object = UnityEngine.Object;


namespace Colorful
{
    public static class BuildInfo
    {
        public const string Name = "Colorful";
        public const string Author = "Bread Soup";
        public const string Company = null;
        public const string Version = "1.1.3";
        public const string DownloadLink = null;
    }

    internal partial class Main : MelonMod
    {

        public void OnSceneAwake()
        {
            if (PreferencesCreator.IsEnabled)
            {
                MoggingTime();
            }
            RadialMenuButtonsUI.RadialMenuButtons();

        }
        public override void OnInitializeMelon()
        {
            BoneLib.Hooking.OnLevelLoaded += (_) => { OnSceneAwake(); }; //Fusion is under MIT licencse so pretty sure as long as I cWestit it I'll be fine
            BoneLib.Hooking.OnUIRigCreated += () => { OnSceneAwake(); }; //the BoneMenu button is cloned in after OnLevelLoaded runs, so recolor again once the UIRig (and that button) exist

            //Colors Colors = new Colors();
            PreferencesCreator.MelonPreferencesCreator();
            Colors.ColorAssignment();
            PreferencesCreator.BonemenuCreator();




        }



        public static void MoggingTime()
        {
            var objectsWithKeyword = GameObject.FindObjectsOfType<GameObject>(true);
            var textMeshProUGUIs = UnityEngine.Object.FindObjectsOfType<Il2CppTMPro.TextMeshProUGUI>(); 
            foreach (GameObject obj in objectsWithKeyword)
            {
                if (obj.name.Contains("group_levelSelect"))
                {
                    LevelSelectUI.LevelSelect(obj.transform, isSecondChild: true);
                }
                else if (obj.name.Contains("panel_Preferences"))
                {
                    PreferencesUI.Preferences(obj.transform, isSecondChild: true);
                }
                else if (obj.name.Contains("grid_Graphics"))
                {
                    PreferencesUI.Extra(obj.transform);
                }
                else if (obj.name.Contains("group_toolMenu"))
                {
                    SpawnGunUI.SpawnGun(obj.transform, isFourthChild: true);
                }
                else if (obj.name.Contains("group_AvatarSelect"))
                {
                    AvatarSelectUI.Avatar(obj.transform, isSecondChild: true);
                }
                else if (obj.name.Contains("BodyMallController"))
                {
                    AvatarSelectUI.Bodymall(obj.transform);
                }
                else if (obj.name.Contains("CANVAS_RADIALUI"))
                {
                    RadialMenuTextAndImageUI.RadialMenuTextAndImage(obj.transform);
                }
                else if (obj.name == "INVENTORYSLOTS")
                {
                    InventorySlotsUI.Slots(obj.transform);
                }
                else if (obj.name == "hud_Ammo")
                {
                    InventorySlotsUI.AmmoHud(obj.transform);
                }
            }
            RadialMenuButtonsUI.RadialMenuButtons();
        }
    }
}