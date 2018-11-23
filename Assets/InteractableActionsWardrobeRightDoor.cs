using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsWardrobeRightDoor : MonoBehaviour {

    public GameObject rightDoor;
    bool rightDoorOpen;
    Animator rightDoorAnim;

    // Use this for initialization
    void Start () {
        rightDoorAnim = rightDoor.GetComponent<Animator>();
    }
	
	void Trigger () {
        rightDoorOpen = !rightDoorOpen;
        rightDoorAnim.SetBool("openWardrobe", rightDoorOpen);
    }
}
