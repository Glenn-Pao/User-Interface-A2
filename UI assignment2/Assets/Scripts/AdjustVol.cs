using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Collections;

public class AdjustVol : MonoBehaviour {
    static float soundvalue;
    Slider volumeSlider;

	// Use this for initialization
	void Start () 
    {
        soundvalue = AudioListener.volume;
        volumeSlider.value = soundvalue;
	}
	
	// Update is called once per frame
	void Update () 
    {
        soundvalue = volumeSlider.value;
    
	}

   public void SetBGMVol(float volume)
    {
        AudioListener.volume = volume;
    }
    public void SetSFXVol(float volume)
   {
       AudioListener.volume = volume;
   }
}
