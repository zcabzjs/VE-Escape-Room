using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBoxDoorCollider : MonoBehaviour {

    public GameObject door;

    public bool isMusicKeyInRange = false;

    void OnTriggerEnter(Collider other)
    {
        //print(other.gameObject.name);
        if (other.gameObject.name == "KeyMusicCollder1")
        {
            isMusicKeyInRange = true;
            print(isMusicKeyInRange);
        }
    }

    void OnTriggerExit(Collider other)
    {
        //print(other.gameObject.name);
        if (other.gameObject.name == "KeyMusicCollder1")
        {
            isMusicKeyInRange = false;
            print(isMusicKeyInRange);
        }
    }

    // This function is called from the KeyMusic Trigger() function
    public bool Check()
    {
        //print("Check has been called!");
        if (isMusicKeyInRange)
        {
            door.GetComponent<InteractableActionsMPDoor>().isKeyOnDoor = true;
            return true;
        }
        return false;
    }
}
