using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfNearBillboard : MonoBehaviour {

    //Adapted from https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html
    void Update () {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Billboard");
        float distance = 3.0f;
        Vector3 position = transform.position;
        foreach (GameObject go in gos) {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance) {
                Destroy(gameObject);
            }
        }
    }
}