using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class UITutorialGrab : MonoBehaviour {

    //public GameObject UITutorialTrigger;
    bool firstClickIgnore = false;

    public GameObject AudioHint;

    // Use this for initialization
    void Start()
    {

    }

    public void PlayAudioHint()
    {
        StartCoroutine(AudioHint03());
    }

    IEnumerator AudioHint03()
    {
        yield return new WaitForSeconds(1);
        AudioHint.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update () {
        if (GameObject.Find("UITutorialGrab").GetComponent<MeshRenderer>().enabled)
        {
            if (SteamVR_Input._default.inActions.TriggerAction.GetStateDown(SteamVR_Input_Sources.Any))
            {
                if (!firstClickIgnore)
                {
                    firstClickIgnore = !firstClickIgnore;
                } else
                {
                    Destroy(GameObject.Find("UITutorialGrab"));
                }
                print("Grab trigger!");
                //UITutorialTrigger.GetComponent<MeshRenderer>().enabled = true;
                //Destroy(GameObject.Find("UITutorialGrab"));
            }
        }
    }
}
