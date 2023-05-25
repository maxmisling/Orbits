using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelFrames : MonoBehaviour
{
    // You drag these all in once via the Inspector
    public GameObject[] models;
    public int targetFramesPerSecond = 60;


    private void Awake()
    {
        foreach (var model in models)
        {
            model.SetActive(false);
        }
    }


    private IEnumerator Start()
    {
        var currentIndex = 0;
        models[currentIndex].SetActive(true);

        while (true)
        {
            yield return new WaitForSeconds(1f / targetFramesPerSecond);

            models[currentIndex].SetActive(false);

            currentIndex = (currentIndex + 1) % models.Length;

            models[currentIndex].SetActive(true);
        }
    }
}
