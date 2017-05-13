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
        Vector3 temp = pipeScoreHolder.transform.position;
        temp.y = Random.Range(-2f, 2f);
        Instantiate(pipeScoreHolder, temp, Quaternion.identity);
        StartCoroutine(Spawner());
    }
}
