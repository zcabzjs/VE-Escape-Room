using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideQuest : MonoBehaviour {

    public static int targetNumber = 3;
    public static int collectedTrash = 0;
    public static List<GameObject> trashList;

    public static void AddTrash(GameObject obj)
    {
        
        if (!trashList.Contains(obj))
        {
            trashList.Add(obj);
            Debug.Log("Trash added");
            collectedTrash = trashList.Count;
        }
        if(trashList.Count == targetNumber)
        {

            Debug.Log("You did it!");
        }
        
    }

    public static void RemoveTrash(GameObject obj)
    {
        if (trashList.Contains(obj))
        {
            trashList.Remove(obj);
            Debug.Log("Trash removed");
            collectedTrash = trashList.Count;
        }
        
    }

    
}
