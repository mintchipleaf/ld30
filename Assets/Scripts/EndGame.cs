/// <summary>
/// Renders endgame text
/// </summary>
using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	public GameObject fader;			//Screen fader

	private SceneFadeInOut screenfade;	//Stores screen fader script
	private bool gui;					//Determines if text should render


	// Use this for initialization
	void Start () {
		screenfade = fader.GetComponent<SceneFadeInOut>();
	}

	/// <summary>
	/// On passing trigger, fade screen and render text.
	/// </summary>
	void OnTriggerEnter(Collider other) {
		screenfade.EndScene();
		gui = true;
	}

	/// <summary>
	/// If text should render, display GUI labels on screen.
	/// </summary>
	void OnGUI () {
		if(gui){
			GUI.Label(new Rect(400, 200, 1000, 200), "CONGRATULATIONS!!");
			GUI.Label(new Rect(400, 220, 1000, 200), "You have successfully boarded a subway car");
			GUI.Label(new Rect(400, 280, 1000, 200), "The game is now over");
		}

	}
}
