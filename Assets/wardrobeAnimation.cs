using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wardrobeAnimation : MonoBehaviour {

    public GameObject leftDoor;
    public GameObject rightDoor;
    public GameObject handle3;
    public GameObject handle4;
    public GameObject handle5;
    public GameObject handle6;

    bool leftDoorOpen;
    bool rightDoorOpen;
    bool handle3Open;
    bool handle4Open;
    bool handle5Open;
    bool handle6Open;

    Animator leftDoorAnim;
    Animator rightDoorAnim;
    Animator handle3Anim;
    Animator handle4Anim;
    Animator handle5Anim;
    Animator handle6Anim;

    // Use this for initialization
    void Start () {
        leftDoorAnim = leftDoor.GetComponent<Animator>();
        rightDoorAnim = rightDoor.GetComponent<Animator>();
        handle3Anim = handle3.GetComponent<Animator>();
        handle4Anim = handle4.GetComponent<Animator>();
        handle5Anim = handle5.GetComponent<Animator>();
        handle6Anim = handle6.GetComponent<Animator>();
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
                if (raycastHit.transform.name == "handle_01")
                {
                    if (leftDoorOpen)
                    {
                        leftDoorAnim.SetBool("openWardrobe", false);
                        leftDoorOpen = false;
                    }
                    else
                    {
                        leftDoorAnim.SetBool("openWardrobe", true);
                        leftDoorOpen = true;
                    }
                }
                else if (raycastHit.transform.name == "handle_02")
                {
                    if (rightDoorOpen)
                    {
                        rightDoorAnim.SetBool("openWardrobe", false);
                        rightDoorOpen = false;
                    }
                    else
                    {
                        rightDoorAnim.SetBool("openWardrobe", true);
                        rightDoorOpen = true;
                    }
                }
                else if(raycastHit.transform.name == "handle_03")
                {
                    if (handle3Open)
                    {
                        handle3Anim.SetBool("openWardrobe", false);
                        handle3Open = false;
                    }
                    else
                    {
                        handle3Anim.SetBool("openWardrobe", true);
                        handle3Open = true;
                    }
                }
                else if(raycastHit.transform.name == "handle_04")
                {
                    if (handle4Open)
                    {
                        handle4Anim.SetBool("openWardrobe", false);
                        handle4Open = false;
                    }
                    else
                    {
                        handle4Anim.SetBool("openWardrobe", true);
                        handle4Open = true;
                    }
                }
                else if(raycastHit.transform.name == "handle_05")
                {
                    if (handle5Open)
                    {
                        handle5Anim.SetBool("openWardrobe", false);
                        handle5Open = false;
                    }
                    else
                    {
                        handle5Anim.SetBool("openWardrobe", true);
                        handle5Open = true;
                    }
                }
                else if(raycastHit.transform.name == "handle_06")
                {
                    if (handle6Open)
                    {
                        handle6Anim.SetBool("openWardrobe", false);
                        handle6Open = false;
                    }
                    else
                    {
                        handle6Anim.SetBool("openWardrobe", true);
                        handle6Open = true;
                    }
                }
            }
        }
    }
}
