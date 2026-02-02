using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
       private AudioSource _audioSource;
    void Start()
    {
        gamecontroller.Instance.Score+= HandlePoints;
        _audioSource=GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HandlePoints(int _points)
    {

        _audioSource.Play();
    }
}
