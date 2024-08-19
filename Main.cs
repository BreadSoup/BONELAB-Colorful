using MelonLoader;
using UnityEngine;


namespace Melon_Loader_Mod5
{
    public static class BuildInfo
    {
        public const string Name = "Colorful";
        public const string Author = "Bread Soup";
        public const string Company = null;
        public const string Version = "1.1.2";
        public const string DownloadLink = null;
    }

    internal partial class Main : MelonMod
    {

        public void OnSceneAwake()
        {
            if (Melon_Loader_Mod5.PreferencesCreator.IsEnabled)
            {
                MoggingTime();
            }
            Melon_Loader_Mod5.RadialMenuButtonsUI.RadialMenuButtons();

        }
        public override void OnInitializeMelon()
        {
            BoneLib.Hooking.OnLevelLoaded += (_) => { OnSceneAwake(); }; //Fusion is under MIT licencse so pretty sure as long as I cWestit it I'll be fine

            //Colors Colors = new Colors();
            Melon_Loader_Mod5.PreferencesCreator.MelonPreferencesCreator();
            Melon_Loader_Mod5.Colors.ColorAssignment();
            Melon_Loader_Mod5.PreferencesCreator.BonemenuCreator();




        }



        public static void MoggingTime()
        {
            var objectsWithKeyword = GameObject.FindObjectsOfType<GameObject>(true);
            foreach (GameObject obj in objectsWithKeyword)
            {
                if (obj.name.Contains("group_levelSelect"))
                {
                    Melon_Loader_Mod5.LevelSelectUI.LevelSelect(obj.transform, isSecondChild: true);
                }
                else if (obj.name.Contains("panel_Preferences"))
                {
                    Melon_Loader_Mod5.PreferencesUI.Preferences(obj.transform, isSecondChild: true);
                }
                else if (obj.name.Contains("grid_Graphics"))
                {
                    Melon_Loader_Mod5.PreferencesUI.Extra(obj.transform);
                }
                else if (obj.name.Contains("group_toolMenu"))
                {
                    Melon_Loader_Mod5.SpawnGunUI.SpawnGun(obj.transform, isFourthChild: true);
                }
                else if (obj.name.Contains("group_AvatarSelect"))
                {
                    Melon_Loader_Mod5.AvatarSelectUI.Avatar(obj.transform, isSecondChild: true);
                }
                else if (obj.name.Contains("BodyMallController"))
                {
                    Melon_Loader_Mod5.AvatarSelectUI.Bodymall(obj.transform);
                }
                else if (obj.name.Contains("CANVAS_RADIALUI"))
                {
                    Melon_Loader_Mod5.RadialMenuTextAndImageUI.RadialMenuTextAndImage(obj.transform);
                }
            }
            Melon_Loader_Mod5.RadialMenuButtonsUI.RadialMenuButtons();
        }
    }
}