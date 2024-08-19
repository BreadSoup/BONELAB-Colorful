using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Melon_Loader_Mod5
{
    public class PreferencesUI
    {
        static Color color;

        public static void Preferences(Transform parent, bool isSecondChild)
        {
            if (PreferencesCreator.IsEnabled)
            {
                color = Colors.East;
            }
            else
            {
                color = Color.white;
            }
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);

                if (isSecondChild && i == 1)
                    continue;

                Color color;

                UnityEngine.UI.Image imageComponent = child.GetComponent<UnityEngine.UI.Image>();
                TextMeshProUGUI textComponent = child.GetComponent<TextMeshProUGUI>();
                RawImage bonemenuimageComponent = child.GetComponent<RawImage>(); //for some reason bonemenu's image is a raw image???? dont know why so im just going to work around it
                TextMeshPro bonemenutextComponent = child.GetComponent<TextMeshPro>();
                Text literallyASinglecharacter = child.GetComponent<Text>(); //the only reason i need this is because of the / in height settings why is it not the same???????????????????


                if (child.name == "Viewport_Spectator")
                {
                    continue;
                }
                else if (child.name == "Viewport_Graphics")
                {
                    continue;
                }
                else if (child.name == "Viewport")
                {
                    continue;
                }
                else if (child.name == "Name")
                {
                    continue;
                }

                if (PreferencesCreator.IsEnabled)
                {
                     color = Colors.East;
                }
                else
                {
                     color = Color.white;
                }

                if (imageComponent != null)
                {
                    imageComponent.color = color;
                }
                else if (textComponent != null)
                {
                    textComponent.color = color;
                }
                else if (bonemenuimageComponent != null)
                {
                    bonemenuimageComponent.color = color;
                }
                else if (bonemenutextComponent != null)
                {
                    bonemenutextComponent.color = color;
                }
                else if (literallyASinglecharacter != null)
                {
                    literallyASinglecharacter.color = color;
                }

                Preferences(child, isSecondChild: false);
            }
        }
        public static void Extra(Transform parent)
        {
            if (PreferencesCreator.IsEnabled)
            {
                color = Colors.East;
            }
            else
            {
                color = Color.white;
            }
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);

                UnityEngine.UI.Image imageComponent = child.GetComponent<UnityEngine.UI.Image>();
                TextMeshProUGUI textComponent = child.GetComponent<TextMeshProUGUI>();

                if (imageComponent != null)
                {
                    imageComponent.color = color;
                }
                else if (textComponent != null)
                {
                    textComponent.color = color;
                }

                Extra(child);
            }
        }
    }
}
