using UnityEngine;
using System.Collections;

public class MenuHighscore : MenuMain {
		
	public Vector2 scrollPosition = Vector2.zero;
	
	void OnGUI()
	{
		GUILayout.BeginHorizontal();
		
		if (GUILayout.Button("Start Game"))
			Application.LoadLevel(GlobalNames.SCENE_ID_GAME);
		if (GUILayout.Button("Options"))
            Application.LoadLevel(GlobalNames.SCENE_ID_OPTIONS);
		if (GUILayout.Button("Back to Main Menu"))
            Application.LoadLevel(GlobalNames.SCENE_ID_MAINMENU);
		
		GUILayout.EndHorizontal();
		
		//GUI.Label(new Rect(Screen.width/2, Screen.height/2, 100, 100), "Highscores");
		
		scrollPosition = GUI.BeginScrollView (new Rect(50, 50, Screen.width, Screen.height), scrollPosition, new Rect (0, 0, 400, ScoringSystem.maxHighscores * 45));
		for (int j=0; j<ScoringSystem.maxHighscores; j++) {
			if (PlayerPrefs.HasKey ("ScoreNr" + j)) {
				GUI.Label (new Rect (0, j * 45, Screen.width / 2, 40), PlayerPrefs.GetInt ("ScoreNr" + j).ToString ());
				GUI.Label (new Rect (Screen.width / 2, j * 45, Screen.width / 2, 40), PlayerPrefs.GetString ("ScoreName" + j));
			}
		}
		
		GUI.EndScrollView ();
	}
}
