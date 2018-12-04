using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBoxDoorCollider : MonoBehaviour {

    public bool isMusicKeyInRange = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "KeyMusic")
        {
            isMusicKeyInRange = true;
            print(isMusicKeyInRange);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "KeyMusic")
        {
            isMusicKeyInRange = false;
            print(isMusicKeyInRange);
        }
    }
}
