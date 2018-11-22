using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableAnimations : MonoBehaviour {

    public GameObject drawer;
    public GameObject drawer2;
    public GameObject drawer3;
    public GameObject longDrawer;

    bool drawerOpen;
    bool drawer2Open;
    bool drawer3Open;
    bool longDrawerOpen;

    Animator drawerAnim;
    Animator drawer2Anim;
    Animator drawer3Anim;
    Animator longDrawerAnim;


    // Use this for initialization
    void Start () {
        drawerAnim = drawer.GetComponent<Animator>();
        drawer2Anim = drawer2.GetComponent<Animator>();
        drawer3Anim = drawer3.GetComponent<Animator>();
        longDrawerAnim = longDrawer.GetComponent<Animator>();

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
                if (raycastHit.transform.name == "Drawer")
                {
                    Debug.Log("Clicked Drawer");
                    if (drawerOpen)
                    {
                        drawerAnim.SetBool("openDrawer", false);
                        drawerOpen = false;
                    }
                    else
                    {
                        drawerAnim.SetBool("openDrawer", true);
                        drawerOpen = true;
                    }
                }
                else if (raycastHit.transform.name == "Drawer2")
                {
                    Debug.Log("Clicked Drawer 2");
                    if (drawer2Open)
                    {
                        drawer2Anim.SetBool("openDrawer", false);
                        drawer2Open = false;
                    }
                    else
                    {
                        drawer2Anim.SetBool("openDrawer", true);
                        drawer2Open = true;
                    }
                }
                else if (raycastHit.transform.name == "Drawer3")
                {
                    Debug.Log("Clicked Drawer 3");
                    if (drawer3Open)
                    {
                        drawer3Anim.SetBool("openDrawer", false);
                        drawer3Open = false;
                    }
                    else
                    {
                        drawer3Anim.SetBool("openDrawer", true);
                        drawer3Open = true;
                    }
                }
                else if(raycastHit.transform.name == "Long Drawer")
                {
                    Debug.Log("Clicked Long drawer");
                    if (longDrawerOpen)
                    {
                        longDrawerAnim.SetBool("openDrawer", false);
                        longDrawerOpen = false;
                    }
                    else
                    {
                        longDrawerAnim.SetBool("openDrawer", true);
                        longDrawerOpen = true;
                    }
                }
            }
        }
    }
}
