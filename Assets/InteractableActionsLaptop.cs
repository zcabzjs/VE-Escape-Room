using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsLaptop : MonoBehaviour {

    void Trigger()
    {
        GameObject.Find("UITutorialGrab").GetComponent<MeshRenderer>().enabled = true;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
