using UnityEngine;
using System.Collections;


/// <summary>
/// Options Menu
/// </summary>
public class MenuOptions : MenuMain {
		

	
	void Update () {
	
	}
	
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
		
		
	}
}
