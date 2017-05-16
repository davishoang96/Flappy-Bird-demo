using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeControl : MonoBehaviour {

    public float speed;
    public float delta;
    private Vector4 startPos;

	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if(birdcontrol.instance != null)
        {
            if (birdcontrol.instance.flag == 1)
                Destroy(GetComponent<pipeControl>());
    
        }
        pipeMovement();
	}

    void pipeMovement()
    {
        Vector3 temp = transform.position;
       
        temp.x = temp.x - speed * Time.deltaTime;
   
        transform.position = temp;

        //Vector4 v = startPos;
        //v.y += delta * Mathf.Sin(Time.time * speed);
        //transform.position = v;

    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "delete")
        {
            Destroy(gameObject);
        }
    }
}
