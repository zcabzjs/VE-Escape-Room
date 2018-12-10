using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class UITutorialTrigger : MonoBehaviour {

    public GameObject UITutorialNext;
    public GameObject AudioHint2;
    public GameObject AudioHint6;

    // Use this for initialization
    void Start()
    {
        
    }

    public void PlayAudioHint2()
    {
        StartCoroutine(AudioHint02());
    }

    IEnumerator AudioHint02()
    {
        yield return new WaitForSeconds(5);
        AudioHint2.GetComponent<AudioSource>().Play();
    }

    public void PlayAudioHint6()
    {
        StartCoroutine(AudioHint06());
    }

    IEnumerator AudioHint06()
    {
        yield return new WaitForSeconds(0.5f);
        AudioHint6.GetComponent<AudioSource>().Play();
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
