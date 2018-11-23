using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsWardrobeDBL : MonoBehaviour {

    public GameObject handle5;
    bool handle5Open;
    Animator handle5Anim;

    // Use this for initialization
    void Start()
    {
        handle5Anim = handle5.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Trigger()
    {
        handle5Open = !handle5Open;
        handle5Anim.SetBool("openWardrobe", handle5Open);
    }
}
