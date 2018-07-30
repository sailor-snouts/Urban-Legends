using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSideObjectGenerator : MonoBehaviour {

    public RoadSideObject tree;
    public RoadSideObject speedSign;
    public RoadSideObject billboard;

    private GameManager gameManager;

    private Vector3 rightOffset = new Vector3(1.8f, 0, 0);
    private Vector3 leftOffset = new Vector3(-1.8f, 0, 0);

    // Use this for initialization
    void Start() {
        gameManager = GameObject.Find("Gamemanager").GetComponent<GameManager>();

        tree = new Tree();
        speedSign = new SpeedSign();
        billboard = new Billboard();

        InvokeRepeating("LoadTree", tree.firstSeen, tree.frequency);
        InvokeRepeating("LoadSpeedSign", speedSign.firstSeen, speedSign.frequency);
        InvokeRepeating("LoadBillboard", billboard.firstSeen, billboard.frequency);
    }

    // Update is called once per frame
    void Update() {
    }

    void LoadTree() {
        int leftZoneSpawns = Random.Range(tree.leftLowerVolumeBoundary, tree.leftUpperVolumeBoundary);
        int rightZoneSpawns = Random.Range(tree.rightLowerVolumeBoundary, tree.rightUpperVolumeBoundary);
        SpawnObject(tree, leftZoneSpawns, true);
        SpawnObject(tree, rightZoneSpawns, false);
    }

    void LoadSpeedSign() {
        int rightZoneSpawns = Random.Range(speedSign.rightLowerVolumeBoundary, speedSign.rightUpperVolumeBoundary);
        SpawnObject(speedSign, rightZoneSpawns, false);
    }

    void LoadBillboard() {
        int leftZoneSpawns = Random.Range(billboard.leftLowerVolumeBoundary, billboard.leftUpperVolumeBoundary);
        int rightZoneSpawns = Random.Range(billboard.rightLowerVolumeBoundary, billboard.rightUpperVolumeBoundary);
        SpawnObject(billboard, leftZoneSpawns, true);
        SpawnObject(billboard, rightZoneSpawns, false);
    }

    void SpawnObject(RoadSideObject objectToSpawn, int objectsToSpawn, bool isLeftSide) {
        GameObject instantiatedObject;
        for (int i = 0; i < objectsToSpawn; i++) {
            Vector3 position;
            if(isLeftSide) {
                position = new Vector3(Random.Range(-objectToSpawn.lowerPositionBoundary, -objectToSpawn.upperPositionBoundary), 1, 0) + leftOffset;
            } else {
                position = new Vector3(Random.Range(objectToSpawn.lowerPositionBoundary, objectToSpawn.upperPositionBoundary), 1, 0) + rightOffset;
            }
            if (gameManager.getSpookyLevel() <= 0) {
                instantiatedObject = Instantiate(objectToSpawn.getNormalVariation(), transform.position + position, Quaternion.identity);
            } else {
                instantiatedObject = Instantiate(objectToSpawn.getSpookyVariation(), transform.position + position, Quaternion.identity);
            }
            instantiatedObject.AddComponent<Cleanup>();
        }
    }
}
