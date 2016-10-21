using UnityEngine;
using System.Collections;

public class GroundMover : MonoBehaviour {

	void Start () {
        StartCoroutine(MovingGround(Statics.levelWidth));
	}

    IEnumerator MovingGround(float stepDistance) {
        float d = 0;
        while (d < stepDistance)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
            d += Time.deltaTime;
            //Debug.Log(d);
            yield return null;
        }
        //remove object from list/array **will impliment when list are working
        //StopCoroutine(MovingGround(Statics.levelWidth)); //keeping coroutine going because of limited objects in list, will change when auto add is working
        StartCoroutine(MovingGround(Statics.levelWidth)); //will use to stop when off screen,
    }

}
