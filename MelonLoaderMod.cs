using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using BoneLib.BoneMenu;
using System;
using BoneLib.BoneMenu.Elements;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using BoneLib;
using SLZ.VRMK;
using System.Security.Policy;
using System.Collections.Generic;


namespace Melon_Loader_Mod5
{
    public static class BuildInfo
    {
        public const string Name = "Colorful";
        public const string Author = "Bread Soup";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
    }

    public class Melon_Loader_Mod5 : MelonMod
    {


        Color North = new Color(0f, 1f, 1f, 1f);

        Color NorthEast = new Color(1f, 0.5f, 0f, 1f); //level

        Color East = new Color(1f, 1f, 0f, 1f); //prefrances

        Color SouthEast = new Color(0f, 0f, 1f, 1f); //quick unmute

        Color South = new Color(1f, 0f, 1f, 1f); //inventory

        Color SouthWest = new Color(0.5f, 0f, 1f, 1f); //devtools

        Color West = new Color(1f, 0f, 0f, 1f); //spawngun 

        Color NorthWest = new Color(0f, 1f, 0f, 1f); //avatar

        //defults 
        Color NorthDefult = new Color(0f, 1f, 1f, 1f); //eject

        Color NorthEastDefult = new Color(1f, 0.5f, 0f, 1f); //level

        Color EastDefult = new Color(1f, 1f, 0f, 1f); //prefrances

        Color SouthEastDefult = new Color(0f, 0f, 1f, 1f); //quick unmute

        Color SouthDefult = new Color(1f, 0f, 1f, 1f); //inventory

        Color SouthWestDefult = new Color(0.5f, 0f, 1f, 1f); //devtools

        Color WestDefult = new Color(1f, 0f, 0f, 1f); //spawngun 

        Color NorthWestDefult = new Color(0f, 1f, 0f, 1f); //avatar

        private void OnSceneAwake()
        {
            if (IsEnabled)
            {
                MoggingTime();
            }
            RadialMenuButtons();
        }
        public override void OnInitializeMelon()
        {
            BoneLib.Hooking.OnLevelInitialized += (_) => { OnSceneAwake(); }; //Fusion is under MIT licencse so pretty sure as long as I cWestit it I'll be fine

            MelonPreferencesCreator();
            BonemenuCreator();
            
           
        }
        
        public void ColorAssignment()
        {
            if (NorthPref.Value != null)
            {
                North = NorthPref.Value;
            }
            else
            {
                North = NorthDefult;
            }

            if (NorthEastPref.Value != null)
            {
                NorthEast = NorthEastPref.Value;
            }
            else
            {
                NorthEast = NorthEastDefult;
            }

            if (EastPref.Value != null)
            {
                East = EastPref.Value;
            }
            else
            {
                East = EastDefult;
            }

            if (SouthEastPref.Value != null)
            {
                SouthEast = SouthEastPref.Value;
            }
            else
            {
                SouthEast = SouthEastDefult;
            }

            if (SouthPref.Value != null)
            {
                South = SouthPref.Value;
            }
            else
            {
                South = SouthDefult;
            }

            if (SouthWestPref.Value != null)
            {
                SouthWest = SouthWestPref.Value;
            }
            else
            {
                SouthWest = SouthWestDefult;
            }

            if (WestPref.Value != null)
            {
                West = WestPref.Value;
            }
            else
            {
                West = WestDefult;
            }

            if (NorthWestPref.Value != null)
            {
                NorthWest = NorthWestPref.Value;
            }
            else
            {
                NorthWest = NorthWestDefult;
            }

        }

