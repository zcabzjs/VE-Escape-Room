using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActions : MonoBehaviour {

    public virtual void onHoldTrigger()
    {
        Debug.Log("Item.SomeFunction");
    }

}
