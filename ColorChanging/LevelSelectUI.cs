using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace Melon_Loader_Mod5
{
    public class LevelSelectUI
    {
        Colors Colors = new Colors();
        public void LevelSelect(Transform parent, bool isSecondChild)
        {
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);

                if (isSecondChild && i == 1)
                    continue;

                UnityEngine.UI.Image imageComponent = child.GetComponent<UnityEngine.UI.Image>();
                TextMeshProUGUI textComponent = child.GetComponent<TextMeshProUGUI>();

                if (imageComponent != null)
                {
                    imageComponent.color = Colors.NorthEast;
                }
                else if (textComponent != null)
                {
                    textComponent.color = Colors.NorthEast;
                }

                LevelSelect(child, isSecondChild: false);
            }
        }
    }
}
