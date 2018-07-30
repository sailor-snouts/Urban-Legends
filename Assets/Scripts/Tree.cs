using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : RoadSideObject {

    public Tree(): base(Resources.Load("Prefabs/LivingTree") as GameObject, Resources.Load("Prefabs/SpookyTree") as GameObject) {
        lowerPositionBoundary = -2.5f;
        upperPositionBoundary = 1.2f;
        frequency = 0.4f;
        lowerVolumeBoundary = 1;
        upperVolumeBoundary = 3;
    }
}
