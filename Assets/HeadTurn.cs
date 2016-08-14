using UnityEngine;
using System.Collections;

public class HeadTurn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //#if !UNITY_ANDROID
        transform.eulerAngles += new Vector3(Input.GetAxis("Vertical"), -Input.GetAxis("Horizontal"), 0);
//#endif
    }
}
