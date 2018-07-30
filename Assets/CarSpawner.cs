using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour {
    [SerializeField]
    GameObject enemy;
    [SerializeField]
    float limit = 0.5f;
    private float limitCounter = 0;
	
	void Update () {
        this.limitCounter -= Time.deltaTime;
		if(this.limitCounter < 0 && Random.Range(1,100) <= 10)
        {
            this.limitCounter = this.limit;
            Debug.Log("making a car");
            int proc = Random.Range(1, 100);
            int locationProc = Random.Range(1, 100);
            if (proc < 75)
            {
                float location;
                if (locationProc < 33)
                {
                    location = -1.3f;
                } else if(locationProc < 66)
                {
                    location = 1.3f;
                } else
                {
                    location = 0;
                }
                Instantiate(this.enemy, new Vector3(location, this.transform.position.y+6f, 0), transform.rotation);
            } else
            {
                float location1, location2;
                if (locationProc < 50)
                {
                    location1 = -1.3f;
                    location2 = 1.3f;
                }
                else if (locationProc < 66)
                {
                    location1 = 1.3f;
                    location2 = 0;
                }
                else
                {
                    location1 = -1.3f;
                    location2 = 0;
                }
                Instantiate(this.enemy, new Vector3(location1, this.transform.position.y + 6f, 0), transform.rotation);
                Instantiate(this.enemy, new Vector3(location2, this.transform.position.y + 6f, 0), transform.rotation);
            }
        }
	}
}
