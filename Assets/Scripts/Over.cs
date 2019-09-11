using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Over : MonoBehaviour {
    public GameObject r;
    public GameObject g;
    public GameObject b;
    public GameObject bl;
    public GameObject w;
    public GameObject ui;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (r == null & g == null & bl == null & w == null & b == null)
        {
            FindObjectOfType<High>().Stop();
            ui.SetActive(true);
        }
    }
}
