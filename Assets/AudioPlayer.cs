using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip audioClip; // The audio clip to play
    private AudioSource audioSource; // Reference to the AudioSource component

    private void Start()
    {
        // Get the AudioSource component attached to the game object
        //audioSource = GetComponent<AudioSource>();

        // Assign the audio clip to the AudioSource component
        //audioSource.clip = audioClip;

        // Start playing the audio clip
        //audioSource.Play();
    }

    public void PlaySound()
    {
        // Get the AudioSource component attached to the game object
        audioSource = GetComponent<AudioSource>();

        // Assign the audio clip to the AudioSource component
        audioSource.clip = audioClip;

        // Start playing the audio clip
        audioSource.Play();
    }
    
}
