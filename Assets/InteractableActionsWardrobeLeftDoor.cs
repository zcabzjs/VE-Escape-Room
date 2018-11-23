using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsWardrobeLeftDoor : MonoBehaviour {

    public GameObject leftDoor;
    Animator leftDoorAnim;
    bool leftDoorOpen;

    // Use this for initialization
    void Start()
    {
        leftDoorAnim = leftDoor.GetComponent<Animator>();
    }

    void Trigger()
    {

        leftDoorOpen = !leftDoorOpen;
        leftDoorAnim.SetBool("openWardrobe", leftDoorOpen);
    }
}
