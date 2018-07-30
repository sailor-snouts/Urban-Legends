using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSideObject {
    //specify the sprites to load
    public GameObject normal;
    public GameObject spooky;

    //when is the earliest this object should be seen
    public float firstSeen = 0f;

    //how often should this object be seen (where 1.0f is basically one second)
    public float frequency = 0.4f;

    //how far to the left can the object appear
    public float lowerPositionBoundary = 2.5f;

    //how far to the right can the object appear
    public float upperPositionBoundary = 1.2f;

    //what is the minimum number of times this object shoould appear when it has a chance to spawn on the right side
    public int rightLowerVolumeBoundary = 1;

    //what is the maximum number of times this object shoould appear when it has a chance to spawn on the right side
    public int rightUpperVolumeBoundary = 3;

    //what is the minimum number of times this object shoould appear when it has a chance to spawn on the left side
    public int leftLowerVolumeBoundary = 1;

    //what is the minimum number of times this object shoould appear when it has a chance to spawn on the left side
    public int leftUpperVolumeBoundary = 3;

    public RoadSideObject(GameObject normalObj, GameObject spookyObj) {
        normal = normalObj;
        spooky = spookyObj;
    }
}
