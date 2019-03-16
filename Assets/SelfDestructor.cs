using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructor : MonoBehaviour
{
    [SerializeField] float selfDestructDelay = 5f;

    void Start()
    {
        Destroy(gameObject, selfDestructDelay);
    }

    void Update()
    {
        
    }
}
