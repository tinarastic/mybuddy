using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    float startPoint;
    public float threshold;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            startPoint = Input.mousePosition.x;
        }

        if (Input.GetMouseButton(0))
        {
            if(startPoint - Input.mousePosition.x > threshold)
            {
                Vector3 forward2D = new Vector3(transform.forward.x, 0, transform.forward.z).normalized;
                transform.position += forward2D * Time.deltaTime;
            }
        }
	}
}
