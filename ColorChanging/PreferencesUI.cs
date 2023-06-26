using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Melon_Loader_Mod5
{
    public class PreferencesUI
    {
        Colors Colors = new Colors();
        public void Preferences(Transform parent, bool isSecondChild)
        {
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);

                if (isSecondChild && i == 1)
                    continue;

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

                if (imageComponent != null)
                {
                    imageComponent.color = Colors.East;
                }
                else if (textComponent != null)
                {
                    textComponent.color = Colors.East;
                }
                else if (bonemenuimageComponent != null)
                {
                    bonemenuimageComponent.color = Colors.East;
                }
                else if (bonemenutextComponent != null)
                {
                    bonemenutextComponent.color = Colors.East;
                }
                else if (literallyASinglecharacter != null)
                {
                    literallyASinglecharacter.color = Colors.East;
                }

                Preferences(child, isSecondChild: false);
            }
        }
        public void Extra(Transform parent)
        {
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);

                UnityEngine.UI.Image imageComponent = child.GetComponent<UnityEngine.UI.Image>();
                TextMeshProUGUI textComponent = child.GetComponent<TextMeshProUGUI>();

                if (imageComponent != null)
                {
                    imageComponent.color = Colors.East;
                }
                else if (textComponent != null)
                {
                    textComponent.color = Colors.East;
                }

                Extra(child);
            }
        }
    }
}
