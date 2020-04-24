using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public GUISkin skin;

	void OnGUI()
	{
		GUI.skin = skin;
		
		GUI.Label(new Rect (20, 20, 100, 50), "GO HOME");

		if (GUI.Button (new Rect (20, 200, 100, 50), "PLAY")) {
			//print ("I'm playing");
			SceneManager.LoadScene (0);

		}

		if (GUI.Button (new Rect (20, 260, 100, 50), "QUIT")) {

			//print ("I quit");
			Application.Quit ();
		}
		
	}
		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
