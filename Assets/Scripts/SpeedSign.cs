using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedSign : RoadSideObject {

    public SpeedSign(): base(Resources.Load("Prefabs/SpeedSign") as GameObject, Resources.Load("Prefabs/SpookySpeedSign") as GameObject) {
        firstSeen = 1.5f;
        frequency = 3.5f;
        lowerPositionBoundary = 0.25f;
        upperPositionBoundary = 0.25f;
        rightLowerVolumeBoundary = 1;
        rightUpperVolumeBoundary = 1;
        leftLowerVolumeBoundary = 0;
        leftUpperVolumeBoundary = 0;
    }
}
