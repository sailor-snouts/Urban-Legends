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
        Instantiate(deer, new Vector3(-4, 0, 0), Quaternion.identity);
    }

    void LoadBird() {
        Instantiate(bird, new Vector3(-4, 2, 0), Quaternion.identity);
    }

    void LoadHead() {
        Instantiate(head, new Vector3(-4, -2, 0), Quaternion.identity);
    }
}
