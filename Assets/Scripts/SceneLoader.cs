using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2.5f;

    void Start()
    {
        Invoke("LoadFirstScene", levelLoadDelay);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene("Game");
    }
}
