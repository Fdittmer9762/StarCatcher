using UnityEngine;
using System.Collections;

public class StarReset : MonoBehaviour {

    public UnityEngine.UI.Slider starTail;

    void SetTail(float _l)
    {
        starTail.maxValue = _l;
        starTail.value = _l;
    }

    void OnTriggerEnter () {
        Debug.Log("reset");
        SetTail(Statics.tailLeingth);
	}
}
