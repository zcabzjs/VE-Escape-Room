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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray.origin, ray.direction, out raycastHit, Mathf.Infinity))
            {
                if (raycastHit.transform.name == "Trash Can")
                {
                    if (trashCanOpen)
                    {
                        trashCanAnim.SetBool("openTrashCan", false);
                        trashCanOpen = false;
                
                    }
                    else
                    {
                        trashCanAnim.SetBool("openTrashCan", true);
                        trashCanOpen = true;
                    }
                }
            }
        }
    }
}
