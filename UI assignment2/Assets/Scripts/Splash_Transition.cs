using UnityEngine;
using System.Collections;

public class Splash_Transition : MonoBehaviour {

    //trigger this when the button is tapped while on splashscreen
    public void LoadMainMenu()
    {
        Application.LoadLevel("Main_Menu_Screen"); //move to the main menu screen
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
