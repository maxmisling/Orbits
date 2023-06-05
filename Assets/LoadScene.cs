using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneName; // Name of the scene to load

    public void LoadNewScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
