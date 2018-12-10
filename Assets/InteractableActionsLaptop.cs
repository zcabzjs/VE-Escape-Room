using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsLaptop : MonoBehaviour {

    public GameObject alexa;
    public GameObject wallSocket;
    public Material[] materials;

    MeshRenderer meshRenderer;
    bool onState = false;

    void Trigger()
    {
        if (LevelManager.hasElectricity)
        {
            if (wallSocket.GetComponent<TutorialSwitchToggle>().turnedOn)
            {
                onState = !onState;
                if (onState)
                {
                    print("Turn On");
                    turnOn();
                    if (LevelManager.tutorialCompleted == false)
                    {
                        print("Blah");
                        StartCoroutine(EndTutorial());
                    }
                    return;
                }
                else
                {
                    print("Turn off");
                    turnOff();
                    return;
                }
            }
            turnOff();
        }
        if (GameObject.Find("UITutorialGrab") != null)
        {
            GameObject.Find("UITutorialGrab").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("UITutorialGrab").GetComponent<UITutorialGrab>().PlayAudioHint();
            StartCoroutine(AudioHint07());
        }
    }

    IEnumerator EndTutorial()
    {
        yield return new WaitForSecondsRealtime(2);
        turnOff();
        yield return new WaitForSecondsRealtime(0.5f);
        GameObject.Find("Hint08").GetComponent<AudioSource>().Play();
        //yield return new WaitForSecondsRealtime(2);
        //GameObject.Find("Hint09").GetComponent<AudioSource>().Play();
        LevelManager.CompleteTutorial();
    }

    IEnumerator AudioHint07()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        GameObject.Find("Hint07").GetComponent<AudioSource>().Play();
    }

    // Use this for initialization
    void Start()
    {
        meshRenderer = GameObject.Find("Cube.004").GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void turnOn()
    {
        onState = true;
        Material[] currentMaterials;
        currentMaterials = meshRenderer.materials;
        currentMaterials[2] = materials[1];
        meshRenderer.materials = currentMaterials;
    }

    public void turnOff()
    {
        onState = false;
        Material[] currentMaterials;
        currentMaterials = meshRenderer.materials;
        currentMaterials[2] = materials[0];
        meshRenderer.materials = currentMaterials;
    }

    public void UploadWork()
    {
        if (!LevelManager.usbInserted)
        {
            Material[] currentMaterials;
            currentMaterials = meshRenderer.materials;
            currentMaterials[2] = materials[2];
            meshRenderer.materials = currentMaterials;
            StartCoroutine(AudioHint22());
            StartCoroutine(AudioHint23());
        } else if (LevelManager.usbInserted) {
            Material[] currentMaterials;
            currentMaterials = meshRenderer.materials;
            currentMaterials[2] = materials[3];
            meshRenderer.materials = currentMaterials;
            StartCoroutine(AudioHint25());
            LevelManager.GameCompleted();
        }
    }

    IEnumerator AudioHint22()
    {
        yield return new WaitForSeconds(0.5f);
        GameObject.Find("Hint22").GetComponent<AudioSource>().Play();
    }

    IEnumerator AudioHint23()
    {
        yield return new WaitForSeconds(5f);
        GameObject.Find("Hint23").GetComponent<AudioSource>().Play();
    }

    IEnumerator AudioHint25()
    {
        yield return new WaitForSeconds(0.5f);
        GameObject.Find("Hint25").GetComponent<AudioSource>().Play();
    }
}
