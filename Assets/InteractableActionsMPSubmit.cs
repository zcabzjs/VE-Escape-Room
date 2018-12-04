using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsMPSubmit : MonoBehaviour {

    public GameObject musicPuzzleManager;

    void Trigger()
    {
        musicPuzzleManager.GetComponent<MusicPuzzleManagerScriptV2>().checkCorrect();
    }
}
