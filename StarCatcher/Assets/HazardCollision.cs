using UnityEngine;
using System.Collections;

public class HazardCollision : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        Statics.playerHealth--;//DammagePlayer ** may change from static to instance
        Debug.Log("Ouch!!");
    }
}
