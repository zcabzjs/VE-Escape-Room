using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorAnimation : MonoBehaviour {

    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    void Trigger()
    {
        anim.SetTrigger("openLockedDoor");
    }

}
