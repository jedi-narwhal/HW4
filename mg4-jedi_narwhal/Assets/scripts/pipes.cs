using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes : MonoBehaviour
{
  
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;



    void Start()
    {
        //do not need
    }

    // Update is called once per frame
    void Update()
    {
         _rigidbody.velocity= new Vector2(-1,0) *_speed;
    }
}
