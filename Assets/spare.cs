/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class getchildren : MonoBehaviour
{

    //public Transform meeple;
    //public GameObject grandChild;

    void Start()
    {
        // Get all children of the current game object
        Transform[] children = GetChildren(transform);


        // Print the names of all children
        foreach (Transform child in children)
        {
            Debug.Log(child.name);
        }
        //Assigns the transform of the first child of the Game Object this script is attached to.
        //Transform meeple = this.gameObject.transform.GetChild(0);
        //Debug.Log(meeple.name);

        //Assigns the first child of the first child of the Game Object this script is attached to.
        //Transform[] grandChildren = this.gameObject.transform.GetChild(0).GetChild(0);
        //Debug.Log(grandChild.name);

        //this.transform.childCount
        //Transform[] allchildren = this.transform.GetComponentsChildren<Transform>(true);
        //List<Transform> grandchildren = new();

        *//*        foreach (Transform child in transform)
                {
                    Debug.Log(child.name);
                    grandchildren.Add(child);
                }*//*

        //List<Transform> grandchildren = new();
        //this.gameObject.transform.GetChild(i).GetChild(i);//this.transform.GetComponentsInChildren<Transform>(true); 
        //Transform[] grandchildren = GetChildren(transform);
    }

    Transform[] GetChildren(Transform parent)
    {
        Transform[] children = new Transform[parent.childCount];
        for (int i = 0; i < parent.childCount; i++)
        {
            Debug.Log(i);
            children[i] = this.gameObject.transform.GetChild(i).GetChild(i);
        }
        return children;
    }
    //Debug.Log(allchildren[i].name);
    //Transform[] grandChildren = this.gameObject.transform.GetChild(i).GetChild(i);
    //Debug.Log(grandChild.name);
    //listchildren.Add(child);
}


{
    // Start is called before the first frame update
    void Start()
    {
        //Transform child = transform.Find("001");
        //Transform child = transform.GetChild(1);
        //Debug.Log(child.name);

        List<Transform> children = new();
        //List<Transform> innerchildren = new();

        foreach (Transform child in transform)
        {
            Debug.Log(child.name);
            children.Add(child);
            Transform innerchild = transform.GetChild(0);
            Debug.Log(innerchild.name);
            foreach (Transform innerchild in transform)
            {
                Debug.Log(innerchild.name);
                children.Add(innerchild);
            }
        }

        Debug.Log("Count: " + children.Count);
        //Debug.Log("Count: " + innerchildren.Count);

    }
/

public class getchildren : MonoBehaviour
{
    void Start()
    {
        foreach (Transform g in transform.GetComponentsInChildren<Transform>())
        {
            Debug.Log(g.name);
        }
    }
}






*/