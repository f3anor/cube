using UnityEngine;
using System.Collections;

/// <summary>
/// Main Menu Script and base class for other menus:)
/// </summary>
public class MenuMain : MonoBehaviour
{
		
	public Texture2D tex_MenuBackground;
	public Texture2D tex_ButtonStartGame;
	public Texture2D tex_ButtonOptions;
	public Texture2D tex_ButtonCredits;
	public Texture2D tex_ButtonHighscore;
	public Texture2D tex_ButtonQuit;
	public bool useTexturedButtons = false;

    public int menuPositionX = 530;
    public int menuPositionY = 270;

	void Start ()
	{
	
	}
	
	void OnGUI ()
	{
		//BG Image
		GUI.Box (new Rect (0, 0, Screen.width, Screen.height), " ");
		GUI.Label (new Rect (0, 0, Screen.width, Screen.height), tex_MenuBackground);
		
		//buttons
        GUILayout.BeginArea(new Rect(menuPositionX, menuPositionY, Screen.width, Screen.height));
		
		GUILayout.BeginVertical ();
		
		if (useTexturedButtons == false) {
			//testbuttons
			if (GUILayout.Button ("Start Game"))
				Application.LoadLevel (GlobalNames.SCENE_ID_GAME);
			if (GUILayout.Button ("Options"))
				Application.LoadLevel (GlobalNames.SCENE_ID_OPTIONS);		
			if (GUILayout.Button ("Highscore"))
				Application.LoadLevel (GlobalNames.SCENE_ID_HIGHSCORE);
			if (GUILayout.Button ("Credits"))
				Application.LoadLevel (GlobalNames.SCENE_ID_CREDITS);
			if (GUILayout.Button ("Quit"))
				Application.Quit ();
		} else {
			
			//buttons with textures
			if (GUILayout.Button (tex_ButtonStartGame))
				Application.LoadLevel (GlobalNames.SCENE_ID_GAME);
			if (GUILayout.Button (tex_ButtonOptions))
				Application.LoadLevel (GlobalNames.SCENE_ID_OPTIONS);		
			if (GUILayout.Button (tex_ButtonHighscore))
				Application.LoadLevel (GlobalNames.SCENE_ID_HIGHSCORE);
			if (GUILayout.Button (tex_ButtonCredits))
				Application.LoadLevel (GlobalNames.SCENE_ID_CREDITS);
			if (GUILayout.Button (tex_ButtonQuit))
				Application.Quit ();
		
		}
        GUILayout.BeginVertical();
		
		GUILayout.EndArea ();	

	}
}
