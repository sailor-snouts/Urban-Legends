﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSideObjectGenerator : MonoBehaviour {

    public RoadSideObject tree;
    private GameManager gameManager;

    // Use this for initialization
    void Start() {
        gameManager = GameObject.Find("Gamemanager").GetComponent<GameManager>();
        tree = new Tree();
        InvokeRepeating("LoadTree", 0f, tree.frequency);
    }

    // Update is called once per frame
    void Update() {
    }

    void LoadTree() {
        int numberOfTreesToSpawn = Random.Range(tree.lowerVolumeBoundary, tree.upperVolumeBoundary);
        for (int i = 0; i < numberOfTreesToSpawn; i++) {
            Vector3 position = new Vector3(Random.Range(tree.lowerPositionBoundary, tree.upperPositionBoundary), 1, 0);
            if(gameManager.getSpookyLevel() <= 0) {
                Instantiate(tree.normal, transform.position + position, Quaternion.identity);
            } else {
                Instantiate(tree.spooky, transform.position + position, Quaternion.identity);
            }
        }
    }
}
