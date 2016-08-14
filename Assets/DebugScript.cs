using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DebugScript : MonoBehaviour {

    public Text myText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        string s = "";
        s += Input.mousePosition.x + " , " + Input.mousePosition.y + "\n";
        s += (Input.GetMouseButton(0) ? "TRUE" : "FALSE") + "\n";
        s += (Input.GetMouseButton(1) ? "TRUE" : "FALSE") + "\n";
        myText.text = s;
    }
}
