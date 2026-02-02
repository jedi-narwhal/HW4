using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private player _player;
    void Start()
    {
        gamecontroller.Instance.Score+= HandlePoints;
        _player.EndGame+= HandleEndgame;
        _audioSource=GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HandlePoints(int _points)
    {

        //_audioSource.Play();
    }
void HandleEndgame()
    {
        //_audioSource.Play();
        
    }
}
