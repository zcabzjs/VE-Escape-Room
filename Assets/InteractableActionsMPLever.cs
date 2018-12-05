using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsMPLever : MonoBehaviour {

    Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Trigger()
    {
        animator.SetTrigger("");
    }

}
