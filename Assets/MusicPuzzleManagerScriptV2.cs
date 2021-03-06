﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPuzzleManagerScriptV2 : MonoBehaviour {

    public GameObject[] noteManagers;
    public GameObject soundManager;
    public Material[] materials;
    public GameObject powerLight;

    int[] answer = new int[] { 0, 1, 2, 3, 6, 7, 3, 1 };
    int[] entries = new int[] { -1, -1, -1, -1, -1, -1, -1, -1 };

    public bool CheckCorrect()
    {
        bool result = true;
        for(int x = 0; x < noteManagers.Length; x++)
        {
            print(noteManagers[x].GetComponent<NoteManager>().note);
            entries[x] = noteManagers[x].GetComponent<NoteManager>().note;
            if (answer[x] != noteManagers[x].GetComponent<NoteManager>().note)
            {
                // There is a wrong answer
                result = false;
            }
        }
        soundManager.GetComponent<SoundManagerScript>().PlayEntry(entries, result);
        if (result)
        {
            LevelManager.RecoverElectricity();
        }
        return result;
    }

    public void PowerLEDSuccess()
    {
        powerLight.GetComponent<MeshRenderer>().material = materials[1];
    }

    public void PowerLEDFailed()
    {
        powerLight.GetComponent<MeshRenderer>().material = materials[3];
    }

    public void PowerLEDNormal()
    {
        powerLight.GetComponent<MeshRenderer>().material = materials[2];
    }
}
