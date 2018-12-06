using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableActionsMPLever : MonoBehaviour {

    public GameObject musicManager;

    Animator animator;
    bool resultFromManager;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        //musicManager = GameObject.Find("MusicPuzzleManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Trigger()
    {
        animator.SetTrigger("tryAnswer");
        bool resultFromManager = musicManager.GetComponent<MusicPuzzleManagerScriptV2>().CheckCorrect();
        if (!resultFromManager)
        {
            //StartCoroutine(AutoPullUpLever());
        }
    }

    public void PullLeverUp()
    {
        animator.SetTrigger("wrongAnswer");
    }

    IEnumerator AutoPullUpLever()
    {
        yield return new WaitForSecondsRealtime(2);
        animator.SetTrigger("wrongAnswer");

    }

}
