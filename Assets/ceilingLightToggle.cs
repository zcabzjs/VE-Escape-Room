using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ceilingLightToggle : MonoBehaviour {

    public GameObject ceilingLamp;
    Light ceilingLight;
    MeshRenderer meshRenderer;
    public Material[] materials;
	// Use this for initialization
	void Start () {
        ceilingLight = ceilingLamp.GetComponent<Light>();
        meshRenderer = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void turnOn()
    {
        meshRenderer.material = materials[0];
        ceilingLight.enabled = true;
    }

    public void turnOff()
    {
        meshRenderer.material = materials[1];
        ceilingLight.enabled = false;
    }
}
