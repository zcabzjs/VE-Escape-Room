using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSwitchToggle : MonoBehaviour {

    bool turnedOn = false;
    GameObject switchPivot;
    // Use this for initialization
    void Start () {
        switchPivot = this.gameObject.transform.GetChild(0).gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray.origin, ray.direction, out raycastHit, Mathf.Infinity))
            {
                if (raycastHit.transform.name == "Wall switch")
                {
                    if (!turnedOn)
                    {
                        Debug.Log("Tutorial started!");
                        switchPivot.transform.Rotate(10, 0, 0);
                        turnedOn = true;
                    }
                }
            }
        }

    }
}
