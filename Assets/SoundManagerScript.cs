using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

    public GameObject musicPuzzleManager;
    public GameObject[] audioNoteSources;
    public GameObject audioSuccess;
    public int[] timing;
    public float timingScaling;

    public GameObject lever;

    bool[] notePlayed = new bool[] {false, false, false, false, false, false, false, false };

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ResetNotePlayed()
    {
        for (int x = 0; x < notePlayed.Length; x++)
        {
            notePlayed[x] = false;
        }
    }

    public void PlayEntry(int[] notes, bool correct)
    {
        ResetNotePlayed();
        /*
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
        */
        for (int x = 0; x < notes.Length; x++)
        {
            if (notes[x] == -1)
            {
                continue;
            }
            else
            {
                StartCoroutine(QueueAudio(notes[x], x, timing[x]));
            }
        }
        if (!correct)
        {
            StartCoroutine(PullLever());
            StartCoroutine(TurnOnFailureLED());
        } else
        {
            StartCoroutine(TurnOnSuccessLED());
        }
    }

    // Timing 

    IEnumerator TurnOnSuccessLED()
    {
        yield return new WaitUntil(() => notePlayed[notePlayed.Length - 1] == true);
        musicPuzzleManager.GetComponent<MusicPuzzleManagerScriptV2>().PowerLEDSuccess();
        audioSuccess.GetComponent<AudioSource>().Play();
    }

    IEnumerator TurnOnFailureLED()
    {
        yield return new WaitUntil(() => notePlayed[notePlayed.Length - 1] == true);
        musicPuzzleManager.GetComponent<MusicPuzzleManagerScriptV2>().PowerLEDFailed();
        yield return new WaitForSeconds(3);
        musicPuzzleManager.GetComponent<MusicPuzzleManagerScriptV2>().PowerLEDNormal();
        //audioSuccess.GetComponent<AudioSource>().Play();
    }

    IEnumerator PullLever()
    {
        yield return new WaitUntil(() => notePlayed[notePlayed.Length - 1] == true);
        lever.GetComponent<InteractableActionsMPLever>().PullLeverUp();

    }

    IEnumerator QueueAudio(int note, int position, int time)
    {
        if (position != 0)
        {
            yield return new WaitUntil(() => notePlayed[position - 1] == true);
        }
        if (note != -1) {
            audioNoteSources[note].GetComponent<AudioSource>().Play();
        }
        yield return new WaitForSeconds(time * timingScaling);
        notePlayed[position] = true;

        // Code to execute after the delay
    }

    /*
    IEnumerator PlayAudio(int note, int time)
    {

        yield return new WaitForSeconds(time);
        audioNoteSources[notes[x]].GetComponent<AudioSource>().Play();

        // Code to execute after the delay
    }*/
}
