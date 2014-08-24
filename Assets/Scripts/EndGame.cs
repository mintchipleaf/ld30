using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {
	public GameObject fader;

	private SceneFadeInOut scenefade;

	private bool gui;


	// Use this for initialization
	void Start () {
		scenefade = fader.GetComponent<SceneFadeInOut>();
	}

	void OnTriggerEnter(Collider other) {
		//yield return new WaitForSeconds(2);
		scenefade.EndScene();
		gui = true;
	}

	void OnGUI () {
		if(gui){
			GUI.Label(new Rect(400, 200, 1000, 200), "CONGRATULATIONS!!");
			GUI.Label(new Rect(400, 220, 1000, 200), "You have successfully boarded a subway car");
			GUI.Label(new Rect(400, 280, 1000, 200), "The game is now over");
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
