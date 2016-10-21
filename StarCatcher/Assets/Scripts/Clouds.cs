using UnityEngine;
using System.Collections;

public class Clouds : MonoBehaviour {

    public float cloudSpeed;
    int cloudResetDelay;
    public Transform cloud;
    public Vector3 startingLocation;
    public float tD;

	void Start () {
        cloud = GetComponent<Transform>();
        StartCoroutine(CloudMover(tD, cloudSpeed, cloudResetDelay));
	}

    IEnumerator CloudMover(float travelTime, float s, int delay) {
        cloud.position = startingLocation;
        float d = 0;
        while (d < travelTime) {
            transform.Translate(s * Vector3.left * Time.deltaTime);
            d += Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(delay);
        cloudResetDelay = Random.Range(8,20);
        cloudSpeed = Random.Range(0,2);
        StartCoroutine(CloudMover(tD, cloudSpeed, cloudResetDelay));
    }

}
