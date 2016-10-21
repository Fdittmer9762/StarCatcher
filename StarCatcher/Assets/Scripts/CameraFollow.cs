using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public NavMeshAgent camNavAgent;
    public Transform player;

	void Update () {
        camNavAgent = GetComponent<NavMeshAgent>();
        camNavAgent.destination = player.position;
	}
}
