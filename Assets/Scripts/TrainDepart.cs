using UnityEngine;
using System.Collections;

public class TrainDepart : MonoBehaviour {

	private Animation animationcomponent;
	public string animation;

	// Use this for initialization
	void Start () {
		animationcomponent = this.GetComponent<Animation>();

	}
	
	void OnTriggerEnter(Collider other) {
		animationcomponent.Play("TrainDepart");
		Debug.Log("FUUUCK");
	}
}
