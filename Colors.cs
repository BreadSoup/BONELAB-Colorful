using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
// Colors Colors = new Colors();
namespace Colorful
{
    public class Colors
    {

        public static UnityEngine.Color North = new UnityEngine.Color(0f, 1f, 1f, 1f);

        public static UnityEngine.Color NorthEast = new UnityEngine.Color(1f, 0.5f, 0f, 1f); //level

        public static UnityEngine.Color East = new UnityEngine.Color(1f, 1f, 0f, 1f); //prefrances

        public static UnityEngine.Color SouthEast = new UnityEngine.Color(0f, 0f, 1f, 1f); //quick unmute

        public static UnityEngine.Color South = new UnityEngine.Color(1f, 0f, 1f, 1f); //inventory

        public static UnityEngine.Color SouthWest = new UnityEngine.Color(0.5f, 0f, 1f, 1f); //devtools

        public static UnityEngine.Color West = new UnityEngine.Color(1f, 0f, 0f, 1f); //spawngun

        public static UnityEngine.Color NorthWest = new UnityEngine.Color(0f, 1f, 0f, 1f); //avatar

        public static UnityEngine.Color Middle = new UnityEngine.Color(1f, 0.2f, 0.2f, 0.7f); //cancel

        //defults
        //I know I spelled default wrong but it doesnt matter
        public static UnityEngine.Color NorthDefult = new UnityEngine.Color(0f, 1f, 1f, 1f); //eject

        public static UnityEngine.Color NorthEastDefult = new UnityEngine.Color(1f, 0.5f, 0f, 1f); //level

        public static UnityEngine.Color EastDefult = new UnityEngine.Color(1f, 1f, 0f, 1f); //prefrances

        public static UnityEngine.Color SouthEastDefult = new UnityEngine.Color(0f, 0f, 1f, 1f); //quick unmute

        public static UnityEngine.Color SouthDefult = new UnityEngine.Color(1f, 0f, 1f, 1f); //inventory

        public static UnityEngine.Color SouthWestDefult = new UnityEngine.Color(0.5f, 0f, 1f, 1f); //devtools

        public static UnityEngine.Color WestDefult = new UnityEngine.Color(1f, 0f, 0f, 1f); //spawngun

        public static UnityEngine.Color NorthWestDefult = new UnityEngine.Color(0f, 1f, 0f, 1f); //avatar

        public static UnityEngine.Color MiddleDefult = new UnityEngine.Color(1f, 0.2f, 0.2f, 1f); //cancel

        public static void ColorAssignment()
        {
            if (PreferencesCreator.NorthPref != null)
            {
                North = PreferencesCreator.NorthPref.Value;
            }
            else
            {
                North = NorthDefult;
            }

            if (PreferencesCreator.NorthEastPref.Value != null)
            {
                NorthEast = PreferencesCreator.NorthEastPref.Value;
            }
            else
            {
                NorthEast = NorthEastDefult;
            }

            if (PreferencesCreator.EastPref.Value != null)
            {
                East = PreferencesCreator.EastPref.Value;
            }
            else
            {
                East = EastDefult;
            }

            if (PreferencesCreator.SouthEastPref.Value != null)
            {
                SouthEast = PreferencesCreator.SouthEastPref.Value;
            }
            else
            {
                SouthEast = SouthEastDefult;
            }

            if (PreferencesCreator.SouthPref.Value != null)
            {
                South = PreferencesCreator.SouthPref.Value;
            }
            else
            {
                South = SouthDefult;
            }

            if (PreferencesCreator.SouthWestPref.Value != null)
            {
                SouthWest = PreferencesCreator.SouthWestPref.Value;
            }
            else
            {
                SouthWest = SouthWestDefult;
            }

            if (PreferencesCreator.WestPref.Value != null)
            {
                West = PreferencesCreator.WestPref.Value;
            }
            else
            {
                West = WestDefult;
            }

            if (PreferencesCreator.NorthWestPref.Value != null)
            {
                NorthWest = PreferencesCreator.NorthWestPref.Value;
            }
            else
            {
                NorthWest = NorthWestDefult;
            }

            if (PreferencesCreator.MiddlePref.Value != null)
            {
                Middle = PreferencesCreator.MiddlePref.Value;
            }
            else
            {
                Middle = MiddleDefult;
            }

        }
    }

}