        public void MelonPreferencesCreator() 
        {
            MelonPrefCategory = MelonPreferences.CreateCategory("Colorful");
            MelonPrefEnabled = MelonPrefCategory.CreateEntry<bool>("IsEnabled", true, null, null, false, false, null, null);
            IsEnabled = MelonPrefEnabled.Value;
            NorthPref = MelonPrefCategory.CreateEntry<Color>("Eject Color", NorthDefult, null, null, false);
            NorthEastPref = MelonPrefCategory.CreateEntry<Color>("Level Select Color", NorthEastDefult, null, null, false);
            EastPref = MelonPrefCategory.CreateEntry<Color>("Preferences Color", EastDefult, null, null, false);
            SouthEastPref = MelonPrefCategory.CreateEntry<Color>("Quick Mute Color", SouthEastDefult, null, null, false);
            SouthPref = MelonPrefCategory.CreateEntry<Color>("Inventory Color", SouthDefult, null, null, false);
            SouthWestPref = MelonPrefCategory.CreateEntry<Color>("Spawn Devtools Color", SouthWestDefult, null, null, false);
            WestPref = MelonPrefCategory.CreateEntry<Color>("SpawnGun Menu Color", WestDefult, null, null, false);
            NorthWestPref = MelonPrefCategory.CreateEntry<Color>("Avatar Select Color", NorthWestDefult, null, null, false);
        }

        

