using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private GameObject player;
    private float y_offset;
    public float followLag = 0.25f;

    // Use this for initialization
    void Start() {
        player = GameObject.Find("Player");
        y_offset = transform.position.y - player.transform.position.y;
    }

    // Update is called once per frame
    void LateUpdate() {
        float adjustedPositionForThisFrame = Mathf.SmoothStep(transform.position.y, player.transform.position.y + y_offset, followLag);
        transform.position = new Vector3(transform.position.x, adjustedPositionForThisFrame, transform.position.z);
    }
}
