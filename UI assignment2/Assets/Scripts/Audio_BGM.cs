using UnityEngine;
using System.Collections;
using UnityEngine.Audio;    //access the audio mixer namespaces

//This script is an experiment into implementation of sound. We're starting with background music first.
public class Audio_BGM : MonoBehaviour {

    private static Audio_BGM instance = null;

    public AudioSource buttonPress;
    public AudioClip buttonClip;

    public static Audio_BGM GetInstance()
    {
        return instance;
    }   
    void Awake()
    {
       //check if there isnt an instance yet
        if(instance == null)
        {
            instance = this;
        }

        //if there is already an instance
        else if(instance != this)
        {
            //destroy this pattern. ensure that it only plays once.
            Destroy(gameObject);
        }
        //Set it not to be destroyed when reloading a scene
        DontDestroyOnLoad(gameObject);
    }
}
