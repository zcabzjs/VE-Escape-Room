﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtiliesRDoorAnimation : MonoBehaviour {

    Animator anim;
    bool doorOpen = false;
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
            return;
        }
        GameObject.Find("Hint11").GetComponent<AudioSource>().Play();
    }
}
