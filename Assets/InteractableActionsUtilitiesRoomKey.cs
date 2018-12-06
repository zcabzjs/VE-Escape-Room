using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsUtilitiesRoomKey : MonoBehaviour {

    public GameObject doorCollider;

	void OnHoldTrigger()
    {
        if (doorCollider.GetComponent<UtilitiesDoorCollider>().Check())
        {
            // If the key is in range, destory the key
            Destroy(GameObject.Find("UtilitiesRoomKey"));
        }
    }
}
