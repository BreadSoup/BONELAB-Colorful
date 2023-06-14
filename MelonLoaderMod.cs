using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

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

        Color red = new Color(1, 0, 0, 1); //spawngun 

        Color green = new Color(0, 1, 0, 1); //avatar

        Color blue = new Color(0, 0, 1, 1); //quick unmute

        Color yellow = new Color(1, 1, 0, 1); //prefrances

        Color sky = new Color(0, 1, 1, 1); //eject

        Color magenta = new Color(1, 0, 1, 1); //inventory

        Color orange = new Color(1, 0.5f, 0, 1); //level

        Color purple = new Color(0.5f, 0, 1, 1); //devtools

        // I should make all of these have a f but i truly dont care enough

        public override void OnUpdate()
        {
            //I realize I shouldve made these public methods and put them in other files now but whatever
            // I could 100% make all these way more compressed but i dont really care right now might fix after launch
            GameObject group_levelSelect = GameObject.Find("group_levelSelect");  // orange //done
            if (group_levelSelect != null)
            {
                LevelSelect(group_levelSelect.transform, isSecondChild: true);
            }

            GameObject panel_Preferences = GameObject.Find("panel_Preferences"); //yellow //done
            if (panel_Preferences != null)
            {
                Preferences(panel_Preferences.transform, isSecondChild: true);
            }

            GameObject grid_Graphics = GameObject.Find("grid_Graphics"); //yellow //done
            if (grid_Graphics != null)
            {
                Extra(grid_Graphics.transform, bonemenu: false);
            }

            GameObject ElementGrid = GameObject.Find("ElementGrid"); //yellow //done
            if (ElementGrid != null)
            {
                Extra(ElementGrid.transform, bonemenu: true);
            }

            GameObject group_toolMenu = GameObject.Find("group_toolMenu"); //red //done 
            if (group_toolMenu != null)
            {
                SpawnGun(group_toolMenu.transform, isFourthChild: true);
            }

            // Dont know why it wont overide the white grid on the spawn gun but it doesnt matter that much if someone wants to make a PR to fix it feel free
            // might be because of bodymall dont know dont care enough to test
            /*GameObject image_backline = GameObject.Find("image_backline");
            if (image_backline != null)
            {
                ExtraSpawn(image_backline.transform);  // dont know why SpawnGun() doesnt get image_backline but whatever thats what the extra class is for
            }*/

            GameObject group_AvatarSelect = GameObject.Find("group_AvatarSelect"); //green //done
            if (group_AvatarSelect != null)
            {     

                Avatar(group_AvatarSelect.transform, isSecondChild: true);
            }

            GameObject BodyMallController = GameObject.Find("BodyMallController"); //green //done
            if (BodyMallController != null)
            {

                Bodymall(BodyMallController.transform);
            }

            RadialMenuButtons();

            string filepath = "[RigManager (Blank)]/[UIRig]/PLAYERUI/UI_POPUP/scaleOffset/CANVAS_RADIALUI/"; //doing this because for some reason it cant find "CANVAS_RADIALUI" but it does if I put the full path?

            GameObject CANVAS_RADIALUI = GameObject.Find(filepath);
            if (CANVAS_RADIALUI != null)
            {
                RadialMenuTextImage(CANVAS_RADIALUI.transform);
            }


            //doesnt work might not work ever idk
            /* GameObject INVENTORYSLOTS = GameObject.Find("INVENTORYSLOTS");     
             if (group_levelSelect != null)
             {
                 Inventory(INVENTORYSLOTS.transform, isSecondChild: true);
             }
             */

            
        }

        private void LevelSelect(Transform parent, bool isSecondChild)
        {
            
            // Iterate through each child object of the parent
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);

                // Skip modifying the desired component for the second child if isSecondChild is true
                if (isSecondChild && i == 1)
                    continue;

                // Get the desired component from the child (if exists)
                UnityEngine.UI.Image imageComponent = child.GetComponent<UnityEngine.UI.Image>();
                TextMeshProUGUI textComponent = child.GetComponent<TextMeshProUGUI>();

                if (imageComponent != null)
                {
                    // Change the desired property value for the child object
                    imageComponent.color = orange;
                }
                else if (textComponent != null)
                {
                    textComponent.color = orange;
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

                // Skip modifying the desired component for the second child if isSecondChild is true
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
                    imageComponent.color = yellow;
                }
                else if (textComponent != null)
                {
                    textComponent.color = yellow;
                }
                else if (bonemenuimageComponent != null)
                {
                    bonemenuimageComponent.color = yellow;
                }
                else if (bonemenutextComponent != null)
                {
                    bonemenutextComponent.color = yellow;
                }
                else if (literallyASinglecharacter != null)
                {
                    literallyASinglecharacter.color = yellow;
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
                    imageComponent.color = yellow;
                }
                else if (textComponent != null && !bonemenu)
                {
                    textComponent.color = yellow;
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
                else if (child.name == "image_backline")
                {
                    continue;
                }
                

                if (isFourthChild && i == 3)
                    continue;

                if (imageComponent != null)
                {
                    imageComponent.color = red;
                }
                else if (textComponent != null)
                {
                    textComponent.color = red;
                }
                else if (spawnGuntextComponent != null)
                {
                    spawnGuntextComponent.color = red;
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
                    imageComponent.color = red;
                }
                else if (textComponent != null)
                {
                    textComponent.color = red;
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

                // Skip modifying the desired component for the second child if isSecondChild is true
                if (isSecondChild && i == 1)
                    continue;

                // Get the desired component from the child (if exists)
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
                    // Change the desired property value for the child object
                    imageComponent.color = green;
                }
                else if (textComponent != null)
                {
                    textComponent.color = green;
                }
                else if (bodyMallTextComponent != null)
                {
                    bodyMallTextComponent.color = green;
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

                

                // Get the desired component from the child (if exists)
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
                    // Change the desired property value for the child object
                    imageComponent.color = green;
                }
                else if (textComponent != null)
                {
                    textComponent.color = green;
                }
                else if (bodyMallTextComponent != null)
                {
                    bodyMallTextComponent.color = green;
                }


                // Recursively call the method to modify components in nested children
                Bodymall(child);
            }
        }


        private void RadialMenuTextImage(Transform parent)
        {
            
            if (parent != null)
            {

                for (int i = 0; i < parent.childCount; i++)
                {
                    Transform child = parent.GetChild(i);

                    


                    // Get the desired component from the child (if exists)
                    UnityEngine.UI.Image imageComponent = child.GetComponent<UnityEngine.UI.Image>();
                    TextMeshProUGUI textComponent = child.GetComponent<TextMeshProUGUI>();


                    if (child.name == "text_Information")
                    {
                        continue;
                    }

                    if (imageComponent != null || i == 0) //done
                    {
                        imageComponent.color = sky;
                    }
                    else if (textComponent != null || i == 1)
                    {
                        textComponent.color = sky;
                    }

                    else if (imageComponent != null || i == 4) //done
                    {
                        imageComponent.color = orange;
                    }
                    else if (textComponent != null || i == 3)
                    {
                        textComponent.color = orange;
                    }

                    else if (imageComponent != null || i == 7) //done
                    {
                        imageComponent.color = yellow;
                    }
                    else if (textComponent != null || i == 6)
                    {
                        textComponent.color = yellow;
                    }

                    else if (imageComponent != null || i == 10) //done
                    {
                        imageComponent.color = blue;
                    }
                    else if (textComponent != null || i == 9)
                    {
                        textComponent.color = blue;
                    }

                    else if (imageComponent != null || i == 13) //done
                    {
                        imageComponent.color = magenta;
                    }
                    else if (textComponent != null || i == 12)
                    {
                        textComponent.color = magenta;
                    }

                    else if (imageComponent != null || i == 16) //done
                    {
                        imageComponent.color = purple;
                    }
                    else if (textComponent != null || i == 15)
                    {
                        textComponent.color = purple;
                    }

                    else if (imageComponent != null || i == 19) //done
                    {
                        imageComponent.color = red;
                    }
                    else if (textComponent != null || i == 18)
                    {
                        textComponent.color = red;
                    }

                    else if (imageComponent != null || i == 22) //done
                    {
                        imageComponent.color = green;
                    }
                    else if (textComponent != null || i == 21)
                    {
                        textComponent.color = green;
                    }



                    // Recursively call the method to modify components in nested children
                    RadialMenuTextImage(child);
                }
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
                    // Change the desired property value for the child object
                    itemView.color2 = sky;
                }
            }
            GameObject button_Region_NE = GameObject.Find("button_Region_NE"); //level selecct
            if (button_Region_NE != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_NE.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desired property value for the child object
                    itemView.color2 = orange;
                }
            }
            GameObject button_Region_E = GameObject.Find("button_Region_E"); //pref
            if (button_Region_E != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_E.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desired property value for the child object
                    itemView.color2 = yellow;
                }
            }
            GameObject button_Region_SE = GameObject.Find("button_Region_SE"); //quick unmute
            if (button_Region_SE != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_SE.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desired property value for the child object
                    itemView.color2 = blue;
                }
            }
            GameObject button_Region_S = GameObject.Find("button_Region_S"); //inv
            if (button_Region_S != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_S.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desired property value for the child object
                    itemView.color2 = magenta;
                }
            }
            GameObject button_Region_SW = GameObject.Find("button_Region_SW"); //dev tools
            if (button_Region_SW != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_SW.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desired property value for the child object
                    itemView.color2 = purple;
                }
            }
            GameObject button_Region_W = GameObject.Find("button_Region_W"); //spawn menu
            if (button_Region_W != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_W.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desired property value for the child object
                    itemView.color2 = red;
                }
            }
            GameObject button_Region_NW = GameObject.Find("button_Region_NW"); //avatar
            if (button_Region_NW != null)
            {
                SLZ.UI.PageItemView itemView = button_Region_NW.GetComponent<SLZ.UI.PageItemView>();
                if (itemView != null)
                {
                    // Change the desired property value for the child object
                    itemView.color2 = green;
                }
            }
            
 
        }



        /* private void Inventory(Transform parent, bool isSecondChild)
         {
             // Iterate through each child object of the parent
             for (int i = 0; i < parent.childCount; i++)
             {
                 Transform child = parent.GetChild(i);

                 // Skip modifying the desired component for the second child if isSecondChild is true
                 if (isSecondChild && i == 1)
                     continue;

                 // Get the desired component from the child (if exists)
                 UnityEngine.UI.Image imageComponent = child.GetComponent<UnityEngine.UI.Image>();
                 TextMeshProUGUI textComponent = child.GetComponent<TextMeshProUGUI>();

                 if (imageComponent != null)
                 {
                     // Change the desired property value for the child object
                     imageComponent.color = red;
                 }
                 else if (textComponent != null)
                 {
                     textComponent.color = red;
                 }


                 // Recursively call the method to modify components in nested children
                 Inventory(child, isSecondChild: false);
             }
         }*/
    }
}