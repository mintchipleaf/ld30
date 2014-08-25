using UnityEngine;
using System.Collections;

public class TrainArrive : MonoBehaviour {

	public GameObject train;
	public GameObject block;

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(60);
		train.animation.Play();
		Object.Destroy(block);
	}



}
