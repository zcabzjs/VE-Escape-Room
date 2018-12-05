using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsMPDoor : MonoBehaviour {

    public bool isKeyOnDoor = false;
    bool doorOpenState = false;

    Animator animation;

	// Use this for initialization
	void Start () {
        animation = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Trigger()
    {
        print(isKeyOnDoor);
        if (isKeyOnDoor)
        {
            print("Interact with door");
            print(doorOpenState);
            doorOpenState = !doorOpenState;
            animation.SetBool("openMusicPuzzle", doorOpenState);
        }
    }

}
