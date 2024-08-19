using BoneLib.BoneMenu;
using System;
using UnityEngine;
using MelonLoader;




namespace Melon_Loader_Mod5
{
    internal class PreferencesCreator
    {
        

        public static MelonPreferences_Category MelonPrefCategory { get; private set; }
        public static MelonPreferences_Entry<bool> MelonPrefEnabled { get; private set; }
        public static bool IsEnabled { get; private set; }
        public static MelonPreferences_Entry<Color> NorthPref { get; private set; }
        public static MelonPreferences_Entry<Color> NorthEastPref { get; private set; }
        public static MelonPreferences_Entry<Color> EastPref { get; private set; }
        public static MelonPreferences_Entry<Color> SouthEastPref { get; private set; }
        public static MelonPreferences_Entry<Color> SouthPref { get; private set; }
        public static MelonPreferences_Entry<Color> SouthWestPref { get; private set; }
        public static MelonPreferences_Entry<Color> WestPref { get; private set; }
        public static MelonPreferences_Entry<Color> NorthWestPref { get; private set; }
        public static MelonPreferences_Entry<Color> MiddlePref { get; private set; }
        public static bool MelonPrefEnabledValue { get; private set; }


        public static void MelonPreferencesCreator()
        {
            MelonPrefCategory = MelonPreferences.CreateCategory("Colorful");
            MelonPrefEnabled = MelonPrefCategory.CreateEntry<bool>("IsEnabled", true, null, null, false, false, null, null);
            IsEnabled = MelonPrefEnabled.Value;
            NorthPref = MelonPrefCategory.CreateEntry<Color>("Eject Color", Colors.NorthDefult, null, null, false);
            NorthEastPref = MelonPrefCategory.CreateEntry<Color>("Level Select Color", Colors.NorthEastDefult, null, null, false);
            EastPref = MelonPrefCategory.CreateEntry<Color>("Preferences Color", Colors.EastDefult, null, null, false);
            SouthEastPref = MelonPrefCategory.CreateEntry<Color>("Quick Mute Color", Colors.SouthEastDefult, null, null, false);
            SouthPref = MelonPrefCategory.CreateEntry<Color>("Inventory Color", Colors.SouthDefult, null, null, false);
            SouthWestPref = MelonPrefCategory.CreateEntry<Color>("Spawn Devtools Color", Colors.SouthWestDefult, null, null, false);
            WestPref = MelonPrefCategory.CreateEntry<Color>("SpawnGun Menu Color", Colors.WestDefult, null, null, false);
            NorthWestPref = MelonPrefCategory.CreateEntry<Color>("Avatar Select Color", Colors.NorthWestDefult, null, null, false);
            MiddlePref = MelonPrefCategory.CreateEntry<Color>("Radial Cancel Color", Colors.MiddleDefult, null, null, false);
        }
        public static void BonemenuCreator()
        {

            string NorthHexcode = ColorUtility.ToHtmlStringRGBA(Colors.North);
            string NorthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.NorthEast);
            string EastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.East);
            string SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.SouthEast);
            string SouthHexcode = ColorUtility.ToHtmlStringRGBA(Colors.South);
            string SouthWestHexcode = ColorUtility.ToHtmlStringRGBA(Colors.SouthWest);
            string WestHexcode = ColorUtility.ToHtmlStringRGBA(Colors.West);
            string NorthWestHexcode = ColorUtility.ToHtmlStringRGBA(Colors.NorthWest);

            string SuperLongName =
                "<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>";

            var category = Page.Root.CreatePage(SuperLongName, Color.white, maxElements: 9); //TODO temporarily set max elements to 9, avoids https://github.com/yowchap/BoneLib/issues/70

            category.CreateBool("Mod Toggle", Color.yellow, IsEnabled, new Action<bool>(OnSetEnabled));

            //if I could shorten these I would but I can't 
            var NorthButton = category.CreatePage("Eject", Colors.North);
            ColorfulMenuCreator(NorthButton, Colors.North, (updatedColor) =>
            {
                Colors.North = updatedColor;
                NorthButton.Color = updatedColor;
                NorthHexcode = ColorUtility.ToHtmlStringRGBA(updatedColor);
                category.Name = "<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>";
                NorthPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();


            });
            var NorthEastButton = category.CreatePage("Level Select", Colors.NorthEast);
            ColorfulMenuCreator(NorthEastButton, Colors.NorthEast, (updatedColor) =>
            {
                Colors.NorthEast = updatedColor;
                NorthEastButton.Color = updatedColor;
                NorthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.NorthEast);
                category.Name = "<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>";
                NorthEastPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var EastButton = category.CreatePage("Preferences", Colors.East);
            ColorfulMenuCreator(EastButton, Colors.East, (updatedColor) =>
            {
                Colors.East = updatedColor;
                EastButton.Color = updatedColor;
                EastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.East);
                category.Name = "<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>";
                EastPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var SouthEastButton = category.CreatePage("Quick Mute", Colors.SouthEast);
            ColorfulMenuCreator(SouthEastButton, Colors.SouthEast, (updatedColor) =>
            {
                Colors.SouthEast = updatedColor;
                SouthEastButton.Color = updatedColor;
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.SouthEast);
                category.Name = "<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>";
                SouthEastPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var SouthButton = category.CreatePage("Inventory", Colors.South);
            ColorfulMenuCreator(SouthButton, Colors.South, (updatedColor) =>
            {
                Colors.South = updatedColor;
                SouthButton.Color = updatedColor;
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.South);
                category.Name = "<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>";
                SouthPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var SouthWestButton = category.CreatePage("Spawn Devtools", Colors.SouthWest);
            ColorfulMenuCreator(SouthWestButton, Colors.SouthWest, (updatedColor) =>
            {
                Colors.SouthWest = updatedColor;
                SouthWestButton.Color = updatedColor;
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.SouthWest);
                category.Name = "<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>";
                SouthWestPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var WestButton = category.CreatePage("SpawnGun Menu", Colors.West);
            ColorfulMenuCreator(WestButton, Colors.West, (updatedColor) =>
            {
                Colors.West = updatedColor;
                WestButton.Color = updatedColor;
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.West);
                category.Name = "<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>";
                WestPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var NorthWestButton = category.CreatePage("Avatar Select", Colors.NorthWest);
            ColorfulMenuCreator(NorthWestButton, Colors.NorthWest, (updatedColor) =>
            {
                Colors.NorthWest = updatedColor;
                NorthWestButton.Color = updatedColor;
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.NorthWest);
                category.Name = "<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>";
                NorthWestPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });

            var extra = category.CreatePage("Extra", Color.white);

            var MiddleButton = extra.CreatePage("Radial Cancel", Colors.Middle);
            ColorfulMenuCreator(MiddleButton, Colors.Middle, (updatedColor) =>
            {
                Colors.Middle = updatedColor;
                MiddleButton.Color = updatedColor;
                MiddlePref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });

            var OverrideButton = extra.CreatePage("Color Override", Color.black);
            ColorfulMenuCreatorOverride(OverrideButton, Color.white, (updatedColor) =>
            {
                Colors.Middle = updatedColor;
                MiddleButton.Color = updatedColor;
                Colors.Middle = updatedColor;
                MiddlePref.Value = updatedColor;

                NorthButton.Color = updatedColor;
                Colors.North = updatedColor;
                NorthPref.Value = updatedColor;

                NorthEastButton.Color = updatedColor;
                Colors.NorthEast = updatedColor;
                NorthEastPref.Value = updatedColor;

                EastButton.Color = updatedColor;
                Colors.East = updatedColor;
                EastPref.Value = updatedColor;

                SouthEastButton.Color = updatedColor;
                Colors.SouthEast = updatedColor;
                SouthEastPref.Value = updatedColor;

                SouthButton.Color = updatedColor;
                Colors.South = updatedColor;
                SouthPref.Value = updatedColor;

                SouthWestButton.Color = updatedColor;
                Colors.SouthWest = updatedColor;
                SouthWestPref.Value = updatedColor;

                WestButton.Color = updatedColor;
                Colors.West = updatedColor;
                WestPref.Value = updatedColor;

                NorthWestButton.Color = updatedColor;
                Colors.NorthWest = updatedColor;
                NorthWestPref.Value = updatedColor;

                Melon_Loader_Mod5.Main.MoggingTime();
                MelonPrefCategory.SaveToFile();
            });

            var DefaultButton = extra.CreatePage("Reset To Defaults", Color.white, maxElements: 9); //TODO temporarily set max elements to 9, avoids https://github.com/yowchap/BoneLib/issues/70
            DefaultButton.CreateFunction("Default Eject", Colors.NorthDefult, delegate ()
            {
                NorthButton.Color = Colors.NorthDefult;
                Colors.North = Colors.NorthDefult;
                NorthPref.Value = Colors.NorthDefult;

                Melon_Loader_Mod5.Main.MoggingTime();
                MelonPrefCategory.SaveToFile();
            });
            DefaultButton.CreateFunction("Defult Level Select", Colors.NorthEastDefult, delegate ()
            {
                NorthEastButton.Color = Colors.NorthEastDefult;
                Colors.NorthEast = Colors.NorthEastDefult;
                NorthEastPref.Value = Colors.NorthEastDefult;

                Melon_Loader_Mod5.Main.MoggingTime();
                MelonPrefCategory.SaveToFile();
            });

            DefaultButton.CreateFunction("Defult Preferences", Colors.EastDefult, delegate ()
            {
                EastButton.Color = Colors.EastDefult;
                Colors.East = Colors.EastDefult;
                EastPref.Value = Colors.EastDefult;

                Melon_Loader_Mod5.Main.MoggingTime();
                MelonPrefCategory.SaveToFile();
            });

            DefaultButton.CreateFunction("Defult Quick Mute", Colors.SouthEastDefult, delegate ()
            {
                SouthEastButton.Color = Colors.SouthEastDefult;
                Colors.SouthEast = Colors.SouthEastDefult;
                SouthEastPref.Value = Colors.SouthEastDefult;

                Melon_Loader_Mod5.Main.MoggingTime();
                MelonPrefCategory.SaveToFile();
            });

            DefaultButton.CreateFunction("Defult Inventory", Colors.SouthDefult, delegate ()
            {
                SouthButton.Color = Colors.SouthDefult;
                Colors.South = Colors.SouthDefult;
                SouthPref.Value = Colors.SouthDefult;

                Melon_Loader_Mod5.Main.MoggingTime();
                MelonPrefCategory.SaveToFile();
            });

            DefaultButton.CreateFunction("Defult Spawn DevTools", Colors.SouthWestDefult, delegate ()
            {
                SouthWestButton.Color = Colors.SouthWestDefult;
                Colors.SouthWest = Colors.SouthWestDefult;
                SouthWestPref.Value = Colors.SouthWestDefult;

                Melon_Loader_Mod5.Main.MoggingTime();
                MelonPrefCategory.SaveToFile();
            });

            DefaultButton.CreateFunction("Defult Spawn Gun Menu", Colors.WestDefult, delegate ()
            {
                WestButton.Color = Colors.WestDefult;
                Colors.West = Colors.WestDefult;
                WestPref.Value = Colors.WestDefult;

                Melon_Loader_Mod5.Main.MoggingTime();
                MelonPrefCategory.SaveToFile();
            });

            DefaultButton.CreateFunction("Defult Avatar Select", Colors.NorthWestDefult, delegate ()
            {
                NorthWestButton.Color = Colors.NorthWestDefult;
                Colors.NorthWest = Colors.NorthWestDefult;
                NorthWestPref.Value = Colors.NorthWestDefult;

                Melon_Loader_Mod5.Main.MoggingTime();
                MelonPrefCategory.SaveToFile();
            });

            DefaultButton.CreateFunction("Defult Radial Cancel", Colors.MiddleDefult, delegate ()
            {
                MiddleButton.Color = Colors.MiddleDefult;
                Colors.Middle = Colors.MiddleDefult;
                MiddlePref.Value = Colors.MiddleDefult;

                Melon_Loader_Mod5.Main.MoggingTime();
                MelonPrefCategory.SaveToFile();
            });

            ColorfulMenuCreatorDefault(DefaultButton, (updatedColor) =>
            {
                Colors.Middle = Colors.MiddleDefult;
                MiddleButton.Color = Colors.MiddleDefult;
                Colors.Middle = Colors.MiddleDefult;
                MiddlePref.Value = Colors.MiddleDefult;

                NorthButton.Color = Colors.NorthDefult;
                Colors.North = Colors.NorthDefult;
                NorthPref.Value = Colors.NorthDefult;

                NorthEastButton.Color = Colors.NorthEastDefult;
                Colors.NorthEast = Colors.NorthEastDefult;
                NorthEastPref.Value = Colors.NorthEastDefult;

                EastButton.Color = Colors.EastDefult;
                Colors.East = Colors.EastDefult;
                EastPref.Value = Colors.EastDefult;

                SouthEastButton.Color = Colors.SouthEastDefult;
                Colors.SouthEast = Colors.SouthEastDefult;
                SouthEastPref.Value = Colors.SouthEastDefult;

                SouthButton.Color = Colors.SouthDefult;
                Colors.South = Colors.SouthDefult;
                SouthPref.Value = Colors.SouthDefult;

                SouthWestButton.Color = Colors.SouthWestDefult;
                Colors.SouthWest = Colors.SouthWestDefult;
                SouthWestPref.Value = Colors.SouthWestDefult;

                WestButton.Color = Colors.WestDefult;
                Colors.West = Colors.WestDefult;
                WestPref.Value = Colors.WestDefult;

                NorthWestButton.Color = Colors.NorthWestDefult;
                Colors.NorthWest = Colors.NorthWestDefult;
                NorthWestPref.Value = Colors.NorthWestDefult;

                Melon_Loader_Mod5.Main.MoggingTime();
                MelonPrefCategory.SaveToFile();
            });

        }
        
        public static void ColorfulMenuCreator(Page category, Color currentColor, Action<Color> applyCallback)
        {
            float red = currentColor.r;
            float green = currentColor.g;
            float blue = currentColor.b;
            float alpha = currentColor.a;
            var colorPreview = category.CreateFunction("■■■■■■■■■■■", currentColor, null);

            var colorR = category.CreateFloat("Red", Color.red, currentColor.r, 0.1f, 0f, 1f, (r) =>
            {
                currentColor.r = r;
                colorPreview.ElementColor = currentColor;
            });

            var colorG = category.CreateFloat("Green", Color.green, currentColor.g, 0.1f, 0f, 1f, (g) =>
            {
                currentColor.g = g;
                colorPreview.ElementColor = currentColor;
            });

            var colorB = category.CreateFloat("Blue", Color.blue, currentColor.b, 0.1f, 0f, 1f, (b) =>
            {
                currentColor.b = b;
                colorPreview.ElementColor = currentColor;
            });

            var colorA = category.CreateFloat("Alpha", Color.black, currentColor.a, 0.1f, 0f, 1f, (a) =>
            {
                currentColor.a = a;
                colorPreview.ElementColor = currentColor;
            });

            category.CreateFunction("Apply", Color.white, delegate ()
            {
                applyCallback(currentColor);
                Melon_Loader_Mod5.Main.MoggingTime();

            });
        }

        public static void ColorfulMenuCreatorOverride(Page category, Color currentColor, Action<Color> applyCallback)
        {
            float red = currentColor.r;
            float green = currentColor.g;
            float blue = currentColor.b;
            float alpha = currentColor.a;
            var colorPreview = category.CreateFunction("■■■■■■■■■■■", currentColor, null);

            var colorR = category.CreateFloat("Red", Color.red, currentColor.r, 0.1f, 0f, 1f, (r) =>
            {
                currentColor.r = r;
                colorPreview.ElementColor = currentColor;
            });

            var colorG = category.CreateFloat("Green", Color.green, currentColor.g, 0.1f, 0f, 1f, (g) =>
            {
                currentColor.g = g;
                colorPreview.ElementColor = currentColor;
            });

            var colorB = category.CreateFloat("Blue", Color.blue, currentColor.b, 0.1f, 0f, 1f, (b) =>
            {
                currentColor.b = b;
                colorPreview.ElementColor = currentColor;
            });

            var colorA = category.CreateFloat("Alpha", Color.black, currentColor.a, 0.1f, 0f, 1f, (a) =>
            {
                currentColor.a = a;
                colorPreview.ElementColor = currentColor;
            });
            //category.CreateFunction("Apply", Color.white, () => Menu.DisplayDialog("Apply", "Are you sure? This will override all colors you've set", denyAction: () => { }, confirmAction: () => applyCallback(currentColor))); //TODO confirmation dialogue temporarily disabled due to https://github.com/yowchap/BoneLib/issues/72
            category.CreateFunction("Apply", Color.white, () => applyCallback(currentColor));
        }

        public static void ColorfulMenuCreatorDefault(Page category, Action<Color> applyCallback)
        {
            //category.CreateFunction("Default All", Color.black, () => Menu.DisplayDialog("Default All", "Are you sure? This will set all colors you've set to default", denyAction: () => { }, confirmAction: () => applyCallback(Color.black))); //TODO confirmation dialogue temporarily disabled due to https://github.com/yowchap/BoneLib/issues/72
            category.CreateFunction("Default All", Color.black, () => applyCallback(Color.black));
        }


        public static void OnSetEnabled(bool value) // Some extra stuff for the on enabled button
        {
            IsEnabled = value;
            MelonPrefEnabled.Value = value;
            MelonPrefCategory.SaveToFile();
            Melon_Loader_Mod5.Main.MoggingTime();

        }
    }
}



