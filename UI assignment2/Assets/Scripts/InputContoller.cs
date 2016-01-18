using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InputContoller : MonoBehaviour {
    public Text debugprint;
    public Image JoyFG;
    public Image JoyBG;
	// Use this for initialization
	void Start () {
        debugprint.text = "Started";
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void ClickedA()
    {
        debugprint.text = "A clicked";
    }
    public void ClickedB()
    {
        debugprint.text = "B clicked";
    }
    public void ClickedMain()
    {
        debugprint.text = "MainMenu clicked";
    }
    public void ClickedTryAgain()
    {
        debugprint.text = "TryAgain clicked";
    }
    public void ClickedContinue()
    {
        debugprint.text = "Continue clicked";
    }
    public void ClickedThumb()
    {
        debugprint.text = "ClickedThumb";
    }
    public void UnclickedThumb()
    {
        debugprint.text = "UnclickedThumb";
    }
    public void Dragging()
    {
        debugprint.text = "dragging" + Input.mousePosition.x + "," + Input.mousePosition.y;
        Vector3 newPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1.0f);
       
        JoyFG.rectTransform.position = newPos;
    }
    public void returnJoyFG()
    {
        JoyFG.rectTransform.position = new Vector3(JoyBG.rectTransform.position.x , JoyBG.rectTransform.position.y , 1.0f);
    }
    
}
