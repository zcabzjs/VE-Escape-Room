using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSwitchToggle : MonoBehaviour {

    bool turnedOn = false;
    GameObject switchPivot;
    // Use this for initialization
    void Start () {
        switchPivot = this.gameObject.transform.GetChild(0).gameObject;
    }
	
	// Update is called once per frame
	void Trigger() {
  
        if (!turnedOn)
        {
            Debug.Log("Tutorial started!");
            switchPivot.transform.Rotate(10, 0, 0);
            turnedOn = true;
            LevelManager.CompleteTutorial();
        }        

    }
}
