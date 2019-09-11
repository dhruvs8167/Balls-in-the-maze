using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistroyR : MonoBehaviour {
    

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "redb")
        {
            Destroy(col.collider.gameObject);
            Destroy(gameObject);
            
        }
        
        
    }
}