        public void BonemenuCreator()
        {


            string NorthHexcode = ColorUtility.ToHtmlStringRGBA(North);
            string NorthEastHexcode = ColorUtility.ToHtmlStringRGBA(NorthEast);
            string EastHexcode = ColorUtility.ToHtmlStringRGBA(East);
            string SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(SouthEast);
            string SouthHexcode = ColorUtility.ToHtmlStringRGBA(South);
            string SouthWestHexcode = ColorUtility.ToHtmlStringRGBA(SouthWest);
            string WestHexcode = ColorUtility.ToHtmlStringRGBA(West);
            string NorthWestHexcode = ColorUtility.ToHtmlStringRGBA(NorthWest);

            string SuperLongName =
                "<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>";

            var category = MenuManager.CreateCategory(SuperLongName, Color.white);
            
            category.CreateBoolElement("Mod Toggle", Color.yellow, IsEnabled, new Action<bool>(OnSetEnabled));
            //if I could shorten these I would but I can't 
            var NorthButton = category.CreateCategory("Eject", North);
            ColorfulMenuCreator(NorthButton, North, (updatedColor) =>
            {
                North = updatedColor;
                NorthButton.SetColor(updatedColor);
                NorthHexcode = ColorUtility.ToHtmlStringRGBA(updatedColor);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                NorthPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();


            });
            var NorthEastButton = category.CreateCategory("Level Select", NorthEast);
            ColorfulMenuCreator(NorthEastButton, NorthEast, (updatedColor) =>
            {
                NorthEast = updatedColor;
                NorthEastButton.SetColor(updatedColor);
                NorthEastHexcode = ColorUtility.ToHtmlStringRGBA(NorthEast);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                NorthEastPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var EastButton = category.CreateCategory("Preferences", East);
            ColorfulMenuCreator(EastButton, East, (updatedColor) =>
            {
                East = updatedColor;
                EastButton.SetColor(updatedColor);
                EastHexcode = ColorUtility.ToHtmlStringRGBA(East);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                EastPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var SouthEastButton = category.CreateCategory("Quick Mute", SouthEast);
            ColorfulMenuCreator(SouthEastButton, SouthEast, (updatedColor) =>
            {
                SouthEast = updatedColor;
                SouthEastButton.SetColor(updatedColor);
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(SouthEast);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                SouthEastPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var SouthButton = category.CreateCategory("Inventory", South);
            ColorfulMenuCreator(SouthButton, South, (updatedColor) =>
            {
                South = updatedColor;
                SouthButton.SetColor(updatedColor);
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(South);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                SouthPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var SouthWestButton = category.CreateCategory("Spawn Devtools", SouthWest);
            ColorfulMenuCreator(SouthWestButton, SouthWest, (updatedColor) =>
            {
                SouthWest = updatedColor;
                SouthWestButton.SetColor(updatedColor);
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(SouthWest);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                SouthWestPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var WestButton = category.CreateCategory("SpawnGun Menu", West);
            ColorfulMenuCreator(WestButton, West, (updatedColor) =>
            {
                West = updatedColor;
                WestButton.SetColor(updatedColor);
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(West);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                WestPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
            var NorthWestButton = category.CreateCategory("Avatar Select", NorthWest);
            ColorfulMenuCreator(NorthWestButton, NorthWest, (updatedColor) =>
            {
                NorthWest = updatedColor;
                NorthWestButton.SetColor(updatedColor);
                SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(NorthWest);
                category.SetName("<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>");
                NorthWestPref.Value = updatedColor;
                MelonPrefCategory.SaveToFile();
            });
        }

        

        public void ColorfulMenuCreator(MenuCategory category, Color currentColor, Action<Color> applyCallback)
        {
            float red = currentColor.r;
            float green = currentColor.g;
            float blue = currentColor.b;
            float alpha = currentColor.a;
            var colorPreview = category.CreateFunctionElement("■■■■■■■■■■■", currentColor, null);

            var colorR = category.CreateFloatElement("Red", Color.red, currentColor.r, 0.1f, 0f, 1f, (r) =>
            {
                currentColor.r = r;
                colorPreview.SetColor(currentColor);
            });

            var colorG = category.CreateFloatElement("Green", Color.green, currentColor.g, 0.1f, 0f, 1f, (g) =>
            {
                currentColor.g = g;
                colorPreview.SetColor(currentColor);
            });

            var colorB = category.CreateFloatElement("Blue", Color.blue, currentColor.b, 0.1f, 0f, 1f, (b) =>
            {
                currentColor.b = b;
                colorPreview.SetColor(currentColor);
            });

            var colorA = category.CreateFloatElement("Alpha", Color.black, currentColor.a, 0.1f, 0f, 1f, (a) =>
            {
                currentColor.a = a;
                colorPreview.SetColor(currentColor);
            });

            category.CreateFunctionElement("Apply", Color.white, delegate ()
            {
                applyCallback(currentColor);
                MoggingTime();

            });




        }

        public void OnSetEnabled(bool value) // Some extra stuff for the on enabled button
        {
            IsEnabled = value;
            MelonPrefEnabled.Value = value;
            MelonPrefCategory.SaveToFile();
            if (value)
            {
                MoggingTime();
            }
        }

        public void MoggingTime()
        {
            //I realize I shouldve made these public methods and put them in other files now but whatever
            var objectsWithKeyword = GameObject.FindObjectsOfType<GameObject>(true);
            foreach (GameObject obj in objectsWithKeyword)
            {
                if (obj.name.Contains("group_levelSelect"))
                {
                    LevelSelect(obj.transform, isSecondChild: true);
                }
                else if (obj.name.Contains("panel_Preferences"))
                {
                    Preferences(obj.transform, isSecondChild: true);
                }
                else if (obj.name.Contains("grid_Graphics"))
                {
                    Extra(obj.transform);
                }
                else if (obj.name.Contains("group_toolMenu"))
                {
                    SpawnGun(obj.transform, isFourthChild: true);
                }
                else if (obj.name.Contains("group_AvatarSelect"))
                {
                    Avatar(obj.transform, isSecondChild: true);
                }
                else if (obj.name.Contains("BodyMallController")) 
                {
                    Bodymall(obj.transform); //CHECK OTHER COMMENT DOWN THERE
                }
                else if (obj.name.Contains("CANVAS_RADIALUI"))
                {
                    RadialMenuTextImage(obj.transform);
                }
            }
            RadialMenuButtons();
        }

        

        private void LevelSelect(Transform parent, bool isSecondChild)
        {

            // Iterate through each child object of the parent
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);

                // Skip modifying the desiWest component for the second child if isSecondChild is true
                if (isSecondChild && i == 1)
                    continue;

                // Get the desiWest component from the child (if exists)
                UnityEngine.UI.Image imageComponent = child.GetComponent<UnityEngine.UI.Image>();
                TextMeshProUGUI textComponent = child.GetComponent<TextMeshProUGUI>();

                if (imageComponent != null)
                {
                    // Change the desiWest property value for the child object
                    imageComponent.color = NorthEast;
                }
                else if (textComponent != null)
                {
                    textComponent.color = NorthEast;
                }


                // Recursively call the method to modify components in nested children
                LevelSelect(child, isSecondChild: false);
            }
        }
        private void Preferences(Transform parent, bool isSecondChild)
        {


            // Iterate through each child object of the parent
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);

                // Skip modifying the desiWest component for the second child if isSecondChild is true
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
                    imageComponent.color = East;
                }
                else if (textComponent != null)
                {
                    textComponent.color = East;
                }
                else if (bonemenuimageComponent != null)
                {
                    bonemenuimageComponent.color = East;
                }
                else if (bonemenutextComponent != null)
                {
                    bonemenutextComponent.color = East;
                }
                else if (literallyASinglecharacter != null)
                {
                    literallyASinglecharacter.color = East;
                }
                // Recursively call the method to modify components in nested children
                Preferences(child, isSecondChild: false);

            }
        }

        
        private void Extra(Transform parent)
        {


            // Iterate through each child object of the parent
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);
                
                UnityEngine.UI.Image imageComponent = child.GetComponent<UnityEngine.UI.Image>();
                TextMeshProUGUI textComponent = child.GetComponent<TextMeshProUGUI>();

                if (imageComponent != null)
                {
                    imageComponent.color = East;
                }
                else if (textComponent != null)
                {
                    textComponent.color = East;
                }


                // Recursively call the method to modify components in nested children
                Extra(child);
            }
        }
        private void SpawnGun(Transform parent, bool isFourthChild)
        {


            // Iterate through each child object of the parent
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
                    imageComponent.color = West;
                }
                else if (textComponent != null)
                {
                    textComponent.color = West;
                }
                else if (spawnGuntextComponent != null)
                {
                    spawnGuntextComponent.color = West;
                }


                // Recursively call the method to modify components in nested children
                SpawnGun(child, isFourthChild: false);
            }
        }

        private void ExtraSpawn(Transform child)
        {


            // Iterate through each child object of the parent
            for (int i = 0; i < child.childCount; i++)
            {
                Transform child2 = child.GetChild(i);
                Transform parent = child.transform.parent;

                if (parent != null && parent.parent.name != "grid_buttons")
                {
                    continue;
                }

                UnityEngine.UI.Image imageComponent = parent.GetComponent<UnityEngine.UI.Image>();
                TextMeshProUGUI textComponent = parent.GetComponent<TextMeshProUGUI>();

                if (imageComponent != null)
                {
                    imageComponent.color = West;
                }
                else if (textComponent != null)
                {
                    textComponent.color = West;
                }


                // Recursively call the method to modify components in nested children
                ExtraSpawn(child2);
            }
        }

        private void Avatar(Transform parent, bool isSecondChild)
        {




            // Iterate through each child object of the parent
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);

                // Skip modifying the desiWest component for the second child if isSecondChild is true
                if (isSecondChild && i == 1)
                    continue;

                // Get the desiWest component from the child (if exists)
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
                    // Change the desiWest property value for the child object
                    imageComponent.color = NorthWest;
                }
                else if (textComponent != null)
                {
                    textComponent.color = NorthWest;
                }
                else if (bodyMallTextComponent != null)
                {
                    bodyMallTextComponent.color = NorthWest;
                }


                // Recursively call the method to modify components in nested children
                Avatar(child, isSecondChild: false);
            }
        }

