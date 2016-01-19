using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class AdjustVol : MonoBehaviour {

    SliderJoint2D volumeSlider;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

   public void SetBGMVol(float volume)
    {
        AudioListener.volume = volume;
    }
}
