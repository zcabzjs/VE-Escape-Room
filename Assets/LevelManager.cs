using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    //Call this by LevelManager.BooleanName;

    public static bool tutorialCompleted;     //  flag for completion of tutorial

    public static bool hasElectricity = true;        //  flag for after electricity is triggered

    public static bool usbInserted;           //  flag for after USB is inserted (Assuming USB can only be put in after theres electricity...)

    public static bool utilitiesRoomUnlocked = false;

    public static void CompleteTutorial()
    {
        tutorialCompleted = true;
        // Do stuff here related to the completion ??
        // Turn shit off
        hasElectricity = false;
        GameObject.Find("AmazonEcho").GetComponent<AudioSource>().Pause();
        // Insert voiceline here? Or cues...
    }

    public static void RecoverElectricity()
    {
        hasElectricity = true;
        // Do we turn shit on here? (Laptop and music)
        // Insert voiceline and cues here..
    }

    public static void InsertUSB()
    {
        usbInserted = true;
        // Cues to submit coursework I guess...
        // Change to monitor?

    }

    public static void UnlockUtiliesRoom()
    {
        utilitiesRoomUnlocked = true;
        // Cues when unlocking room
    }
}
