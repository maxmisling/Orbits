using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddColours : MonoBehaviour
{

    private List<Transform> grandChildren = new List<Transform>();

    //public GameObject[] myObjects;
    public Material myMaterial;


    // Start is called before the first frame update
    void Start()
    {
        // Get children of children of the current game object
        GetGrandChildren(transform);

        // Print the names of all children of children
        foreach (Transform child in grandChildren)
        {
            Debug.Log(child.name);
        }


        foreach (var myObject in grandChildren)
        {
            myObject.GetComponent<Renderer>().material = myMaterial;
        }

/*        foreach (var myObject in myObjects)
        {
            myObject.GetComponent<Renderer>().material = myMaterial;
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        //myObject.GetComponent<Renderer>().material = myMaterial;
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



