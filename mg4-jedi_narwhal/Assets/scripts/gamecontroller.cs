using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{

    private int _points;
    [SerializeField] private GameObject _pipePrefab;
    [SerializeField] private float _minadd;
     [SerializeField] private float _maxadd;
     private float _lastspawned;  
    [SerializeField] private Transform _spawnpoint;

    [SerializeField] private float _frequency;





    void Start()
    {
        _points =0;

    }

    // Update is called once per frame
    void Update()
    {

        //check time elaspe-time.time-check google if statement
        //timeelapse>= frquency-call spawn pipe
        if (Time.time-_lastspawned>=_frequency)
        {
  
            _lastspawned=Time.time;
          float  _addamount =Random.Range(_minadd,_maxadd);
            Vector3 _newspawn= new Vector3(_spawnpoint.position.x,_spawnpoint.position.y+_addamount,_spawnpoint.position.z);
            Instantiate(_pipePrefab, _newspawn,Quaternion.identity);
        
        }

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

    public delegate void Delegate(int _points);
    public event Delegate Score;

    public void AddPoints()
    {
        _points++;
        Score?.Invoke(_points);
    }


}
