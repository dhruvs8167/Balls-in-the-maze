using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour {
    Rigidbody2D rb;
    [Range(0.2f, 2f)]
    public float moveSpeedModifier = 0.3f;
    float dirX, dirY;
    
    
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Donefuck");
    }
	
	// Update is called once per frame
	void Update () {
        dirX = Input.acceleration.x * moveSpeedModifier;
        dirY = Input.acceleration.y * moveSpeedModifier;
        rb.velocity = new Vector2(rb.velocity.x + dirX, rb.velocity.y + dirY);
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

    }    
}
