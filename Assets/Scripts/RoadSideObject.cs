using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSideObject {
    public GameObject normal;
    public GameObject spooky;

    public float firstSeen = 0f;
    public float frequency = 0.4f;

    public float lowerPositionBoundary = 2.5f;
    public float upperPositionBoundary = 1.2f;

    public int rightLowerVolumeBoundary = 1;
    public int rightUpperVolumeBoundary = 3;
    public int leftLowerVolumeBoundary = 1;
    public int leftUpperVolumeBoundary = 3;

    public RoadSideObject(GameObject normalObj, GameObject spookyObj) {
        normal = normalObj;
        spooky = spookyObj;
    }
}
