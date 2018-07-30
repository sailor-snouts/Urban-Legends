using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSideObject {
    //specify the sprites to load
    private List<GameObject> normalVariations = new List<GameObject>();
    private List<GameObject> spookyVariations = new List<GameObject>();

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

    public RoadSideObject(List<GameObject> normals, List<GameObject> spookies) {
        normalVariations = normals;
        spookyVariations = spookies;
    }

    public RoadSideObject(GameObject normal, GameObject spooky) {
        normalVariations.Add(normal);
        spookyVariations.Add(spooky);
    }

    public GameObject getNormalVariation() {
        Random rnd = new Random();
        int randomIndex = Random.Range(0, normalVariations.Count);
        return normalVariations[randomIndex];
    }

    public GameObject getSpookyVariation() {
        Random rnd = new Random();
        int randomIndex = Random.Range(0, spookyVariations.Count);
        return spookyVariations[randomIndex];
    }
}
