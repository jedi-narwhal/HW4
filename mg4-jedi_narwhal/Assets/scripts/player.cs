using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // may not need this
    }

    // Update is called once per frame
    void Update()
    {
        //space= jump and allow jump in air
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // is grounded when on ground
    }
     private void OnTriggerEnter2D(Collider2D col)
    {
        //update points
    }







}
