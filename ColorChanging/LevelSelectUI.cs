using Il2CppTMPro;
using UnityEngine;

namespace Melon_Loader_Mod5
{
    public class LevelSelectUI
    {
        static Color color;
        public static void LevelSelect(Transform parent, bool isSecondChild)
        {
            if (PreferencesCreator.IsEnabled)
            {
                color = Colors.NorthEast;
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

                if (imageComponent != null)
                {
                    imageComponent.color = color;
                }
                else if (textComponent != null)
                {
                    textComponent.color = color;
                }

                LevelSelect(child, isSecondChild: false);
            }
        }
    }
}
