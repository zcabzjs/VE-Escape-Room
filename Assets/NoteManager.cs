using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour {

    public int note = 0;

    public GameObject[] lights;
    public Material[] materials;

    public void noteUp()
    {
        if (note == 7)
        {
            return;
        }
        note++;
        lights[note].GetComponent<MeshRenderer>().material = materials[1];
    }

    public void noteDown()
    {
        if (note == 0)
        {
            return;
        }
        lights[note].GetComponent<MeshRenderer>().material = materials[0];
        note--;
    }

}
