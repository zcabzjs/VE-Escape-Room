using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shelfAnimation : MonoBehaviour {

    public GameObject leftShelfDoor;
    public GameObject rightShelfDoor;

    bool leftShelfDoorOpen;
    bool rightShelfDoorOpen;

    Animator leftShelfDoorAnim;
    Animator rightShelfDoorAnim;
    // Use this for initialization
    void Start () {
        leftShelfDoorAnim = leftShelfDoor.GetComponent<Animator>();
        rightShelfDoorAnim = rightShelfDoor.GetComponent<Animator>();
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
                if(raycastHit.transform.name == "bookshelfLeftDoor")
                {
                    Debug.Log("Clicked on bookshelfleftdoor");
                    if (leftShelfDoorOpen)
                    {
                        leftShelfDoorAnim.SetBool("openShelf", false);
                        leftShelfDoorOpen = false;
                    }
                    else
                    {
                        leftShelfDoorAnim.SetBool("openShelf", true);
                        leftShelfDoorOpen = true;
                    }
                }
                else if (raycastHit.transform.name == "bookshelfRightDoor")
                {
                    Debug.Log("Clicked on bookshelfrightdoor");
                    if (rightShelfDoorOpen)
                    {
                        rightShelfDoorAnim.SetBool("openShelf", false);
                        rightShelfDoorOpen = false;
                    }
                    else
                    {
                        rightShelfDoorAnim.SetBool("openShelf", true);
                        rightShelfDoorOpen = true;
                    }
                }
            }
        }
    }
}
