using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killbox : MonoBehaviour
{
    // Start is called before the first frame update
private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("destroy");
 
        if (col.gameObject.tag == "pipe")
        {
        
            Debug.Log("top");
           Destroy(col.transform.parent.gameObject);
           

        } 
        
    }      
}
