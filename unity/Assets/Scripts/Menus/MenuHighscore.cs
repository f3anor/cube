using UnityEngine;
using System.Collections;

public class MenuHighscore : MenuMain {
		

	
	void OnGUI()
	{
		
		//BG Image
		GUI.Box (new Rect (0, 0, Screen.width, Screen.height), " ");
		GUI.Label (new Rect (0, 0, Screen.width, Screen.height), tex_MenuBackground);
		
		//buttons
		GUILayout.BeginHorizontal();
		
		if (GUILayout.Button(tex_ButtonStartGame))
			Application.LoadLevel(GlobalNames.SCENE_ID_GAME);
		if (GUILayout.Button(tex_ButtonOptions))
            Application.LoadLevel(GlobalNames.SCENE_ID_OPTIONS);
		if (GUILayout.Button(tex_ButtonQuit))
            Application.LoadLevel(GlobalNames.SCENE_ID_MAINMENU);
		
		GUILayout.EndHorizontal();
		
		GUI.Label(new Rect(Screen.width/2, Screen.height/2, 100, 100), "Highscores");
		
		
		//todo: draw highscores
	}
}
