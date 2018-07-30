using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    public GameObject deer;
    public GameObject bird;
    public GameObject head;
    [SerializeField]
    float limit = 1f;
    private float limitCounter = 0;

    void Update ()
    {
        this.limitCounter -= Time.deltaTime;
        if (this.limitCounter < 0 && Random.Range(1, 400) <= 1)
        {
            int proc = Random.Range(1, 100);
            if(proc < 60)
            {
                this.LoadDeer();
            } else if(proc < 90) {
                this.LoadBird();
            } else
            {
                this.LoadHead();
            }
        }
    }

    void LoadDeer() {
        Instantiate(deer, transform.position + new Vector3(-5, Random.Range(0,6f), 0), Quaternion.identity);
    }

    void LoadBird() {
        Instantiate(bird, transform.position + new Vector3(-5, Random.Range(0, 6f), 0), Quaternion.identity);
    }

    void LoadHead() {
        Instantiate(head, transform.position + new Vector3(-5, Random.Range(0, 6f), 0), Quaternion.identity);
    }
}
