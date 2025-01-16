using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGmusicscript : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        // Get the Audio Source component
        audioSource = GetComponent<AudioSource>();

        // Ensure music starts playing when the scene loads
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    private void OnEnable()
    {
        // Subscribe to scene change events
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        // Unsubscribe to avoid memory leaks
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Stop music if transitioning to MainMenu
        if (scene.name == "MainMenu")
        {
            audioSource.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Stop music when the player reaches the WinFlag
        if (other.CompareTag("Player") && gameObject.CompareTag("WinFlag"))
        {
            audioSource.Stop();
        }
    }
}




