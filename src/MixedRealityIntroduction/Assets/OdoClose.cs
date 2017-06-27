using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdoClose : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {

	}
    private void OnTriggerEnter(Collider other)
    {
        transform.GetComponent<Renderer>().material.color = Color.magenta;
    }
    private void OnTriggerExit(Collider other)
    {
        transform.GetComponent<Renderer>().material.color = Color.white;
    }
}
