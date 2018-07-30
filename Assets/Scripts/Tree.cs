using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : RoadSideObject {

    public Tree(): base(Resources.Load("Prefabs/Tree") as GameObject, Resources.Load("Prefabs/SpookyTree") as GameObject) {
        firstSeen = 0f;
        frequency = 0.4f;
        lowerPositionBoundary = 5f;
        upperPositionBoundary = 1f;
        rightLowerVolumeBoundary = 1;
        rightUpperVolumeBoundary = 3;
        leftLowerVolumeBoundary = 1;
        leftUpperVolumeBoundary = 3;
    }
}
