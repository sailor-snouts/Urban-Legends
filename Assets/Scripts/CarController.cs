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
    [SerializeField, Range(0, 10)]
    private float clamp = 1.3f;

    private float speed;
    private float turn;

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
        this.turn = Input.GetAxis("Horizontal") * this.steer * Time.deltaTime;

        Vector2 currentPosition = transform.position;
        Vector2 newPosition = new Vector2(Mathf.Clamp(currentPosition.x + this.turn, this.clamp*-1f, this.clamp), currentPosition.y + this.speed);
        this.transform.position = newPosition;
    }
}
