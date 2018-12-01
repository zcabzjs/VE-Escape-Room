﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    //Call this by LevelManager.BooleanName;

    public static bool tutorialCompleted;     //  flag for completion of tutorial

    public static bool hasElectricity;        //  flag for after electricity is triggered

    public static bool usbInserted;           //  flag for after USB is inserted (Assuming USB can only be put in after theres electricity...)

    public static void CompleteTutorial()
    {
        tutorialCompleted = true;
        // Do stuff here related to the completion ??
        // Turn shit off
        hasElectricity = false;
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
}