using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScript : MonoBehaviour
{
    private LoadScene loadSceneScript; // Reference to the LoadScene script
    public string sceneName;

    private void Start()
    {
        // Get the LoadScene script component attached to the game object
        loadSceneScript = GetComponent<LoadScene>();
        //loadSceneScript.LoadNewScene();
    }

    public void OnClick()
    {
        SceneManager.LoadScene(sceneName);

        //loadSceneScript.LoadNewScene();
    }

    public void CreateCube()
    {


        // Create a new cube game object
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // Set the cube's position and scale
        cube.transform.position = transform.position;
        cube.transform.localScale = new Vector3(1f, 1f, 1f);

        // Get the cube's renderer component
        Renderer cubeRenderer = cube.GetComponent<Renderer>();

        // Set the cube's material color to red
        cubeRenderer.material.color = Color.red;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Call the LoadNewScene method on the LoadScene script
            loadSceneScript.LoadNewScene();
        }
    }
}
