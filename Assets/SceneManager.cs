using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {

    public int currLevel = 1;

    public string[] levelNames = new string[2]{"StartScene", "Scene3"};

    static SceneManager s = null;

    private static float _fadeDuration = 2;
	// Use this for initialization
	void Start () {
		if(s == null)
        {
            s = this;      
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.anyKeyDown)
        //{
        //    currLevel = (currLevel + 1) % 2;
        //    SteamVR_LoadLevel.Begin(levelNames[currLevel]);
        //}
	}

    public static void LoadPlayLevel()
    {

        //First uses Steam VR transition, 2nd uses Unity transition

        SteamVR_LoadLevel.Begin("Scene3");
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Scene3");
    }
}
