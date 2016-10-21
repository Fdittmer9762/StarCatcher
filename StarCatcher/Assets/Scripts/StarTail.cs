using UnityEngine;
using System.Collections;

public class StarTail : MonoBehaviour {

    public int destroyDelay;
    public UnityEngine.UI.Slider starTail;
    public Transform star;

	void Start () {
        Debug.Log("Start");
	}

    void OnTriggerEnter() {
        StartCoroutine(GroundHit(destroyDelay, Statics.tailLeingth));
    }

    IEnumerator GroundHit(int delay, float fade) {
        while (fade > 0) {
            fade--;
            starTail.value--;
            yield return null;
        }
        yield return new WaitForSeconds(delay);
        Debug.Log("poof!");//destroy anim
        star.Translate(0,Random.Range(50, 100), 0, Space.World);
}

}
