using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilitiesRoomKeyPuzzleCollider : MonoBehaviour {

    bool played = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "BodyCollider")
        {
            print("sdfsdffsdf");
            if (!played)
            {
                played = true;
                GameObject.Find("Hint17").GetComponent<AudioSource>().Play();
            }
            
        }
    }
}
