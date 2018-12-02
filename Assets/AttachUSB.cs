using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class AttachUSB : MonoBehaviour {

    //public GameObject usbHolder;
    bool inHolderRange = false;
    Vector3 usbHolderPosition;
    Quaternion usbHolderRotation;
    Rigidbody rb;
    // Use this for initialization
    /*
    public void OnHoldTrigger()
    {
        if (inHolderRange)
        {
            this.transform.position = usbHolderPosition;
            this.transform.rotation = usbHolderRotation;
        }
    }*/
    void Start()
    {
        rb = this.transform.gameObject.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "Laptop USB Holder")
        {
            Debug.Log("Detected USB Holder");
            //this.transform.parent = other.transform;
            inHolderRange = true;

            rb.constraints = RigidbodyConstraints.FreezeAll;
            this.transform.position = other.transform.position;
            this.transform.rotation = other.transform.rotation;

            GameObject hand = this.transform.parent.gameObject;
            hand.GetComponent<Hand>().DetachObject(this.gameObject);

            
            
            //usbHolderPosition = other.transform.position;
            //usbHolderRotation = other.transform.rotation;

        }
    }
    /*
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "USB Holder")
        {
            Debug.Log("Detected USB Holder");
            //this.transform.parent = other.transform;
            inHolderRange = false; 
        }
    }*/
}
