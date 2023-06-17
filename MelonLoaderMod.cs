using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using BoneLib.BoneMenu;
using System;

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
        Color North = new Color(0, 1, 1, 1); //eject

        Color NorthEast = new Color(1, 0.5f, 0, 1); //level

        Color East = new Color(1, 1, 0, 1); //prefrances

        Color SouthEast = new Color(0, 0, 1, 1); //quick unmute

        Color South = new Color(1, 0, 1, 1); //inventory

        Color SouthWest = new Color(0.5f, 0, 1, 1); //devtools

        Color West = new Color(1, 0, 0, 1); //spawngun 

        Color NorthWest = new Color(0, 1, 0, 1); //avatar


        // I should make all of these have a f but i truly dont care enough

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

            var category = MenuManager.CreateCategory( 
                "<color=#" + NorthHexcode + ">" + "C" + "</color>" +
                "<color=#" + NorthEastHexcode + ">" + "o" + "</color>" +
                "<color=#" + EastHexcode + ">" + "l" + "</color>" +
                "<color=#" + SouthEastHexcode + ">"+ "o" + "</color>" +
                "<color=#" + SouthHexcode + ">"+ "r" + "</color>" +
                "<color=#" + SouthWestHexcode + ">" + "f" + "</color>" +
                "<color=#" + WestHexcode + ">" + "u" + "</color>" +
                "<color=#" + NorthWestHexcode + ">" + "l" + "</color>"
                , Color.white);
        }
        public void Moggingtime()
        {
            //I realize I shouldve made these public methods and put them in other files now but whatever
            // I could 100% make all these way more compressed but i dont really care right now might fix after launch
            GameObject[] objectsWithKeyword = GameObject.FindObjectsOfType<GameObject>();
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
                RadialMenuButtons();
            }
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
                else if (textComponent != null && ( i == 3 || i == 4))
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

        private void RadialMenuButtons() //god I did this in a bad way might fix later in 1.1
        {
            

            GameObject button_Region_N = GameObject.Find("button_Region_N"); //eject
            if (button_Region_N != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_N.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desiWest property value for the child object
                    itemView.color2 = North;
                }
            }
            GameObject button_Region_NE = GameObject.Find("button_Region_NE"); //level selecct
            if (button_Region_NE != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_NE.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desiWest property value for the child object
                    itemView.color2 = NorthEast;
                }
            }
            GameObject button_Region_E = GameObject.Find("button_Region_E"); //pref
            if (button_Region_E != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_E.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desiWest property value for the child object
                    itemView.color2 = East;
                }
            }
            GameObject button_Region_SE = GameObject.Find("button_Region_SE"); //quick unmute
            if (button_Region_SE != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_SE.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desiWest property value for the child object
                    itemView.color2 = SouthEast;
                }
            }
            GameObject button_Region_S = GameObject.Find("button_Region_S"); //inv
            if (button_Region_S != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_S.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desiWest property value for the child object
                    itemView.color2 = South;
                }
            }
            GameObject button_Region_SW = GameObject.Find("button_Region_SW"); //dev tools
            if (button_Region_SW != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_SW.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desiWest property value for the child object
                    itemView.color2 = SouthWest;
                }
            }
            GameObject button_Region_W = GameObject.Find("button_Region_W"); //spawn menu
            if (button_Region_W != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_W.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desiWest property value for the child object
                    itemView.color2 = West;
                }
            }
            GameObject button_Region_NW = GameObject.Find("button_Region_NW"); //avatar
            if (button_Region_NW != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_NW.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desiWest property value for the child object
                    itemView.color2 = NorthWest;
                }
            }
            
 
        }

    }
}