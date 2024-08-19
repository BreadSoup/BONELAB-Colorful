using Il2CppTMPro;
using UnityEngine;
namespace Melon_Loader_Mod5
{
    public class AvatarSelectUI
    {
        static Color color;
        public static void Avatar(Transform parent, bool isSecondChild)
        {
            if (PreferencesCreator.IsEnabled)
            {
                color = Colors.NorthWest;
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

                UnityEngine.UI.Image imageComponent = child.GetComponent<UnityEngine.UI.Image>();
                TextMeshProUGUI textComponent = child.GetComponent<TextMeshProUGUI>();
                TextMeshPro bodyMallTextComponent = child.GetComponent<TextMeshPro>();

                if (child.name == "img_outline")
                {
                    continue;
                }
                else if (child.name == "img_bg")
                {
                    continue;
                }


                if (imageComponent != null)
                {
                    imageComponent.color = color;
                }
                else if (textComponent != null)
                {
                    textComponent.color = color;
                }
                else if (bodyMallTextComponent != null)
                {
                    bodyMallTextComponent.color = color;
                }

                Avatar(child, isSecondChild: false);
            }
        }
        public static void Bodymall(Transform parent)
        {
            if (PreferencesCreator.IsEnabled)
            {
                color = Colors.NorthWest;
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
                TextMeshPro bodyMallTextComponent = child.GetComponent<TextMeshPro>();


                if (child.name == "img_outline")
                {
                    continue;
                }
                else if (child.name == "img_bg")
                {
                    continue;
                }
                else if (child.name.Contains("image_backline"))
                {
                    continue;
                }
                else if (child.name == "Chart")
                {
                    Renderer renderer = child.GetComponent<Renderer>();
                    Material uniqueMaterial = renderer.material;
                    uniqueMaterial.color = color;
                }



                if (imageComponent != null)
                {
                    imageComponent.color = color;
                }
                else if (textComponent != null)
                {
                    textComponent.color = color;
                }
                else if (bodyMallTextComponent != null)
                {
                    bodyMallTextComponent.color = color;
                }

                Bodymall(child);
            }
        }
    }
}

