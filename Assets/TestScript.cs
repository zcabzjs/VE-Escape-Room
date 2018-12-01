using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    public GameObject usb;
    public GameObject laptop;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray.origin, ray.direction, out raycastHit, Mathf.Infinity))
            {
                if (raycastHit.transform.name == "TestCube")
                {
                    Debug.Log("Test cube clicked!");
                    usb.transform.position = laptop.transform.position;
                    usb.transform.rotation = laptop.transform.rotation;
                    usb.transform.parent = laptop.transform;
                }
            }
        }
    }
}
