using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static int currentScore;
	public static int highScore;

	public static int currentLevel=0;
	public static int unlockedLevel;

	public float startTime;
	private string currentTime;

	public GUISkin skin;
	public Rect timerRect;

	void Start () {
		//DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () 
	{
		startTime -= Time.deltaTime;
		currentTime = string.Format ("{0:0.0}", startTime);
		//currentTime = startTime.ToString ();

		if (startTime <= 0)
		{
			startTime = 0;
			print ("You're out of time");
			SceneManager.LoadScene (3);  // buna dikkat!!
		}
	}

	void OnGUI()
	{
		GUI.skin = skin;
		GUI.Label (timerRect, currentTime, skin.GetStyle("Timer"));
	}
		
	public static void CompleteLevel()
	{   
		if (currentLevel < 2) {

			currentLevel += 1;
			SceneManager.LoadScene (currentLevel);
		} else {
			print ("You win !!");
		}

	}
}
