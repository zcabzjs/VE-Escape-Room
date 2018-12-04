using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsMPDown : MonoBehaviour {

    public GameObject noteManager;

    void Trigger()
    {
        noteManager.GetComponent<NoteManager>().noteDown();
    }
}
