using Il2CppTMPro;
using UnityEngine;

namespace Melon_Loader_Mod5
{
    public class RadialMenuTextAndImageUI
    {
        public static void RadialMenuTextAndImage(Transform parent) //honestly one of the worst things ive ever written but dont know how else to do this
        {


            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);





                UnityEngine.UI.Image imageComponent = child.GetComponent<UnityEngine.UI.Image>();
                TextMeshProUGUI textComponent = child.GetComponent<TextMeshProUGUI>();


                if (child.name == "text_Information")
                {
                    continue;
                }
                if (PreferencesCreator.IsEnabled)
                {



                    if (imageComponent != null && (i == 0 || i == 1))
                    {
                        imageComponent.color = Colors.North;
                    }
                    else if (textComponent != null && (i == 0 || i == 1))
                    {
                        textComponent.color = Colors.North;
                    }

                    else if (imageComponent != null && (i == 3 || i == 4))
                    {
                        imageComponent.color = Colors.NorthEast;
                    }
                    else if (textComponent != null && (i == 3 || i == 4))
                    {
                        textComponent.color = Colors.NorthEast;
                    }

                    else if (imageComponent != null && (i == 6 || i == 7))
                    {
                        imageComponent.color = Colors.East;
                    }
                    else if (textComponent != null && (i == 6 || i == 7))
                    {
                        textComponent.color = Colors.East;
                    }

                    else if (imageComponent != null && (i == 9 || i == 10))
                    {
                        imageComponent.color = Colors.SouthEast;
                    }
                    else if (textComponent != null && (i == 9 || i == 10))
                    {
                        textComponent.color = Colors.SouthEast;
                    }

                    else if (imageComponent != null && (i == 12 || i == 13))
                    {
                        imageComponent.color = Colors.South;
                    }
                    else if (textComponent != null && (i == 12 || i == 13))
                    {
                        textComponent.color = Colors.South;
                    }

                    else if (imageComponent != null && (i == 15 || i == 16))
                    {
                        imageComponent.color = Colors.SouthWest;
                    }
                    else if (textComponent != null && (i == 15 || i == 16))
                    {
                        textComponent.color = Colors.SouthWest;
                    }

                    else if (imageComponent != null && (i == 18 || i == 19))
                    {
                        imageComponent.color = Colors.West;
                    }
                    else if (textComponent != null && (i == 18 || i == 19))
                    {
                        textComponent.color = Colors.West;
                    }

                    else if (imageComponent != null && (i == 21 || i == 22))
                    {
                        imageComponent.color = Colors.NorthWest;
                    }
                    else if (textComponent != null && (i == 21 || i == 22))
                    {
                        textComponent.color = Colors.NorthWest;
                    }
                }
                else
                {
                    if (imageComponent != null)
                    {
                        imageComponent.color = Color.white;
                    }
                    else if (textComponent != null)
                    {
                        textComponent.color = Color.white;
                    }
                }

                RadialMenuTextAndImage(child);
            }
        }
    }
}
