using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashCanAnimation : MonoBehaviour {

    bool trashCanOpen;

    Animator trashCanAnim;

	// Use this for initialization
	void Start () {
        trashCanAnim = GetComponent<Animator>();
    }

    void Trigger()
    {
        trashCanOpen = !trashCanOpen;
        trashCanAnim.SetBool("openTrashCan", trashCanOpen);

    }
}
