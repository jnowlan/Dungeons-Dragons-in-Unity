using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Transform t;


    // Use this for initialization
    void Start()
    {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.W))
            t.Translate(0, 1, 0);

        if (Input.GetKeyDown(KeyCode.A))
            t.Translate(-1, 0, 0);

        if (Input.GetKeyDown(KeyCode.S))
            t.Translate(0, -1, 0);

        if (Input.GetKeyDown(KeyCode.D))
            t.Translate(1, 0, 0);


    }
}

