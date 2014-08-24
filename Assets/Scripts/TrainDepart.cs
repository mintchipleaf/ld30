using UnityEngine;
using System.Collections;

public class TrainDepart : MonoBehaviour {

	private Animation animationcomponent;
	public string animation;

	// Use this for initialization
	void Start () {
		animationcomponent = this.GetComponent<Animation>();

	}
	
	IEnumerator OnTriggerEnter(Collider other) {
		yield return new WaitForSeconds(2);
		animationcomponent.Play("TrainDepart");
		Debug.Log("FUUUCK");
		//yield return new WaitForSeconds(2);
		Debug.Log("ugh");
	}

	void Update () {
	}
}
