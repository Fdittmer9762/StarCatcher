using UnityEngine;
using System.Collections;

public class StarCollect : MonoBehaviour {

    public int pointValue;
    public Transform star;
    public Rigidbody starRB;
    public float starMinH, starMaxH;

    void OnTriggerEnter() {
        AddPoints(pointValue);
        //starRB.useGravity = false;//code used in other scripts, need to create a function that can be easily accessed
        Return(Random.Range(starMinH, starMaxH));
        //add to star list
    }

    public void Return(float randH) {
        star.Translate(0, randH, 0,Space.World);
    }

    public void AddPoints(int p) {
        Statics.Score += p; //add points
        Debug.Log(Statics.Score);
    }
}
