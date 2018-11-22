using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour {

    bool doorOpen = false;
    Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;

            if(Physics.Raycast(ray.origin, ray.direction, out raycastHit, Mathf.Infinity))
            {
                Debug.Log("Mouse Click!");
                if(raycastHit.transform.name == "Door")
                {
                    if (doorOpen)
                    {
                        closeDoor();
                    }
                    else
                    {
                        openDoor();
                    }
                }

            }
        }
	}

    void openDoor()
    {
        anim.SetBool("isopen", true);
        Debug.Log("Open door");
        doorOpen = true;
        
    }

    void closeDoor()
    {
        anim.SetBool("isopen", false);
        Debug.Log("Close door");
        doorOpen = false;
        
    }
}
