﻿using UnityEngine;
using System.Collections;

public class DoAThing : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        // GetComponent<Animator>().SetBool("Bark", true);
        StartCoroutine(TimerThing());
        Debug.Log("ASDH");
	}
	
	// Update is called once per frame
	void Update () {
        // transform.position += Vector3.up * Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
         //   GetComponent<Animator>().SetTrigger("Bark");
        }

        transform.position += transform.forward * Time.deltaTime * speed;
        GetComponent<Animator>().SetFloat("moveSpeed", speed);
    }

    IEnumerator TimerThing()
    {
        Debug.Log("DSA");
        yield return new WaitForSeconds(5);
        GetComponent<Animator>().SetTrigger("Bark");
        yield return new WaitForSeconds(2);
        GetComponent<Animator>().SetTrigger("Bark");
    }
}
