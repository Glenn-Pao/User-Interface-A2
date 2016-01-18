using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class toggle3 : MonoBehaviour {
    private int toggle = 1;
    public Image myImage;
    public Image SomeotherImage1;
    public Image SomeotherImage2;
    public Image SomeotherImage3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
            switch (toggle)
            {
                case 1:
                    ChangeImage("High");
                    toggle++;
                    break;
                case 2:
                    ChangeImage("Average");
                     toggle++;
                    break;
                case 3:
                    ChangeImage("Low");
                     toggle = 1;
                    break;
            }
	}
    public void ChangeImage(string newImageTitle)
    {
        if (newImageTitle == "High")
        myImage.sprite = SomeotherImage1.sprite;
        if (newImageTitle == "Avenrage")
            myImage.sprite = SomeotherImage2.sprite;
        if (newImageTitle == "Low")
            myImage.sprite = SomeotherImage3.sprite;
    }
}
