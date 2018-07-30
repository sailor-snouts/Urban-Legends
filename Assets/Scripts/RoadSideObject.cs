using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSideObject {
    public GameObject normal;
    public GameObject spooky;
    [SerializeField, Range(-5f, 0f)]
    public float lowerPositionBoundary = -2.5f;
    [SerializeField, Range(0, 5f)]
    public float upperPositionBoundary = 1.2f;
    [SerializeField, Range(0, 3f)]
    public float frequency = 0.4f;
    [SerializeField, Range(0, 5)]
    public int lowerVolumeBoundary = 1;
    [SerializeField, Range(0, 5)]
    public int upperVolumeBoundary = 3;

    public RoadSideObject(GameObject normalObj, GameObject spookyObj) {
        normal = normalObj;
        spooky = spookyObj;
    }
}
