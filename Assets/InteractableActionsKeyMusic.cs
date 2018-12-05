using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsKeyMusic : MonoBehaviour {

    public GameObject musicPuzzleCollider;

    private void Start()
    {

    }

    // When the trigger is pulled
    void OnHoldTrigger()
    {
        //print("Trigger is pulled while holding Music Key");
        // If the key is in range, it will allow the door to open.
        if (musicPuzzleCollider.GetComponent<MusicBoxDoorCollider>().Check())
        {
            // If the key is in range, destory the key
            Destroy(GameObject.Find("KeyMusic"));
        }
    }
}
