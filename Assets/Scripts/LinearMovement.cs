using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : MonoBehaviour {
    [SerializeField, Range(0, 15)]
    private float speed;

    void Start() {

    }

    void Update() {
        float amountToMoveThisFrame = speed * Time.deltaTime;
        Vector2 currentPosition = transform.position;
        Vector2 newPosition = new Vector2(currentPosition.x + amountToMoveThisFrame, currentPosition.y);
        this.transform.position = newPosition;
    }
}
