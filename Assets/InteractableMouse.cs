using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableMouse : MonoBehaviour {

    public GameObject laptop;

	void Trigger()
    {
        laptop.GetComponent<InteractableActionsLaptop>().UploadWork();
    }

}
