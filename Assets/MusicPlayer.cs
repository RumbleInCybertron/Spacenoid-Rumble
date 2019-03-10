using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2.5f;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
       Invoke("LoadFirstScene", levelLoadDelay);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
