using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using BoneLib.BoneMenu;
using System;
using BoneLib.BoneMenu.Elements;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using BoneLib;
using SLZ.VRMK;
using System.Security.Policy;
using System.Collections.Generic;
using Melon_Loader_Mod5;
// Melon_Loader_Mod5.Melon_Loader_Mod5 main = new Melon_Loader_Mod5.Melon_Loader_Mod5();


namespace Melon_Loader_Mod5
{
    public static class BuildInfo
    {
        public const string Name = "Colorful";
        public const string Author = "Bread Soup";
        public const string Company = null;
        public const string Version = "1.1.0";
        public const string DownloadLink = null;
    }

    public class Melon_Loader_Mod5 : MelonMod
    {
        LevelSelectUI LevelSelect = new LevelSelectUI();

        PreferencesUI Preferences = new PreferencesUI();

        SpawnGunUI SpawnGun = new SpawnGunUI();

        AvatarSelectUI AvatarSelect = new AvatarSelectUI();

        RadialMenuTextAndImageUI RadialMenuTextAndImage = new RadialMenuTextAndImageUI();

        RadialMenuButtonsUI RadialMenuButtons = new RadialMenuButtonsUI();


        private void OnSceneAwake()
        {
            PreferencesCreator GetIsEnabled = new PreferencesCreator();
            if (GetIsEnabled.GetIsEnabled())
            {
                MoggingTime();
                RadialMenuButtons.RadialMenuButtons();
            }
        }
        public override void OnInitializeMelon()
        {
            BoneLib.Hooking.OnLevelInitialized += (_) => { OnSceneAwake(); }; 
            PreferencesCreator Preferences = new PreferencesCreator();
            Colors Colors = new Colors();
            Preferences.MelonPreferencesCreator();
            Colors.ColorAssignment();
            Preferences.BonemenuCreator();
        }

        public void MoggingTime()
        {
            var objectsWithKeyword = GameObject.FindObjectsOfType<GameObject>(true);
            foreach (GameObject obj in objectsWithKeyword)
            {
                if (obj.name.Contains("group_levelSelect"))
                {
                    LevelSelect.LevelSelect(obj.transform, isSecondChild: true);
                }
                else if (obj.name.Contains("panel_Preferences"))
                {
                    Preferences.Preferences(obj.transform, isSecondChild: true);
                }
                else if (obj.name.Contains("grid_Graphics"))
                {
                    Preferences.Extra(obj.transform);
                }
                else if (obj.name.Contains("group_toolMenu"))
                {
                    SpawnGun.SpawnGun(obj.transform, isFourthChild: true);
                }
                else if (obj.name.Contains("group_AvatarSelect"))
                {
                    AvatarSelect.Avatar(obj.transform, isSecondChild: true);
                }
                else if (obj.name.Contains("BodyMallController")) 
                {
                    AvatarSelect.Bodymall(obj.transform);
                }
                else if (obj.name.Contains("CANVAS_RADIALUI"))
                {
                    RadialMenuTextAndImage.RadialMenuTextAndImage(obj.transform);
                }
            }
            RadialMenuButtons.RadialMenuButtons();
        }
    }
}