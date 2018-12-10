using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class LaptopEndInteraction : MonoBehaviour {

    public Material[] materials;
    MeshRenderer meshRenderer;

    public EndGameScreenInteraction endGame;

    // Use this for initialization
    void Start () {
        meshRenderer = GameObject.Find("Laptop Screen").GetComponent<MeshRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            turnOnEndLaptop();
            endGame.triggerLaptop();
        }

    }

    void Trigger()
    {
        turnOnEndLaptop();
        endGame.triggerLaptop();
        StartCoroutine(quitGame());
    }

    void turnOnEndLaptop()
    {
        Material[] currentMaterials;
        currentMaterials = meshRenderer.materials;
        currentMaterials[2] = materials[0];
        meshRenderer.materials = currentMaterials;
    }

    IEnumerator quitGame()
    {
        yield return new WaitForSecondsRealtime(4);
        SteamVR_Fade.Start(Color.black, 2f);
        Application.Quit();
    }
}
