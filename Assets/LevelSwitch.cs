using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class LevelSwitch : MonoBehaviour {

    public int currLevel = 1;

    public string[] levelNames = new string[2] { "StartScene", "Scene3" };

    static LevelSwitch s = null;

    private static float _fadeDuration = 2;
    // Use this for initialization
    void Start()
    {
        if (s == null)
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
    void Update()
    {
        //if (Input.anyKeyDown)
        //{
        //    currLevel = (currLevel + 1) % 2;
        //    SteamVR_LoadLevel.Begin(levelNames[currLevel]);
        //}
    }

    public static void LoadPlayLevel()
    {
        //SteamVR_Fade.Start(Color.black, _fadeDuration);
        SteamVR_LoadLevel.Begin("Scene3");
        //SceneManager.LoadScene("Scene3");
    }
}
