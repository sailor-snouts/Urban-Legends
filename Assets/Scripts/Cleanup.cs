using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleanup : MonoBehaviour {
    void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
