using UnityEngine;
using System.Collections;

/// <summary>
/// Main Menu Script and base class for other menus:)
/// </summary>
public class MenuMain : MonoBehaviour {
		
	public Texture2D tex_MenuBackground;  
	public Texture2D tex_ButtonStartGame;  
	public Texture2D tex_ButtonOptions;  
	public Texture2D tex_ButtonCredits;
	public Texture2D tex_ButtonHighscore;
	public Texture2D tex_ButtonQuit;
	
	void Start () 
	{
	
	}
	
	void OnGUI()
	{
		//BG Images
		GUI.Box(new Rect(0, 0, Screen.width, Screen.height), " ");
		GUI.Label( new Rect(0, 0, Screen.width, Screen.height), tex_MenuBackground);
		
		//buttons
		GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
		
		GUILayout.BeginHorizontal();
		
		//testbuttons
		if (GUILayout.Button("Start Game"))
			Application.LoadLevel(GlobalNames.SCENE_ID_GAME);
		if (GUILayout.Button("Options"))
            Application.LoadLevel(GlobalNames.SCENE_ID_OPTIONS);		
		if (GUILayout.Button("Highscore"))
            Application.LoadLevel(GlobalNames.SCENE_ID_HIGHSCORE);
		if (GUILayout.Button("Credits"))
            Application.LoadLevel(GlobalNames.SCENE_ID_CREDITS);
		if (GUILayout.Button("Quit"))
            Application.Quit();
		
		//buttons with textures
		if (GUILayout.Button(tex_ButtonStartGame))
			Application.LoadLevel(GlobalNames.SCENE_ID_GAME);
		if (GUILayout.Button(tex_ButtonOptions))
            Application.LoadLevel(GlobalNames.SCENE_ID_OPTIONS);		
		if (GUILayout.Button(tex_ButtonHighscore))
            Application.LoadLevel(GlobalNames.SCENE_ID_HIGHSCORE);
		if (GUILayout.Button(tex_ButtonCredits))
            Application.LoadLevel(GlobalNames.SCENE_ID_CREDITS);
		if (GUILayout.Button(tex_ButtonQuit))
            Application.Quit();
		
		GUILayout.EndHorizontal();
		
		GUILayout.EndArea();	

	}
}
