using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITriggerCollider : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "BodyCollider")
        {
            Debug.Log("Person Walked through");
            Destroy(GameObject.Find("UITriggerCollider"));
            GameObject.Find("UITutorialTrigger").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("UITutorialTrigger").GetComponent<UITutorialTrigger>().PlayAudioHint();
        }
    }
}
