using UnityEngine;
// Colors Colors = new Colors();
namespace Melon_Loader_Mod5
{
    public class Colors
    {

        public static Color North = new Color(0f, 1f, 1f, 1f);

        public static Color NorthEast = new Color(1f, 0.5f, 0f, 1f); //level

        public static Color East = new Color(1f, 1f, 0f, 1f); //prefrances

        public static Color SouthEast = new Color(0f, 0f, 1f, 1f); //quick unmute

        public static Color South = new Color(1f, 0f, 1f, 1f); //inventory

        public static Color SouthWest = new Color(0.5f, 0f, 1f, 1f); //devtools

        public static Color West = new Color(1f, 0f, 0f, 1f); //spawngun 

        public static Color NorthWest = new Color(0f, 1f, 0f, 1f); //avatar

        public static Color Middle = new Color(1f, 0.2f, 0.2f, 0.7f); //cancel

        //defults 
        //I know I spelled default wrong but it doesnt matter
        public static Color NorthDefult = new Color(0f, 1f, 1f, 1f); //eject

        public static Color NorthEastDefult = new Color(1f, 0.5f, 0f, 1f); //level

        public static Color EastDefult = new Color(1f, 1f, 0f, 1f); //prefrances

        public static Color SouthEastDefult = new Color(0f, 0f, 1f, 1f); //quick unmute

        public static Color SouthDefult = new Color(1f, 0f, 1f, 1f); //inventory

        public static Color SouthWestDefult = new Color(0.5f, 0f, 1f, 1f); //devtools

        public static Color WestDefult = new Color(1f, 0f, 0f, 1f); //spawngun 

        public static Color NorthWestDefult = new Color(0f, 1f, 0f, 1f); //avatar

        public static Color MiddleDefult = new Color(1f, 0.2f, 0.2f, 1f); //cancel

        public static void ColorAssignment()
        {
            if (Melon_Loader_Mod5.PreferencesCreator.NorthPref != null)
            {
                North = Melon_Loader_Mod5.PreferencesCreator.NorthPref.Value;
            }
            else
            {
                North = NorthDefult;
            }

            if (Melon_Loader_Mod5.PreferencesCreator.NorthEastPref.Value != null)
            {
                NorthEast = Melon_Loader_Mod5.PreferencesCreator.NorthEastPref.Value;
            }
            else
            {
                NorthEast = NorthEastDefult;
            }

            if (Melon_Loader_Mod5.PreferencesCreator.EastPref.Value != null)
            {
                East = Melon_Loader_Mod5.PreferencesCreator.EastPref.Value;
            }
            else
            {
                East = EastDefult;
            }

            if (Melon_Loader_Mod5.PreferencesCreator.SouthEastPref.Value != null)
            {
                SouthEast = Melon_Loader_Mod5.PreferencesCreator.SouthEastPref.Value;
            }
            else
            {
                SouthEast = SouthEastDefult;
            }

            if (Melon_Loader_Mod5.PreferencesCreator.SouthPref.Value != null)
            {
                South = Melon_Loader_Mod5.PreferencesCreator.SouthPref.Value;
            }
            else
            {
                South = SouthDefult;
            }

            if (Melon_Loader_Mod5.PreferencesCreator.SouthWestPref.Value != null)
            {
                SouthWest = Melon_Loader_Mod5.PreferencesCreator.SouthWestPref.Value;
            }
            else
            {
                SouthWest = SouthWestDefult;
            }

            if (Melon_Loader_Mod5.PreferencesCreator.WestPref.Value != null)
            {
                West = Melon_Loader_Mod5.PreferencesCreator.WestPref.Value;
            }
            else
            {
                West = WestDefult;
            }

            if (Melon_Loader_Mod5.PreferencesCreator.NorthWestPref.Value != null)
            {
                NorthWest = Melon_Loader_Mod5.PreferencesCreator.NorthWestPref.Value;
            }
            else
            {
                NorthWest = NorthWestDefult;
            }

            if (Melon_Loader_Mod5.PreferencesCreator.MiddlePref.Value != null)
            {
                Middle = Melon_Loader_Mod5.PreferencesCreator.MiddlePref.Value;
            }
            else
            {
                Middle = MiddleDefult;
            }

        }
    }

}


