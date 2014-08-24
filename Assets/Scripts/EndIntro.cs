using UnityEngine;
using System.Collections;

public class EndIntro : MonoBehaviour {


	public Animator animator;
	public Font font;

	private bool gui;
	private GUIStyle style;

	// Use this for initialization
	void Start () {
		gui = true;
		Debug.Log ("test");
		//style.font = font;
		style.fontSize = 1;
	}

	void OnGUI () {
		if(gui) {
				GUI.Label(new Rect(400, 200, 1000, 200), "Rails");
				GUI.Label(new Rect(400, 220, 1000, 200), "By Mint");
		}

	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player"){
			//animator.SetBool("playerIntro", false);
			gui = false;
		}
	}
}
