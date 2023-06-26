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
    Colors Colors = new Colors();

    SLZ.UI.PageItemView N;
    SLZ.UI.PageItemView NE;
    SLZ.UI.PageItemView E;
    SLZ.UI.PageItemView SE;
    SLZ.UI.PageItemView S;
    SLZ.UI.PageItemView SW;
    SLZ.UI.PageItemView W;
    SLZ.UI.PageItemView NW;
        public void RadialMenuButtons() //is there a better way to do this? probably but i dont know it
        {
            if (N == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_N"); //eject
                N = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (N != null)
            {
                N.color2 = Colors.North;
            }

            if (NE == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_NE"); //Level
                NE = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (NE != null)
            {
                NE.color2 = Colors.NorthEast;
            }

            if (E == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_E"); //Pref
                E = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (E != null)
            {
                E.color2 = Colors.East;
            }

            if (SE == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_SE"); //Quick Unmute
                SE = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (SE != null)
            {
                SE.color2 = Colors.SouthEast;
            }

            if (S == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_S"); //inv
                S = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (S != null)
            {
                S.color2 = Colors.South;
            }

            if (SW == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_SW"); //inv
                SW = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (SW != null)
            {
                SW.color2 = Colors.SouthWest;
            }

            if (W == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_W"); //inv
                W = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (W != null)
            {
                W.color2 = Colors.West;
            }

            if (NW == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_NW"); //inv
                NW = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (NW != null)
            {
                NW.color2 = Colors.NorthWest;
            }
        }

    }
}
