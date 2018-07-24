using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour {

    private GameObject player;
    private float y_offset;

    // Use this for initialization
    void Start() {
        player = GameObject.Find("Player");
        y_offset = transform.position.y - player.transform.position.y;
    }

    // Update is called once per frame
    void LateUpdate() {
        transform.position = new Vector3(transform.position.x, player.transform.position.y + y_offset, transform.position.z);
    }
}
