using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class UITutorialTrigger : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("UITutorialTrigger").GetComponent<MeshRenderer>().enabled)
        {
            if (SteamVR_Input._default.inActions.TriggerAction.GetStateDown(SteamVR_Input_Sources.Any))
            {
                print("Trigger delete");
                Destroy(GameObject.Find("UITutorialTrigger"));
            }
        }
    }
}
