using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class UITutorialTrigger : MonoBehaviour {

    public GameObject UITutorialNext;
    public GameObject AudioHint;

    // Use this for initialization
    void Start()
    {
        
    }

    public void PlayAudioHint()
    {
        StartCoroutine(AudioHint02());
    }

    IEnumerator AudioHint02()
    {
        yield return new WaitForSeconds(1);
        AudioHint.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update () {
        if (GameObject.Find("UITutorialTrigger").GetComponent<MeshRenderer>().enabled)
        {
            if (SteamVR_Input._default.inActions.TriggerAction.GetStateDown(SteamVR_Input_Sources.Any))
            {
                print("Trigger delete");
                //ITutorialNext.GetComponent<MeshRenderer>().enabled = true;
                Destroy(GameObject.Find("UITutorialTrigger"));

            }
        }
    }
}
