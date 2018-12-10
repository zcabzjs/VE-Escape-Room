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
        }
    }

    IEnumerator EndTutorial()
    {
        yield return new WaitForSecondsRealtime(5);
        turnOff();
        LevelManager.CompleteTutorial();
        
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
        } else if (LevelManager.usbInserted) {
            Material[] currentMaterials;
            currentMaterials = meshRenderer.materials;
            currentMaterials[2] = materials[3];
            meshRenderer.materials = currentMaterials;
            LevelManager.GameCompleted();
        }
    }
}
