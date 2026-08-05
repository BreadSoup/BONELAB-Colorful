using System;
using UnityEngine;
using Il2CppTMPro;
using Il2CppSLZ.Bonelab;

namespace Colorful
{
    public class InventorySlotsUI //I don't remember if this was in the old version or not but either way it's here now!
    {
        static Color color;

        public static void Slots(Transform inventorySlots)
        {
            if (PreferencesCreator.IsEnabled)
            {
                color = Colors.South;
            }
            else
            {
                color = Color.white;
            }

            foreach (var view in inventorySlots.GetComponentsInChildren<PageElementView>(true))
            {
                view.color2 = color;
            }
        }

        public static void AmmoHud(Transform hudAmmo)
        {
            if (PreferencesCreator.IsEnabled)
            {
                color = Colors.South;
            }
            else
            {
                color = Color.white;
            }

            foreach (var text in hudAmmo.GetComponentsInChildren<TextMeshPro>(true))
            {
                if (text.gameObject.name.StartsWith("val_ammo"))
                {
                    text.color = color;
                }
            }

            foreach (var sprite in hudAmmo.GetComponentsInChildren<SpriteRenderer>(true))
            {
                string name = sprite.gameObject.name;
                if (name.StartsWith("img_ammo") || name == "sprite_outline")
                {
                    if (PreferencesCreator.IsEnabled)
                    {
                        sprite.color = Colors.South;
                    }
                    else
                    {
                        sprite.color = Color.white;
                    }
                }
            }
        }
    }
}
