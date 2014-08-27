/// <summary>
/// Animates train arrival
/// </summary>
using UnityEngine;
using System.Collections;

public class TrainArrive : MonoBehaviour {

	public GameObject train;		//Train to animate
	public GameObject collider;		//Collider to remove


	/// <summary>
	/// After 60 seconds of game start, animate train and destroy collider
	/// </summary>
	IEnumerator Start () {
		yield return new WaitForSeconds(60);
		train.animation.Play();
		Object.Destroy(collider);
	}



}
