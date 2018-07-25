using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeMovement : MonoBehaviour {
    [SerializeField, Range(0, 15)]
    private float speed = 7.5f;
    [SerializeField, Range(-2, 2)]
    private float slope = -0.15f;

    void Start() {

    }

    void Update() {
        transform.position += (transform.right * Time.deltaTime * speed) + (transform.up * Time.deltaTime * speed * slope);
    }
}
