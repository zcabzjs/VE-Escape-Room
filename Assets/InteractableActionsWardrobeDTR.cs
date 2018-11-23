using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsWardrobeDTR : MonoBehaviour {

    public GameObject handle3;
    bool handle3Open;
    Animator handle3Anim;

    // Use this for initialization
    void Start()
    {
        handle3Anim = handle3.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Trigger()
    {
        handle3Open = !handle3Open;
        handle3Anim.SetBool("openWardrobe", handle3Open);
    }
}
