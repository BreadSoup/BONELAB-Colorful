using BoneLib.BoneMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Melon_Loader_Mod5;
using MelonLoader;
using BoneLib.BoneMenu.Elements;




namespace Melon_Loader_Mod5
{
    public class PreferencesCreator
    {
        Melon_Loader_Mod5 main = new Melon_Loader_Mod5();

        Colors Colors = new Colors();

        public static MelonPreferences_Category MelonPrefCategory { get; private set; }
        public static MelonPreferences_Entry<bool> MelonPrefEnabled { get; private set; }
        public static bool IsEnabled { get; private set; }
        public MelonPreferences_Entry<Color> NorthPref { get; private set; }
        public MelonPreferences_Entry<Color> NorthEastPref { get; private set; }
        public MelonPreferences_Entry<Color> EastPref { get; private set; }
        public MelonPreferences_Entry<Color> SouthEastPref { get; private set; }
        public MelonPreferences_Entry<Color> SouthPref { get; private set; }
        public MelonPreferences_Entry<Color> SouthWestPref { get; private set; }
        public MelonPreferences_Entry<Color> WestPref { get; private set; }
        public MelonPreferences_Entry<Color> EasrPref { get; private set; }
        public MelonPreferences_Entry<Color> NorthWestPref { get; private set; }
        public static bool MelonPrefEnabledValue { get; private set; }


        public void MelonPreferencesCreator()
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
        }
        public void BonemenuCreator()
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

            var category = MenuManager.CreateCategory(SuperLongName, Color.white);

            category.CreateBoolElement("Mod Toggle", Color.yellow, IsEnabled, new Action<bool>(OnSetEnabled));
            //if I could shorten these I would but I can't 
            var NorthButton = category.CreateCategory("Eject", Colors.North);
            ColorfulMenuCreator(NorthButton, Colors.North, (updatedColor) =>
            {
                Colors.North = updatedColor;
                NorthButton.SetColor(updatedColor);
                NorthHexcode = ColorUtility.ToHtmlStringRGBA(updatedColor);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                NorthPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();


            });
            var NorthEastButton = category.CreateCategory("Level Select", Colors.NorthEast);
            ColorfulMenuCreator(NorthEastButton, Colors.NorthEast, (updatedColor) =>
            {
                Colors.NorthEast = updatedColor;
                NorthEastButton.SetColor(updatedColor);
                NorthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.NorthEast);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                NorthEastPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var EastButton = category.CreateCategory("Preferences", Colors.East);
            ColorfulMenuCreator(EastButton, Colors.East, (updatedColor) =>
            {
                Colors.East = updatedColor;
                EastButton.SetColor(updatedColor);
                EastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.East);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                EastPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var SouthEastButton = category.CreateCategory("Quick Mute", Colors.SouthEast);
            ColorfulMenuCreator(SouthEastButton, Colors.SouthEast, (updatedColor) =>
            {
                Colors.SouthEast = updatedColor;
                SouthEastButton.SetColor(updatedColor);
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.SouthEast);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                SouthEastPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var SouthButton = category.CreateCategory("Inventory", Colors.South);
            ColorfulMenuCreator(SouthButton, Colors.South, (updatedColor) =>
            {
                Colors.South = updatedColor;
                SouthButton.SetColor(updatedColor);
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.South);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                SouthPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var SouthWestButton = category.CreateCategory("Spawn Devtools", Colors.SouthWest);
            ColorfulMenuCreator(SouthWestButton, Colors.SouthWest, (updatedColor) =>
            {
                Colors.SouthWest = updatedColor;
                SouthWestButton.SetColor(updatedColor);
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.SouthWest);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                SouthWestPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var WestButton = category.CreateCategory("SpawnGun Menu", Colors.West);
            ColorfulMenuCreator(WestButton, Colors.West, (updatedColor) =>
            {
                Colors.West = updatedColor;
                WestButton.SetColor(updatedColor);
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.West);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                WestPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var NorthWestButton = category.CreateCategory("Avatar Select", Colors.NorthWest);
            ColorfulMenuCreator(NorthWestButton, Colors.NorthWest, (updatedColor) =>
            {
                Colors.NorthWest = updatedColor;
                NorthWestButton.SetColor(updatedColor);
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(Colors.NorthWest);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                NorthWestPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
        }
        public void ColorfulMenuCreator(MenuCategory category, Color currentColor, Action<Color> applyCallback)
        {
            float red = currentColor.r;
            float green = currentColor.g;
            float blue = currentColor.b;
            float alpha = currentColor.a;
            var colorPreview = category.CreateFunctionElement("■■■■■■■■■■■", currentColor, null);

            var colorR = category.CreateFloatElement("Red", Color.red, currentColor.r, 0.1f, 0f, 1f, (r) =>
            {
                currentColor.r = r;
                colorPreview.SetColor(currentColor);
            });

            var colorG = category.CreateFloatElement("Green", Color.green, currentColor.g, 0.1f, 0f, 1f, (g) =>
            {
                currentColor.g = g;
                colorPreview.SetColor(currentColor);
            });

            var colorB = category.CreateFloatElement("Blue", Color.blue, currentColor.b, 0.1f, 0f, 1f, (b) =>
            {
                currentColor.b = b;
                colorPreview.SetColor(currentColor);
            });

            var colorA = category.CreateFloatElement("Alpha", Color.black, currentColor.a, 0.1f, 0f, 1f, (a) =>
            {
                currentColor.a = a;
                colorPreview.SetColor(currentColor);
            });

            category.CreateFunctionElement("Apply", Color.white, delegate ()
            {
                applyCallback(currentColor);
                main.MoggingTime();

            });
        }

        public void OnSetEnabled(bool value) // Some extra stuff for the on enabled button
        {
            IsEnabled = value;
            MelonPrefEnabled.Value = value;
            MelonPrefCategory.SaveToFile();
            if (value)
            {
                main.MoggingTime();
            }
        }

        public bool GetIsEnabled()
        {
            return IsEnabled;
        }
    }
}



