using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScreenInteraction : MonoBehaviour {

    public Material[] materials;
    MeshRenderer meshRenderer;
    bool laptopTriggered;
    // Use this for initialization
    void Start () {
        meshRenderer = GameObject.Find("Screen").GetComponent<MeshRenderer>();
        StartCoroutine(ChangeFromCreditsToTheEnd());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator ChangeFromCreditsToTheEnd()
    {
        for (float timer = 5; timer >= 0; timer -= Time.deltaTime)
        {
            if (laptopTriggered)
            {
                switchToPlotTwistEnd();
                yield break;
            }
            yield return null;
        }
        switchtoTheEndScreen();
    }

    void switchtoTheEndScreen()
    {
        meshRenderer.material = materials[0];
    }

    void switchToPlotTwistEnd()
    {
        meshRenderer.material = materials[1];      
    }

    public void triggerLaptop()
    {
        laptopTriggered = true;
        switchToPlotTwistEnd();
    }
}
