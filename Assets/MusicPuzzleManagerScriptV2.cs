using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPuzzleManagerScriptV2 : MonoBehaviour {

    public GameObject[] noteManagers;

    int[] answer = [1, 2, 3, 4, 7, 8, 4, 2];

    public void checkCorrect()
    {

        for(int x = 0; x < noteManagers.Length; x++)
        {
            print(noteManagers[x].GetComponent<NoteManager>().note);
        }
    }

}
