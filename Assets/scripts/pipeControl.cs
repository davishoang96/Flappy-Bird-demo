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

    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "delete")
        {
            Destroy(gameObject);
        }
    }
}
