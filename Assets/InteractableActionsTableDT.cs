using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsTableDT : MonoBehaviour {

    public GameObject drawer;
    bool obOpen;
    Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = drawer.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Trigger()
    {
        obOpen = !obOpen;
        animator.SetBool("openDrawer", obOpen);
    }

}
