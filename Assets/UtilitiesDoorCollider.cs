using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilitiesDoorCollider : MonoBehaviour {

    bool isKeyInRange = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "UtilitiesRoomKey")
        {
            isKeyInRange = true;
            print(isKeyInRange);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "UtilitiesRoomKey")
        {
            isKeyInRange = false;
            print(isKeyInRange);
        }
    }

    public bool Check()
    {
        //print("Check has been called!");
        if (isKeyInRange)
        {
            LevelManager.UnlockUtiliesRoom();

            return true;
        }
        return false;
    }
}
