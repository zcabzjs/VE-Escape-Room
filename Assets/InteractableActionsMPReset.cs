using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsMPReset : MonoBehaviour {

    public GameObject musicController;

    void Trigger()
    {
        musicController.GetComponent<MusicPuzzleManagerScript>().resetEntries();
    }

}
