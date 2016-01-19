using UnityEngine;
using System.Collections;
using UnityEngine.Audio;    //access the audio mixer namespaces

//This script is an experiment into implementation of sound. We're starting with background music first.
public class Audio_BGM : MonoBehaviour {

    private static Audio_BGM instance = null;
    public static Audio_BGM GetInstance()
    {
        return instance;
    }
    
    public AudioMixerSnapshot outOfCombat;
    public AudioMixerSnapshot inCombat;
    public float bpm = 183; //reference to ANIMA, double tempo of the other song

    private float m_TransitionIn;       //mili seconds to transition in combat music
    private float m_TransitionOut;  //mili seconds to transition out combat music
    private float m_QuarterNote;

    SliderJoint2D volumeSlider;

	// Use this for initialization
	void Start () {
	    m_QuarterNote = 60/bpm;
        m_TransitionIn = m_QuarterNote;
        m_TransitionOut = m_QuarterNote * 32;
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
    /************** Triggers, if needed *****************/
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("CombatZone"))
        {
            inCombat.TransitionTo(m_TransitionIn);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("CombatZone"))
        {
            outOfCombat.TransitionTo(m_TransitionOut);
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
