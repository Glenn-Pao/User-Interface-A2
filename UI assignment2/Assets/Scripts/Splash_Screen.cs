﻿using UnityEngine;
using System.Collections;

public class Splash_Screen : MonoBehaviour {

    public GameObject self;             //point to itself
    private Transitions transition;      //transition object
    private Audio_BGM bgm;             //bgm object

	// Use this for initialization
	void Start () 
    {
	    //access self, transitions and bgm

        transition = self.GetComponent<Transitions>();  //returns a sample script of Transitions into the script
        bgm = self.GetComponent<Audio_BGM>().GetInstance(); //returns the actual Audio_BGM script
        bgm.PlayTrack(0);   //play the track
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //for the button press and transition
    public void OnClick()
    {
        //to do: fading
        transition.LoadMainMenu();  //go to main menu
    }
}
