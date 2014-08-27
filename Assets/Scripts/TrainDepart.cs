using UnityEngine;
using System.Collections;

public class TrainDepart : MonoBehaviour {

	public GameObject particles;	//Particles to remove

	private Animation animationcomponent; //Stores Animation component

	// Use this for initialization
	void Start () {
		animationcomponent = this.GetComponent<Animation>();
	}

	/// <summary>
	/// After 2 seconds of boarding train, play depart animation.
	/// </summary>
	IEnumerator OnTriggerEnter(Collider other) {
		yield return new WaitForSeconds(2);
		animationcomponent.Play("TrainDepart");
	}
}
