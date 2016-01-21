using UnityEngine;
using System.Collections;

public class Transitions : MonoBehaviour {
    /*******  These are the functions to call when you want to transition from screen to screen  ********/

    //trigger this when the button is tapped while on splashscreen
    public void LoadMainMenu()
    {
        Debug.Log("Main Menu Screen Load");
        Application.LoadLevel("Main_Menu_Screen"); //move to the main menu screen
    }

    //trigger this when the Quest button is tapped on while in main menu screen
    public void LoadLevelSelect()
    {
        Application.LoadLevel("Level_Select_Screen");
    }

    //trigger this when the Menu button is tapped on while in main menu screen
    public void LoadOptionsScreen()
    {
        Debug.Log("Option Screen Load");
        Application.LoadLevel("Options_Screen");
    }
}
