using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPuzzleManagerScriptV2 : MonoBehaviour {

    public GameObject[] noteManagers;

    int[] answer = new int[] { 0, 1, 2, 3, 6, 7, 3, 1 };

    public void checkCorrect()
    {
        for(int x = 0; x < noteManagers.Length; x++)
        {
            print(noteManagers[x].GetComponent<NoteManager>().note);
        }
    }

}
