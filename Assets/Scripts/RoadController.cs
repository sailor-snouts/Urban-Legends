using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour {

    private GameObject player;
    private float y_offset;
    public float roadFollowLag = 0.15f;

    // Use this for initialization
    void Start() {
        player = GameObject.Find("Player");
        y_offset = transform.position.y - player.transform.position.y;
    }

    // Update is called once per frame
    void LateUpdate() {
        float adjustedPositionForThisFrame = Mathf.SmoothStep(transform.position.y, player.transform.position.y + y_offset, roadFollowLag);
        transform.position = new Vector3(transform.position.x, adjustedPositionForThisFrame, transform.position.z);
    }
}
