using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilitiesRoomEntryCollider : MonoBehaviour {

    bool played = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "BodyCollider")
        {
            print("sdfsdffsdf");
            if (!played)
            {
                played = true;
                GameObject.Find("Hint13").GetComponent<AudioSource>().Play();
                StartCoroutine(Hint14Audio());
            }
            
        }
    }

    IEnumerator Hint14Audio()
    {
        yield return new WaitForSecondsRealtime(3);
        GameObject.Find("Hint14").GetComponent<AudioSource>().Play();
    }
}
