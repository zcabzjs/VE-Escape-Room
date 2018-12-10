using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class CustomCameraScript : MonoBehaviour {

    public void FadeToBlack()
    {
        StartCoroutine(FadeToColour());
    }

    IEnumerator FadeToColour()
    {

        yield return new WaitForSeconds(4);
        //set start color
        SteamVR_Fade.Start(Color.clear, 0f);
        //set and start fade to
        SteamVR_Fade.Start(Color.black, 5f);
        SteamVR_LoadLevel.Begin("EndScene");
    }

}
