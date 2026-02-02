using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
private void OnTriggerEnter2D(Collider2D col)
    {
 
 
        if (col.gameObject.tag == "pipe")
        {
        
            
           Destroy(col.transform.parent.gameObject);

        } 
        
    }      
}
