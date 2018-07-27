using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    public GameObject deer;
    public GameObject bird;
    public GameObject head;

	// Use this for initialization
	void Start () {

        InvokeRepeating("LoadDeer", 0f, 2f);
        InvokeRepeating("LoadBird", 2f, 4f);
        InvokeRepeating("LoadHead", 4f, 5f);
    }
	
	// Update is called once per frame
	void Update () {
    }

    void LoadDeer() {
        Instantiate(deer, transform.position + new Vector3(-5, 1, 0), Quaternion.identity);
    }

    void LoadBird() {
        Instantiate(bird, transform.position + new Vector3(-5, 5, 0), Quaternion.identity);
    }

    void LoadHead() {
        Instantiate(head, transform.position + new Vector3(-5, -2, 0), Quaternion.identity);
    }
}
