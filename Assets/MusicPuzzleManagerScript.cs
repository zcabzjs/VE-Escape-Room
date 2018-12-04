using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPuzzleManagerScript : MonoBehaviour {

    public GameObject[] lights;
    public Material[] materials;

    int[] puzzleAnswer = new int[] { 1, 5, 3,2,1 };
    int[] entries = new int[] { -1, -1, -1, -1, -1 };
    int currentEntryPos = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addEntry(int note)
    {
        entries[currentEntryPos] = note;
        lights[currentEntryPos].GetComponent<MeshRenderer>().material = materials[1];
        currentEntryPos += 1;
        printEntries();
    }

    public void resetEntries()
    {
        currentEntryPos = 0;
        for(int x = 0; x < entries.Length; x++)
        {
            entries[x] = -1;
            lights[x].GetComponent<MeshRenderer>().material = materials[0];
        }
        printEntries();
    }

    public void printEntries()
    {
        for (int x = 0; x < entries.Length; x++)
        {
            print(entries[x]);
        }
    }

}
