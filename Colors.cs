using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
// Colors Colors = new Colors();
namespace Melon_Loader_Mod5
{
    public class Colors
    {
        PreferencesCreator Preferences = new PreferencesCreator();

        public Color North = new Color(0f, 1f, 1f, 1f);

        public Color NorthEast = new Color(1f, 0.5f, 0f, 1f); //level

        public Color East = new Color(1f, 1f, 0f, 1f); //prefrances

        public Color SouthEast = new Color(0f, 0f, 1f, 1f); //quick unmute

        public Color South = new Color(1f, 0f, 1f, 1f); //inventory

        public Color SouthWest = new Color(0.5f, 0f, 1f, 1f); //devtools

        public Color West = new Color(1f, 0f, 0f, 1f); //spawngun 

        public Color NorthWest = new Color(0f, 1f, 0f, 1f); //avatar

        //defults 
        public Color NorthDefult = new Color(0f, 1f, 1f, 1f); //eject

        public Color NorthEastDefult = new Color(1f, 0.5f, 0f, 1f); //level

        public Color EastDefult = new Color(1f, 1f, 0f, 1f); //prefrances

        public Color SouthEastDefult = new Color(0f, 0f, 1f, 1f); //quick unmute

        public Color SouthDefult = new Color(1f, 0f, 1f, 1f); //inventory

        public Color SouthWestDefult = new Color(0.5f, 0f, 1f, 1f); //devtools

        public Color WestDefult = new Color(1f, 0f, 0f, 1f); //spawngun 

        public Color NorthWestDefult = new Color(0f, 1f, 0f, 1f); //avatar

        public void ColorAssignment()
        {
            if (Preferences.NorthPref.Value != null)
            {
                North = Preferences.NorthPref.Value;
            }
            else
            {
                North = NorthDefult;
            }

            if (Preferences.NorthEastPref.Value != null)
            {
                NorthEast = Preferences.NorthEastPref.Value;
            }
            else
            {
                NorthEast = NorthEastDefult;
            }

            if (Preferences.EastPref.Value != null)
            {
                East = Preferences.EastPref.Value;
            }
            else
            {
                East = EastDefult;
            }

            if (Preferences.SouthEastPref.Value != null)
            {
                SouthEast = Preferences.SouthEastPref.Value;
            }
            else
            {
                SouthEast = SouthEastDefult;
            }

            if (Preferences.SouthPref.Value != null)
            {
                South = Preferences.SouthPref.Value;
            }
            else
            {
                South = SouthDefult;
            }

            if (Preferences.SouthWestPref.Value != null)
            {
                SouthWest = Preferences.SouthWestPref.Value;
            }
            else
            {
                SouthWest = SouthWestDefult;
            }

            if (Preferences.WestPref.Value != null)
            {
                West = Preferences.WestPref.Value;
            }
            else
            {
                West = WestDefult;
            }

            if (Preferences.NorthWestPref.Value != null)
            {
                NorthWest = Preferences.NorthWestPref.Value;
            }
            else
            {
                NorthWest = NorthWestDefult;
            }

        }
    }

}


