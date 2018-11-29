using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsFlashlight : MonoBehaviour {

    public GameObject spotlight;
    public GameObject lense;
    

    private Light light;
    bool onState = false;
    public bool batteryState = false;

    private MeshRenderer lenseMR;

    void OnHoldTrigger()
    {
        if (batteryState)
        {
            onState = !onState;
            light.enabled = onState;
            lenseMR.enabled = onState;
        }
    }

    // Use this for initialization
    void Start()
    {
        light = spotlight.GetComponent<Light>();
        lenseMR = lense.GetComponent<MeshRenderer>();
    }
}
