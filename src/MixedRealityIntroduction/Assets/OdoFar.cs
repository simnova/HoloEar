using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdoFar : MonoBehaviour {

    public GameObject parent = new GameObject();
    // Use this for initialization
    void Start()
    {

        if (parent == null)
        {
            parent = GameObject.FindGameObjectWithTag("EarObject");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        parent.transform.GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnTriggerExit(Collider other)
    {
        parent.transform.GetComponent<Renderer>().material.color = Color.magenta;
    }
}
