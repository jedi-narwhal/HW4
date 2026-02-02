using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes : MonoBehaviour
{
  
    [SerializeField] private float _speed;



    void Start()
    {
        //do not need
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector2.left*_speed*Time.deltaTime);
    }
}
