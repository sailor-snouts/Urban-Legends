using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    public GameObject deer;
    public GameObject bird;
    public GameObject head;
	
	void Update ()
    {
        if (Random.Range(1, 200) <= 1)
        {
            int proc = Random.Range(1, 100);
            if(proc < 6)
            {
                this.LoadDeer();
            } else if(proc < 9) {
                this.LoadBird();
            } else
            {
                this.LoadHead();
            }
        }
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
