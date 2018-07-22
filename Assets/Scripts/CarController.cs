using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    [SerializeField, Range(0, 10)]
    private float speedMax = 5;
    [SerializeField, Range(0, 10)]
    private float speedMin = 1;
    [SerializeField, Range(0, 10)]
    private float acceleration = 8;
    [SerializeField, Range(0, 10)]
    private float decceleration = 5;
    [SerializeField, Range(0, 10)]
    private float steer = 5;

    private float speed;

    void Start () {
		
	}
	
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            this.speed += this.acceleration * Time.deltaTime;
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            this.speed -= this.decceleration * Time.deltaTime;
        }
        this.speed = Mathf.Clamp(this.speed, this.speedMin, this.speedMax);
        Debug.Log(this.speed);

        Vector2 currentPosition = transform.position;
        Vector2 newPosition = new Vector2(currentPosition.x, currentPosition.y + this.speed);
        this.transform.position = newPosition;
    }
}
