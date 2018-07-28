using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour {

    public GameObject tree;
    [SerializeField, Range(-5f, 0f)]
    private float lowerPositionBoundary = -2.5f;
    [SerializeField, Range(0, 5f)]
    private float upperPositionBoundary = 1.2f;
    [SerializeField, Range(0, 3f)]
    private float frequency = 0.4f;
    [SerializeField, Range(0, 5)]
    private int lowerVolumeBoundary = 1;
    [SerializeField, Range(0, 5)]
    private int upperVolumeBoundary = 3;


    // Use this for initialization
    void Start() {

        InvokeRepeating("LoadTree", 0f, frequency);
    }

    // Update is called once per frame
    void Update() {
    }

    void LoadTree() {
        int numberOfTreesToSpawn = Random.Range(lowerVolumeBoundary, upperVolumeBoundary);
        for (int i = 0; i < numberOfTreesToSpawn; i++) {
            Vector3 position = new Vector3(Random.Range(lowerPositionBoundary, upperPositionBoundary), 1, 0);
            Instantiate(tree, transform.position + position, Quaternion.identity);
        }
    }
}
