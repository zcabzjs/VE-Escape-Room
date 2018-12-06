using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskLightToggle : MonoBehaviour {

    public Material[] materials;
    public GameObject deskLightSource;
    MeshRenderer meshRenderer;
    Light desklight;
    public bool lightOn = false;
    public bool utilityDeskLight = false;
    void Start()
    {
        desklight = deskLightSource.GetComponent<Light>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Trigger()
    {
        if (utilityDeskLight)
        {
            toggleLight();
        }
        else
        {
            if (LevelManager.hasElectricity)
            {
                toggleLight();
            }
        }
        
    }
    // Use this for initialization
    public void toggleLight()
    {
        if (lightOn)
        {
            lightOn = false;
            desklight.enabled = false;
            meshRenderer.material = materials[1];
        }
        else
        {
            lightOn = true;
            desklight.enabled = true;
            meshRenderer.material = materials[0];
        }
    }
}
