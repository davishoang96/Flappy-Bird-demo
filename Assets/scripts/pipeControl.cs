using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeControl : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pipeMovement();
	}

    void pipeMovement()
    {
        Vector3 temp = transform.position;
        temp.x = temp.x - speed * Time.deltaTime;
        transform.position = temp;
    }
}
