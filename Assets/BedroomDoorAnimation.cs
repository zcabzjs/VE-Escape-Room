using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomDoorAnimation : MonoBehaviour {

    bool bedroomDoorOpen;
    Animator bedroomDoorAnim;

	// Use this for initialization
	void Start () {
        bedroomDoorAnim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray.origin, ray.direction, out raycastHit, Mathf.Infinity))
            {
                if (raycastHit.transform.name == "BedroomDoor")
                {
                    if (bedroomDoorOpen)
                    {
                        bedroomDoorAnim.SetBool("openDoor", false);
                        bedroomDoorOpen = false;
                    }
                    else
                    {
                        bedroomDoorAnim.SetBool("openDoor", true);
                        bedroomDoorOpen = true;
                    }
                   
                }
            }
        }
    }
}
