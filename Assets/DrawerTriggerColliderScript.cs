using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerTriggerColliderScript : MonoBehaviour {

    public GameObject draw;

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        other.gameObject.transform.SetParent(draw.transform, true);
        //moveObject(other.gameObject, other.gameObject);

    }

    void OnTriggerExit(Collider other)
    {
        //other.gameObject.transform.SetParent(GameObject.Find("ThrowableObjects").transform, true);
    }

    void moveObject(GameObject source, GameObject destination)
    {
        ArrayList al = new ArrayList();
        createArrayListOfTree(al, source);
        foreach (MoveObjectProperties mop in al)
        {
            print(mop.node.name);
        }
    }

    void createArrayListOfTree(ArrayList al, GameObject node)
    {
        foreach(Transform go in node.transform)
        {
            al.Add(new MoveObjectProperties(go.gameObject, node));
            createArrayListOfTree(al, go.gameObject);
        }
    }

    class MoveObjectProperties
    {
        public GameObject node;
        public GameObject parent;

        public MoveObjectProperties(GameObject node, GameObject parent)
        {
            this.node = node;
            this.parent = parent;
        }
    }
}
