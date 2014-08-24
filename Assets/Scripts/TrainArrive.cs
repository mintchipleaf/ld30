using UnityEngine;
using System.Collections;

public class TrainArrive : MonoBehaviour {

	public GameObject train;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		train.animation.Play();
		Debug.Log("Ass");
	}
}
