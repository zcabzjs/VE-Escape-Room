using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilitiesRoomLDoorAnimation : MonoBehaviour {

    bool doorOpen = false;

    Animator anim;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
    void Trigger()
    {
        if (LevelManager.utilitiesRoomUnlocked)
        {
            doorOpen = !doorOpen;
            anim.SetBool("openUtilitiesRoomDoor", doorOpen);
        }
    }
}
