using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyW : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "whiteb")
        {
            Destroy(col.collider.gameObject);
            Destroy(gameObject);

        }


    }
}
