using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsMPUp : MonoBehaviour {

    public GameObject noteManager;

    void Trigger()
    {
        noteManager.GetComponent<NoteManager>().noteUp();
    }

}
