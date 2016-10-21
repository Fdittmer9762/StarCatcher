using UnityEngine;
using System.Collections;

public class Constellations : MonoBehaviour {

    public Transform polaris;
    public float rotateRate;
	
	void Update () {
        polaris.Rotate(Vector3.forward * Time.deltaTime* rotateRate);
	}
}
