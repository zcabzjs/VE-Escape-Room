using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsBatteries : MonoBehaviour {

    public GameObject flashLight;
    public GameObject batteryCollider;

    void OnHoldTrigger()
    {
        if (batteryCollider.GetComponent<BatteryTriggerColliderScript>().isFlashlightInRange)
        {
            flashLight.GetComponent<InteractableActionsFlashlight>().batteryState = true;
            Destroy(GameObject.Find("Battery"));
        }
    }
}
