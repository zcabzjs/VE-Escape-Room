﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class UITutorialDpad : MonoBehaviour {

    public GameObject UITutorialGrab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("UITutorialDpad").GetComponent<MeshRenderer>().enabled)
        {
            if (SteamVR_Input._default.inActions.TriggerAction.GetStateDown(SteamVR_Input_Sources.Any))
            {
                UITutorialGrab.GetComponent<MeshRenderer>().enabled = true;
                Destroy(GameObject.Find("UITutorialDpad"));
            }
        }
		
	}

}