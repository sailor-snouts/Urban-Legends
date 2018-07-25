﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : MonoBehaviour {
    [SerializeField, Range(0, 15)]
    private float speed = 7.5f;

    void Start() {

    }

    void Update() {
        transform.position += transform.right * Time.deltaTime * speed;
    }
        
}
