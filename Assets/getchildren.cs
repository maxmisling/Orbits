using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getchildren : MonoBehaviour
{
    private List<Transform> grandChildren = new List<Transform>();

    void Start()
    {
        // Get children of children of the current game object
        GetGrandChildren(transform);

        // Print the names of all children of children
        foreach (Transform child in grandChildren)
        {
            Debug.Log(child.name);
        }
    }

    void GetGrandChildren(Transform parent)
    {
        foreach (Transform child in parent)
        {
            //Debug.Log(child.name);

            // Get children of the current child
            foreach (Transform grandChild in child)
            {
                //Debug.Log(grandChild.name);
                grandChildren.Add(grandChild);
            }
        }
    }
}
