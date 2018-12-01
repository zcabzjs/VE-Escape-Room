using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchToggle : MonoBehaviour {

    bool switchOn = false;
    public ceilingLightToggle ceilingLightToggle;
    
    GameObject switchPivot;
    Light ceilingLight;
	// Use this for initialization
	void Start () {
        switchPivot = this.gameObject.transform.GetChild(0).gameObject;
	}

    // Update is called once per frame
    void Trigger()
    {
        if (switchOn)
        {
            switchTurnOff();
        }
        else
        {
            switchTurnOn();
        }
    }

    void switchTurnOff()
    {
        //Do something with light
        switchOn = false;
        //Debug.Log("Off!");
        switchPivot.transform.Rotate(20, 0, 0);
        ceilingLightToggle.turnOff();
    }

    void switchTurnOn()
    {
        //Do something else with light
        switchOn = true;
        Debug.Log("On!");
        switchPivot.transform.Rotate(-20, 0, 0);
        ceilingLightToggle.turnOn();
    }
}
