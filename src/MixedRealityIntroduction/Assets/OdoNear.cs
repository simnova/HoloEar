using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdoNear : MonoBehaviour {

    public GameObject parent = new GameObject();
    // Use this for initialization
    void Start()
    {
        

        if(parent == null)
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
        parent.transform.GetComponent<Renderer>().material.color = Color.yellow;
    }
    private void OnTriggerExit(Collider other)
    {
        parent.transform.GetComponent<Renderer>().material.color = Color.magenta;
    }
}
