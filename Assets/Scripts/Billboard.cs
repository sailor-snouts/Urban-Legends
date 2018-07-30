using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : RoadSideObject {

    public Billboard(): base(
        new List<GameObject> {
            Resources.Load("Prefabs/Billboard") as GameObject,
            Resources.Load("Prefabs/WoodenSign") as GameObject,
            Resources.Load("Prefabs/BlankBillboard") as GameObject },
        new List<GameObject> {
            Resources.Load("Prefabs/SpookyBillboard") as GameObject,
            Resources.Load("Prefabs/SpookyWoodenSign") as GameObject }) {

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
