using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMovement : MonoBehaviour {
    /**
     * Taken from https://answers.unity.com/questions/803434/how-to-make-projectile-to-shoot-in-a-sine-wave-pat.html
    **/ 

    [SerializeField, Range(0, 15)]
    private float horizontalSpeed = 5.0f;
    [SerializeField, Range(0, 25)]
    public float frequency = 20.0f;  // Speed of sine movement
    [SerializeField, Range(0, 2)]
    public float magnitude = 0.5f;   // Size of sine movement
    private Vector3 axis;
    private Vector3 pos;

    void Start() {
        pos = transform.position;
        axis = transform.up;
    }

    void Update() {
        pos += transform.right * Time.deltaTime * horizontalSpeed;
        transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude;
    }
}
