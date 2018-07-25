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
        float amountToMoveThisFrame = speed * Time.deltaTime;
        Vector2 currentPosition = transform.position;
        Vector2 newPosition = new Vector2(currentPosition.x + amountToMoveThisFrame, currentPosition.y + amountToMoveThisFrame * slope);
        this.transform.position = newPosition;
    }
}
