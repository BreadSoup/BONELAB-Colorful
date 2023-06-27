using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Melon_Loader_Mod5
{
    public class RadialMenuButtonsUI
    {

        static SLZ.UI.PageItemView N;
        static SLZ.UI.PageItemView NE;
        static SLZ.UI.PageItemView E;
        static SLZ.UI.PageItemView SE;
        static SLZ.UI.PageItemView S;
        static SLZ.UI.PageItemView SW;
        static SLZ.UI.PageItemView W;
        static SLZ.UI.PageItemView NW;
        static SLZ.UI.PageElementView M;
        public static void RadialMenuButtons() //is there a better way to do this? probably but i dont know it
        {
            if (N == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_N"); //eject
                N = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (N != null && PreferencesCreator.IsEnabled)
            {
                N.color2 = Colors.North;
            }
            else
            {
                N.color2 = Color.white;
            }

            if (NE == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_NE"); //Level
                NE = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (NE != null && PreferencesCreator.IsEnabled)
            {
                NE.color2 = Colors.NorthEast;
            }
            else
            {
                NE.color2 = Color.white;
            }

            if (E == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_E"); //Pref
                E = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (E != null && PreferencesCreator.IsEnabled)
            {
                E.color2 = Colors.East;
            }
            else
            {
                E.color2 = Color.white;
            }

            if (SE == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_SE"); //Quick Unmute
                SE = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (SE != null && PreferencesCreator.IsEnabled)
            {
                SE.color2 = Colors.SouthEast;
            }
            else
            {
                SE.color2 = Color.white;
            }

            if (S == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_S"); //inv
                S = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (S != null && PreferencesCreator.IsEnabled)
            {
                S.color2 = Colors.South;
            }
            else
            {
                S.color2 = Color.white;
            }

            if (SW == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_SW"); //inv
                SW = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (SW != null && PreferencesCreator.IsEnabled)
            {
                SW.color2 = Colors.SouthWest;
            }
            else
            {
                SW.color2 = Color.white;
            }

            if (W == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_W"); //inv
                W = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (W != null && PreferencesCreator.IsEnabled)
            {
                W.color2 = Colors.West;
            }
            else
            {
                W.color2 = Color.white;
            }

            if (NW == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_NW"); //inv
                NW = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (NW != null && PreferencesCreator.IsEnabled)
            {
                NW.color2 = Colors.NorthWest;
            }
            else
            {
                NW.color2 = Color.white;
            }

            if (M == null)
            {
                GameObject button_Region_M = GameObject.Find("button_cancel"); //cancel
                M = button_Region_M.GetComponent<SLZ.UI.PageElementView>();
            }
            if (M != null && PreferencesCreator.IsEnabled)
            {
                M.color2 = Colors.Middle;
            }
            else
            {
                Color cancel = new Color(1f, 0.2667f, 0.4824f, 0.749f);
                M.color2 = cancel;
            }

        }
    }
}
