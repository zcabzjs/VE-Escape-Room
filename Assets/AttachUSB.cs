using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachUSB : MonoBehaviour {

    //public GameObject usbHolder;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "USB Holder")
        {
            Debug.Log("Detected USB Holder");
            //this.transform.parent = other.transform;
            this.transform.position = other.transform.position;
            this.transform.rotation = other.transform.rotation;
            
            
        }
    }
}
