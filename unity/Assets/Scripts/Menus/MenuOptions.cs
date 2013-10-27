using UnityEngine;
using System.Collections;


/// <summary>
/// Options Menu
/// </summary>
public class MenuOptions : MenuMain {
		

	public string playerName; //todo: write playername to playerPrefs and check for changes
	
	void OnGUI()
	{
		GUILayout.BeginHorizontal();
		
		if (GUILayout.Button("Start Game"))
			Application.LoadLevel(GlobalNames.SCENE_ID_GAME);
		if (GUILayout.Button("Back to Main Menu"))
            Application.LoadLevel(GlobalNames.SCENE_ID_MAINMENU);
		if (GUILayout.Button("Highscore"))
            Application.LoadLevel(GlobalNames.SCENE_ID_HIGHSCORE);
		
		GUILayout.EndHorizontal();
		
		GUILayout.BeginHorizontal();
		GUILayout.Label("Player Name: ");
		playerName = GUI.TextField(new Rect(100, 100, 200, 20), playerName, 40);
		GUILayout.EndHorizontal();
	}
}
