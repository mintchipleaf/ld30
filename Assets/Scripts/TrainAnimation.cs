using UnityEngine;
using System.Collections;

public class TrainAnimation : MonoBehaviour {

	public GameObject train;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		train.animation.Play();
	}
}
