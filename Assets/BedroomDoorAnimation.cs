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

    void Trigger()
    {
        if (LevelManager.tutorialCompleted)
        {
            bedroomDoorOpen = !bedroomDoorOpen;
            bedroomDoorAnim.SetBool("openDoor", bedroomDoorOpen);
        }
    }
}
