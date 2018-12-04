using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPuzzleManagerScriptV2 : MonoBehaviour {

    public GameObject[] noteManagers;

    public void checkCorrect()
    {
        for(int x = 0; x < noteManagers.Length; x++)
        {
            print(noteManagers[x].GetComponent<NoteManager>().note);
        }
    }

}
