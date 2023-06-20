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

namespace Melon_Loader_Mod5
{
    public static class BuildInfo
    {
        public const string Name = "Melon_Loader_Mod5";
        public const string Author = null;
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
    }

    public class Melon_Loader_Mod5 : MelonMod
    {
        /*static float N1 = 0f;
        static float N2 = 1f;
        static float N3 = 1f;
        static float N4 = 1f;

        static float NE1 = 1f;
        static float NE2 = 0.5f;
        static float NE3 = 0f;
        static float NE4 = 1f;

        static float E1 = 1f;
        static float E2 = 1f;
        static float E3 = 0f;
        static float E4 = 1f;

        static float SE1 = 0f;
        static float SE2 = 0f;
        static float SE3 = 1f;
        static float SE4 = 1f;

        static float S1 = 1f;
        static float S2 = 0f;
        static float S3 = 1f;
        static float S4 = 1f;

        static float SW1 = 0.5f;
        static float SW2 = 0f;
        static float SW3 = 1f;
        static float SW4 = 1f;

        static float W1 = 1f;
        static float W2 = 0f;
        static float W3 = 0f;
        static float W4 = 1f;

        static float NW1 = 0f;
        static float NW2 = 1f;
        static float NW3 = 0f;
        static float NW4 = 1f;

        Color North = new Color(N1, N2, N3, N4); //eject

        Color NorthEast = new Color(NE1, NE2, NE3, NE4); //level

        Color East = new Color(E1, E2, E3, E4); //prefrances

        Color SouthEast = new Color(SE1, SE2, SE3, SE4); //quick unmute

        Color South = new Color(S1, S2, S3, S4); //inventory

        Color SouthWest = new Color(SW1, SW2, SW3, SW4); //devtools

        Color West = new Color(W1, W2, W3, W4); //spawngun 

        Color NorthWest = new Color(NW1, NW2, NW3, NW4); //avatar */

        Color North = new Color(0f, 1f, 1f, 1f); //eject

        Color NorthEast = new Color(1f, 0.5f, 0f, 1f); //level

        Color East = new Color(1f, 1f, 0f, 1f); //prefrances

        Color SouthEast = new Color(0f, 0f, 1f, 1f); //quick unmute

        Color South = new Color(1f, 0f, 1f, 1f); //inventory

        Color SouthWest = new Color(0.5f, 0f, 1f, 1f); //devtools

        Color West = new Color(1f, 0f, 0f, 1f); //spawngun 

        Color NorthWest = new Color(0f, 1f, 0f, 1f); //avatar




        private void OnSceneAwake()
        {
            Moggingtime();
        }
        public override void OnInitializeMelon()
        {
            BoneLib.Hooking.OnLevelInitialized += (_) => { OnSceneAwake(); }; //Fusion is under MIT licencse so pretty sure as long as I cWestit it I'll be fine
            BonemenuCreator();
            //MelonPreferencesCreator();
        }



        public void BonemenuCreator()
        {
            //this is so ugly but whatever it works
            string NorthHexcode = ColorUtility.ToHtmlStringRGBA(North);
            string NorthEastHexcode = ColorUtility.ToHtmlStringRGBA(NorthEast);
            string EastHexcode = ColorUtility.ToHtmlStringRGBA(East);
            string SouthEastHexcode = ColorUtility.ToHtmlStringRGBA(SouthEast);
            string SouthHexcode = ColorUtility.ToHtmlStringRGBA(South);
            string SouthWestHexcode = ColorUtility.ToHtmlStringRGBA(SouthWest);
            string WestHexcode = ColorUtility.ToHtmlStringRGBA(West);
            string NorthWestHexcode = ColorUtility.ToHtmlStringRGBA(NorthWest);

            var category = MenuManager.CreateCategory( //im not typing all this out again so its a var now!!!!!!
                "<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + SouthHexcode + ">" + "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>"
                , Color.white);

            var NorthButton = category.CreateCategory("Eject", North);
            ColorfulMenuCreator(NorthButton, North, (updatedColor) =>
            {
                North = updatedColor;
            });
            var NorthEastButton = category.CreateCategory("Level Select", NorthEast);
            var EastButton = category.CreateCategory("Preferences", East);
            var SouthEastButton = category.CreateCategory("Quick Mute", SouthEast);
            var SouthButton = category.CreateCategory("Inventory", South);
            var SouthWestButton = category.CreateCategory("Spawn Devtools", SouthWest);
            var WestButton = category.CreateCategory("SpawnGun Menu", West);
            var NorthWestButton = category.CreateCategory("Level Select", NorthWest);

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
            var colorA = category.CreateFloatElement("Alpha", Color.black, currentColor.a, 0.1f, 0f, 1f, (a) => {
                currentColor.a = a;
                colorPreview.SetColor(currentColor);
            });
            category.CreateFunctionElement("Apply", Color.white, delegate ()
            {
                applyCallback(currentColor);
                Moggingtime();

            });




        }


        public void Moggingtime()
        {
            //I realize I shouldve made these public methods and put them in other files now but whatever
            // I could 100% make all these way more compressed but i dont really care right now might fix after launch
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
                    Extra(obj.transform, bonemenu: false);
                }
                else if (obj.name.Contains("ElementGrid"))
                {
                    Extra(obj.transform, bonemenu: true);
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
                    Bodymall(obj.transform);
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
        private void Extra(Transform parent, bool bonemenu)
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
                else if (textComponent != null && !bonemenu)
                {
                    textComponent.color = East;
                }


                // Recursively call the method to modify components in nested children
                Extra(child, bonemenu: false);
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


        private void RadialMenuTextImage(Transform parent)
        {


            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);




                // Get the desiWest component from the child (if exists)
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
        private void RadialMenuButtons()
        {


           
           
                
                if (N == null)
                {
                    GameObject button_Region_N = GameObject.Find("button_Region_N"); //eject
                    N = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
                }
                if (N != null)
                {
                    N.color2 = North;
                }

            if (NE == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_NE"); //Level
                NE = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (NE != null)
            {
                NE.color2 = NorthEast;
            }

            if (E == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_E"); //Pref
                E = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (E != null)
            {
                E.color2 = East;
            }

            if (SE == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_SE"); //Quick Unmute
                SE = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (SE != null)
            {
                SE.color2 = SouthEast;
            }

            if (S == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_S"); //inv
                S = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (S != null)
            {
                S.color2 = South;
            }

            if (SW == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_SW"); //inv
                SW = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (SW != null)
            {
                SW.color2 = SouthWest;
            }

            if (W == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_W"); //inv
                W = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (W != null)
            {
                W.color2 = West;
            }

            if (NW == null)
            {
                GameObject button_Region_N = GameObject.Find("button_Region_NW"); //inv
                NW = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
            }
            if (NW != null)
            {
                NW.color2 = NorthWest;
            }

        }

    }
}