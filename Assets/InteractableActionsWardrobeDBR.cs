using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsWardrobeDBR : MonoBehaviour {

    public GameObject handle4;
    bool handle4Open;
    Animator handle4Anim;

    // Use this for initialization
    void Start()
    {
        handle4Anim = handle4.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Trigger()
    {
        handle4Open = !handle4Open;
        handle4Anim.SetBool("openWardrobe", handle4Open);
    }
}
