using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class UITutorialGrab : MonoBehaviour {

    public GameObject UITutorialTrigger;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("UITutorialGrab").GetComponent<MeshRenderer>().enabled)
        {
            if (SteamVR_Input._default.inActions.TriggerAction.GetStateDown(SteamVR_Input_Sources.Any))
            {
                UITutorialTrigger.GetComponent<MeshRenderer>().enabled = true;
                Destroy(GameObject.Find("UITutorialGrab"));
            }
        }
    }
}
