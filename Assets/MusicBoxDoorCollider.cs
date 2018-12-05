using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class MusicBoxDoorCollider : MonoBehaviour {

    public GameObject door;
    public GameObject[] interactablesDisabled;

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
            // Activate interactables

            for (int x = 0; x < interactablesDisabled.Length; x++)
            {
                interactablesDisabled[x].GetComponent<Interactable>().enabled = true;
            }

            return true;
        }
        return false;
    }
}
