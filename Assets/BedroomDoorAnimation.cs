using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomDoorAnimation : MonoBehaviour {

    bool bedroomDoorOpen;
    Animator bedroomDoorAnim;

    // Use this for initialization
    void Start()
    {
        bedroomDoorAnim = GetComponent<Animator>();
    }


    void Trigger()
    {
        print("Hello!");
        if (bedroomDoorOpen)
        {
            bedroomDoorAnim.SetBool("openDoor", false);
            bedroomDoorOpen = false;
        }
        else
        {
            bedroomDoorAnim.SetBool("openDoor", true);
            bedroomDoorOpen = true;
        }
    }
}
