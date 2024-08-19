using Il2CppTMPro;
using UnityEngine;
namespace Melon_Loader_Mod5
{
    public class SpawnGunUI
    {
        static Color color;
        public static void SpawnGun(Transform parent, bool isFourthChild)
        {
            if (PreferencesCreator.IsEnabled)
            {
                color = Colors.West;
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
                TextMeshPro spawnGuntextComponent = child.GetComponent<TextMeshPro>(); // for some reason spawn gun uses this idk why dont care

                if (child.name == "Background")
                {
                    continue;
                }
                else if (child.name == "image_backline" && child.parent.gameObject.name == "group_selectedInfo")
                {
                    continue;
                }
                else if (isFourthChild && i == 3)
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
                else if (spawnGuntextComponent != null)
                {
                    spawnGuntextComponent.color = color;
                }

                SpawnGun(child, isFourthChild: false);
            }
        }
    }

}
