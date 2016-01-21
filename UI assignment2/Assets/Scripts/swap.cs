using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class swap : MonoBehaviour {
    public Text debugprint;
    public Button control1;
    public Button control2;

    public Button left;
    public Button basic;
    public Button right;

    public Sprite control1_filledOn;
    public Sprite control2_filledOn;
    public Sprite control1_filledOff;
    public Sprite control2_filledOff;

    public Sprite tag_filledOn;
    public Sprite tag_leftfilledOff;
    public Sprite tag_rightfilledOff;
    public Sprite tag_basicfilledOff;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void ClickedControl1()
    {
        debugprint.text = "contol1 clicked";
        control1.image.sprite = control1_filledOn;
        control2.image.sprite = control2_filledOff;
    }
    public void ClickedControl2()
    {
        debugprint.text = "contol2 clicked";
        control2.image.sprite = control1_filledOff;
        control1.image.sprite = control2_filledOn;
    }
    public void Clickedleft()
    {
        debugprint.text = "left clicked";
        left.image.sprite = tag_filledOn;
        basic.image.sprite = tag_basicfilledOff;
        right.image.sprite = tag_rightfilledOff;
    }
    public void Clickedbasic()
    {
        debugprint.text = "basic clicked";
        basic.image.sprite = tag_filledOn;
        left.image.sprite = tag_leftfilledOff;
        right.image.sprite = tag_rightfilledOff;
    }
    public void Clickedright()
    {
        debugprint.text = "right clicked";
        right.image.sprite = tag_filledOn;
        left.image.sprite = tag_leftfilledOff;
        basic.image.sprite = tag_basicfilledOff;
    }
}
