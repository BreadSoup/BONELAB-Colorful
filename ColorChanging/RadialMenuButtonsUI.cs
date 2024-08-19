using Il2CppSLZ.Bonelab;
using UnityEngine;
namespace Melon_Loader_Mod5
{
    public class RadialMenuButtonsUI
    {

        static PageItemView N;
        static PageItemView NE;
        static PageItemView E;
        static PageItemView SE;
        static PageItemView S;
        static PageItemView SW;
        static PageItemView W;
        static PageItemView NW;
        static PageElementView M;
        public static void RadialMenuButtons() //is there a better way to do this? probably but i dont know it
        {
            if (N == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_N"); //eject
                if (button_Region_N != null) N = button_Region_N.GetComponent<PageItemView>();
            }
            if (N != null)
            {
                N.color2 = PreferencesCreator.IsEnabled ? Colors.North : Color.white;
            }

            if (NE == null)
            {
                GameObject button_Region_NE = GameObject.Find("button_Region_NE"); //Level
                if (button_Region_NE != null) NE = button_Region_NE.GetComponent<PageItemView>();
            }
            if (NE != null)
            {
                NE.color2 = PreferencesCreator.IsEnabled ? Colors.NorthEast : Color.white;
            }

            if (E == null)
            {
                GameObject button_Region_E = GameObject.Find("button_Region_E"); //Pref
                if (button_Region_E != null) E = button_Region_E.GetComponent<PageItemView>();
            }
            if (E != null)
            {
                E.color2 = PreferencesCreator.IsEnabled ? Colors.East : Color.white;
            }

            if (SE == null)
            {
                GameObject button_Region_SE = GameObject.Find("button_Region_SE"); //Quick Unmute
                if (button_Region_SE != null) SE = button_Region_SE.GetComponent<PageItemView>();
            }
            if (SE != null)
            {
                SE.color2 = PreferencesCreator.IsEnabled ? Colors.SouthEast : Color.white;
            }

            if (S == null)
            {
                GameObject button_Region_S = GameObject.Find("button_Region_S"); //inv
                if (button_Region_S != null) S = button_Region_S.GetComponent<PageItemView>();
            }
            if (S != null)
            {
                S.color2 = PreferencesCreator.IsEnabled ? Colors.South : Color.white;
            }

            if (SW == null)
            {
                GameObject button_Region_SW = GameObject.Find("button_Region_SW"); //inv
                if (button_Region_SW != null) SW = button_Region_SW.GetComponent<PageItemView>();
            }
            if (SW != null)
            {
                SW.color2 = PreferencesCreator.IsEnabled ? Colors.SouthWest : Color.white;
            }

            if (W == null)
            {
                GameObject button_Region_W = GameObject.Find("button_Region_W"); //inv
                if (button_Region_W != null) W = button_Region_W.GetComponent<PageItemView>();
            }
            if (W != null)
            {
                W.color2 = PreferencesCreator.IsEnabled ? Colors.West : Color.white;
            }

            if (NW == null)
            {
                GameObject button_Region_NW = GameObject.Find("button_Region_NW"); //inv
                if (button_Region_NW != null) NW = button_Region_NW.GetComponent<PageItemView>();
            }
            if (NW != null)
            {
                NW.color2 = PreferencesCreator.IsEnabled ? Colors.NorthWest : Color.white;
            }

            if (M == null)
            {
                GameObject button_Region_M = GameObject.Find("button_cancel"); //cancel
                if (button_Region_M != null) M = button_Region_M.GetComponent<PageElementView>();
            }
            if (M != null)
            {
                M.color2 = PreferencesCreator.IsEnabled ? Colors.Middle : new(1f, 0.2667f, 0.4824f, 0.749f);
            }

        }
    }
}
