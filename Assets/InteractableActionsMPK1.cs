using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsMPK1 : MonoBehaviour {

    public GameObject musicController;
    public int value;

    void Trigger()
    {
        musicController.GetComponent<MusicPuzzleManagerScript>().addEntry(value);
    }
}
