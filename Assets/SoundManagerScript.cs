using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

    public GameObject[] audioNoteSources;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayEntry(int[] notes)
    {
        for (int x = 0; x < notes.Length; x++)
        {
            if(notes[x] == -1)
            {
                continue;
            } else
            {
                audioNoteSources[notes[x]].GetComponent<AudioSource>().Play();
            }
        }
    }
}
