using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryTriggerColliderScript : MonoBehaviour {

    private bool isFlashlightInRange = false;
    public GameObject flashLight;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Flashlight")
        {
            isFlashlightInRange = true;
            print(isFlashlightInRange);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Flashlight")
        {
            isFlashlightInRange = false;
            print(isFlashlightInRange);
        }
    }

    void OnHoldTrigger()
    {
        if (isFlashlightInRange)
        {
            flashLight.GetComponent<InteractableActionsFlashlight>().batteryState = true;
            Destroy(GameObject.Find("Battery"));
        }
    }

}
