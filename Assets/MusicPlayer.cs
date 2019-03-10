using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2.5f;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
       Invoke("LoadFirstScene", levelLoadDelay);
       audioSource = GetComponent<AudioSource>();   
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
