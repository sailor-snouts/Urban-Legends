using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    [SerializeField]
    private float timer;

    public bool hasTime()
    {
        return this.timer > 0;
    }

    public void Update()
    {
        this.timer -= Time.deltaTime;
    }
}
