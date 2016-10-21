using UnityEngine;
using System.Collections;

public class StarManager : MonoBehaviour {

    public GameObject[] Stars;
    public float fallDelay; 

    void Start() {
        //start coroutine
    }

    IEnumerator StarShower() {
        GameObject newStar = Stars[Random.Range(0, Stars.Length)]; //chooses random star
        //newStar.rigidbody.useGravity = true;
        yield return new WaitForSeconds(fallDelay);
    }

}
