using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
  
    [SerializeField] private gamecontroller _gameController;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jump;
       private bool _isGrounded;






    void Start()
    {
        // may not need this
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
    {

        _rigidbody.velocity = new Vector2(
        _rigidbody.velocity.x,
        _jump);
       
    }
    
    }
     
     private void OnTriggerEnter2D(Collider2D col)
    {
        _gameController.AddPoints();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }





}
