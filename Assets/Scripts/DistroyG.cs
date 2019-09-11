using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistroyG : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "greenb")
        {
            Destroy(col.collider.gameObject);
            Destroy(gameObject);
            
        }
        if (GameObject.FindGameObjectsWithTag("end") == null)
        {
            Debug.Log("Donefuck");
        }

    }
}
