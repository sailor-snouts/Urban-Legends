using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suicide : MonoBehaviour {
    [SerializeField, Range(5, 50)]
    private float dieAtDistance = 20f;

	void Update () {
        if (Mathf.Abs(this.transform.position.x) > this.dieAtDistance)
        {
            DestroyObject(this.gameObject);
        }
	}
}
