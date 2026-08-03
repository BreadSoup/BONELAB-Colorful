using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Il2CppSLZ.Bonelab;
namespace Colorful
{
    public class RadialMenuButtonsUI
    {
        public static void RadialMenuButtons() //is there a better way to do this? probably but i dont know it
        {
            bool enabled = PreferencesCreator.IsEnabled;

            // include-inactive search: the radial popup is inactive while the menu is closed,
            // so GameObject.Find (active-only) never sees these buttons.
            foreach (var view in GameObject.FindObjectsOfType<PageItemView>(true))
            {
                switch (view.gameObject.name)
                {
                    case "button_Region_N":  view.color2 = enabled ? Colors.North     : Color.white; break; //eject
                    case "button_Region_NE": view.color2 = enabled ? Colors.NorthEast : Color.white; break; //Level
                    case "button_Region_E":  view.color2 = enabled ? Colors.East      : Color.white; break; //Pref
                    case "button_Region_SE": view.color2 = enabled ? Colors.SouthEast : Color.white; break; //Quick Unmute
                    case "button_Region_S":  view.color2 = enabled ? Colors.South     : Color.white; break; //inv
                    case "button_Region_SW": view.color2 = enabled ? Colors.SouthWest : Color.white; break; //devtools
                    case "button_Region_W":  view.color2 = enabled ? Colors.West      : Color.white; break; //spawngun
                    case "button_Region_NW": view.color2 = enabled ? Colors.NorthWest : Color.white; break; //avatar
                }
            }

            Color cancelDefault = new Color(1f, 0.2667f, 0.4824f, 0.749f);
            foreach (var view in GameObject.FindObjectsOfType<PageElementView>(true))
            {
                if (view.gameObject.name == "button_cancel") //cancel
                {
                    view.color2 = enabled ? Colors.Middle : cancelDefault;
                }
            }
        }
    }
}
