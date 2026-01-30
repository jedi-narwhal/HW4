using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //points=0
        //set frequencey for random.range height
    }

    // Update is called once per frame
    void Update()
    {
        //check time elaspe-time.time-check google if statement
        //timeelapse>= frquency-call spawn pipe
    }
    void SpawnPipes()
    {
        //instinate
    }
     
    public static gamecontroller Instance { get; private set; }


    private void Awake() {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;

        }
        Instance = this;
    }

    public delegate void Delegate();
    public event Delegate Score;

    private int _points;
    void AddPoints()
    {
        _points++;
        Score?.Invoke();
    }


}
