using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTrash : MonoBehaviour {

    public SideQuest sideQuest;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    	
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.isTrigger)
        {
            if (other.gameObject.CompareTag("Trash"))
            {  
                sideQuest.AddTrash(other.gameObject);
                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.isTrigger)
        {
            if (other.gameObject.CompareTag("Trash"))
            {
                sideQuest.RemoveTrash(other.gameObject);
            }
        }

    }
}
