using UnityEngine;
using System.Collections;

public class TestNeighbor : MonoBehaviour {

    public Vector2 neighborCount;

    void Start() {
        neighborCount = GetComponentInParent<Vector2>();
    }

    void OnTriggerEnter() {
        
    }

    int AddNeighbor(int nAxis) {
        return nAxis += 1;
    }

}
