using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBoxDoorCollider : MonoBehaviour {

    public GameObject door;

    public bool isMusicKeyInRange = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "KeyMusic")
        {
            isMusicKeyInRange = true;
            print(isMusicKeyInRange);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "KeyMusic")
        {
            isMusicKeyInRange = false;
            print(isMusicKeyInRange);
        }
    }

    // This function is called from the KeyMusic Trigger() function
    public bool Check()
    {
        if (isMusicKeyInRange)
        {
            door.GetComponent<InteractableActionsMPDoor>().isKeyOnDoor = true;
            return true;
        }
        return false;
    }
}
