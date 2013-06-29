using UnityEngine;
using System.Collections;

public class MenuHighscore : MonoBehaviour {
		

	
	void OnGUI()
	{
		GUILayout.BeginHorizontal();
		
		if (GUILayout.Button("Start Game"))
			Application.LoadLevel(GlobalNames.SCENE_ID_GAME);
		if (GUILayout.Button("Options"))
            Application.LoadLevel(GlobalNames.SCENE_ID_OPTIONS);
		
		if (GUILayout.Button("Highscore"))
            Application.LoadLevel(GlobalNames.SCENE_ID_HIGHSCORE);
		
		GUILayout.EndHorizontal();
		
		GUI.Label(new Rect(Screen.width/2, Screen.height/2, 100, 100), "Highscores");
	}
}
