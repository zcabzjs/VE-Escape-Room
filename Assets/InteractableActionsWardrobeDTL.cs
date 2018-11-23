using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsWardrobeDTL : MonoBehaviour {

    public GameObject handle6;
    bool handle6Open;
    Animator handle6Anim;

    // Use this for initialization
    void Start () {
        handle6Anim = handle6.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Trigger () {
        handle6Open = !handle6Open;
        handle6Anim.SetBool("openWardrobe", handle6Open);
    }
}
