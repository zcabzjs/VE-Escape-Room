using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class UITutorialTrigger : MonoBehaviour {

    public GameObject UITutorialNext;

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
                //ITutorialNext.GetComponent<MeshRenderer>().enabled = true;
                Destroy(GameObject.Find("UITutorialTrigger"));
            }
        }
    }
}
