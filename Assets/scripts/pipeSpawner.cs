using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject pipeScoreHolder;

	// Use this for initialization
	void Start () {
        StartCoroutine(Spawner());
	}
	

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(1);
        Instantiate(pipeScoreHolder, transform.position, Quaternion.identity);
        StartCoroutine(Spawner());
    }
}
