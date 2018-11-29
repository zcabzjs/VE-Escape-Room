using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableUtilSwitchTest : MonoBehaviour {

    private bool onState = true;
    public GameObject lightObject1;
    public GameObject lightObject2;
    public GameObject lightObject3;

    private Light light1;
    private Light light2;
    private Light light3;

    void Trigger()
    {
        print("Lights off!");
        onState = !onState;
        /*light1.enabled = onState;
        light2.enabled = onState;
        light3.enabled = onState;*/
        lightObject1.SetActive(onState);
        lightObject2.SetActive(onState);
        lightObject3.SetActive(onState);
    }

	// Use this for initialization
	void Start () {
        /*
        light1 = lightObject1.GetComponent<Light>();
        light2 = lightObject2.GetComponent<Light>();
        light3 = lightObject3.GetComponent<Light>();*/
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
