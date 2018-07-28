using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour {
    private Vector2 start;
    [SerializeField]
    private float distance;

    public void Start()
    {
        this.start = this.transform.position;
    }

    public void Update()
    {
        this.distance = Vector2.Distance(this.transform.position, this.start);
    }

    public float GetDistance()
    {
        return this.distance;
    }
}
