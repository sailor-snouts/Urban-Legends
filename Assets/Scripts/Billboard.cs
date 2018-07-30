using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : RoadSideObject {

    public Billboard(): base(Resources.Load("Prefabs/Billboard") as GameObject, Resources.Load("Prefabs/SpookyBillboard") as GameObject) {
        firstSeen = 2f;
        frequency = 2f;
        lowerPositionBoundary = 5f;
        upperPositionBoundary = 1f;
        rightLowerVolumeBoundary = 0;
        rightUpperVolumeBoundary = 2;
        leftLowerVolumeBoundary = 0;
        leftUpperVolumeBoundary = 2;
    }
}
