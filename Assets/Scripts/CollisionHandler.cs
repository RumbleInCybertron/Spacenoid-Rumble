﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // ok as long as this is the only script that loads scenes

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("In seconds")][SerializeField] float levelLoadDelay = 2f;
    [Tooltip("FX prefab on player")][SerializeField] GameObject deathFX;

    // TODO create code for triggering enemies, obstacles, terrain, etc
    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
        deathFX.SetActive(true);
        Invoke("ReloadScene", levelLoadDelay);
    }

    private void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");
    }

    private void ReloadScene()  // string referenced
    {
        SceneManager.LoadScene("Game");
    }
}