        private void Bodymall(Transform parent)
        {

            //"mat_spiderChart (Instance)" material.color is for the spidercahrt on bodymall

            // Iterate through each child object of the parent
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);



                // Get the desiWest component from the child (if exists)
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
                    uniqueMaterial.color = NorthWest;
                }



                if (imageComponent != null)
                {
                    // Change the desiWest property value for the child object
                    imageComponent.color = NorthWest;
                }
                else if (textComponent != null)
                {
                    textComponent.color = NorthWest;
                }
                else if (bodyMallTextComponent != null)
                {
                    bodyMallTextComponent.color = NorthWest;
                }


                // Recursively call the method to modify components in nested children
                Bodymall(child);
            }
        }


        private void RadialMenuTextImage(Transform parent) //honestly one of the worst things ive ever written but dont know how else to do this
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


                if (imageComponent != null && (i == 0 || i == 1)) //done
                {
                    imageComponent.color = North;
                }
                else if (textComponent != null && (i == 0 || i == 1))
                {
                    textComponent.color = North;
                }

                else if (imageComponent != null && (i == 3 || i == 4)) //done
                {
                    imageComponent.color = NorthEast;
                }
                else if (textComponent != null && (i == 3 || i == 4))
                {
                    textComponent.color = NorthEast;
                }

                else if (imageComponent != null && (i == 6 || i == 7)) //done
                {
                    imageComponent.color = East;
                }
                else if (textComponent != null && (i == 6 || i == 7))
                {
                    textComponent.color = East;
                }

                else if (imageComponent != null && (i == 9 || i == 10)) //done
                {
                    imageComponent.color = SouthEast;
                }
                else if (textComponent != null && (i == 9 || i == 10))
                {
                    textComponent.color = SouthEast;
                }

                else if (imageComponent != null && (i == 12 || i == 13)) //done
                {
                    imageComponent.color = South;
                }
                else if (textComponent != null && (i == 12 || i == 13))
                {
                    textComponent.color = South;
                }

                else if (imageComponent != null && (i == 15 || i == 16)) //done
                {
                    imageComponent.color = SouthWest;
                }
                else if (textComponent != null && (i == 15 || i == 16))
                {
                    textComponent.color = SouthWest;
                }

                else if (imageComponent != null && (i == 18 || i == 19)) //done
                {
                    imageComponent.color = West;
                }
                else if (textComponent != null && (i == 18 || i == 19))
                {
                    textComponent.color = West;
                }

                else if (imageComponent != null && (i == 21 || i == 22)) //done
                {
                    imageComponent.color = NorthWest;
                }
                else if (textComponent != null && (i == 21 || i == 22))
                {
                    textComponent.color = NorthWest;
                }



                // Recursively call the method to modify components in nested children
                RadialMenuTextImage(child);
            }
        }

        SLZ.UI.PageItemView N;
        SLZ.UI.PageItemView NE;
        SLZ.UI.PageItemView E;
        SLZ.UI.PageItemView SE;
        SLZ.UI.PageItemView S;
        SLZ.UI.PageItemView SW;
        SLZ.UI.PageItemView W;
        SLZ.UI.PageItemView NW;

        

        private void RadialMenuButtons() //is there a better way to do this? probbobly but i dont know it
        {





            if (N == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_N"); //eject
                N = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (N != null && IsEnabled)
            {
                N.color2 = North;
            }

            if (NE == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_NE"); //Level
                NE = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (NE != null && IsEnabled)
            {
                NE.color2 = NorthEast;
            }

            if (E == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_E"); //Pref
                E = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (E != null && IsEnabled)
            {
                E.color2 = East;
            }

            if (SE == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_SE"); //Quick Unmute
                SE = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (SE != null && IsEnabled)
            {
                SE.color2 = SouthEast;
            }

            if (S == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_S"); //inv
                S = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (S != null && IsEnabled)
            {
                S.color2 = South;
            }

            if (SW == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_SW"); //inv
                SW = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (SW != null && IsEnabled)
            {
                SW.color2 = SouthWest;
            }

            if (W == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_W"); //inv
                W = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (W != null && IsEnabled)
            {
                W.color2 = West;
            }

            if (NW == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_NW"); //inv
                NW = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (NW != null && IsEnabled)
            {
                NW.color2 = NorthWest;
            }

        }
        public static MelonPreferences_Category MelonPrefCategory { get; private set; }
        public static MelonPreferences_Entry<bool> MelonPrefEnabled { get; private set; }
        public static bool IsEnabled { get; private set; }
        public MelonPreferences_Entry<Color> NorthPref { get; private set; }
        public MelonPreferences_Entry<Color> NorthEastPref { get; private set; }
        public MelonPreferences_Entry<Color> EastPref { get; private set; }
        public MelonPreferences_Entry<Color> SouthEastPref { get; private set; }
        public MelonPreferences_Entry<Color> SouthPref { get; private set; }
        public MelonPreferences_Entry<Color> SouthWestPref { get; private set; }
        public MelonPreferences_Entry<Color> WestPref { get; private set; }
        public MelonPreferences_Entry<Color> EasrPref { get; private set; }
        public MelonPreferences_Entry<Color> NorthWestPref { get; private set; }
        public static bool MelonPrefEnabledValue { get; private set; }
    }
}