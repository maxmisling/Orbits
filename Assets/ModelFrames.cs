using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelFrames : MonoBehaviour
{
    // You drag these all in once via the Inspector
    public GameObject[] models;

    private int currentIndex = -1;

    private void Awake()
    {
        foreach (var model in models)
        {
            model.SetActive(false);
        }
    }

    private void Update()
    {
        if (currentIndex >= 0)
        {
            models[currentIndex].SetActive(false);
        }

        currentIndex = (currentIndex + 1) % models.Length;

        models[currentIndex].SetActive(true);
    }
}
