using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class ScoringSystem : MonoBehaviour
{		
	public static int maxHighscores = 10; //indicates how many high scores are stored in the list
	private string playerName; 
		
	private EventManager _eventManager; 
	
	void Start()
	{
		 _eventManager = EventManager.getInstance();
		
		if(_eventManager != null)
			_eventManager.addListener(ScoringSystem_OnRestartLoss, EventManager.eventName.OnRestartLoss);
		
		playerName = PlayerPrefs.GetString("PlayerName");
	}
		
	private void ScoringSystem_OnRestartLoss(GameObject g, EventArgs e)
    {
		AddScore(playerName, GameManager.getInstance().currentRound);
        Debug.Log("ScoringSystem_OnRestartLoss");
    }
	
	
	public void AddScore (string name, int score)
	{
		int newScore;
		string newName;
		int oldScore;
		string oldName;
		
		
		newScore = score;
		newName = name;
		
		for (int i=0; i<maxHighscores; i++) {
			if (PlayerPrefs.HasKey ("ScoreNr" + i)) {
				if (PlayerPrefs.GetInt ("ScoreNr" + i) < newScore) { 
					// new score higher than the stored score
					oldScore = PlayerPrefs.GetInt ("ScoreNr" + i);
					oldName = PlayerPrefs.GetString ("ScoreName" + i);
					
					PlayerPrefs.SetInt ("ScoreNr" + i, newScore);
					PlayerPrefs.SetString ("ScoreName" + i, newName);
					
					newScore = oldScore;
					newName = oldName;
				}
			} else {
				PlayerPrefs.SetInt ("ScoreNr" + i, newScore);
				PlayerPrefs.SetString ("ScoreName" + i, newName);
				newScore = 0;
				newName = "";
			}
		}
		
		SaveScoreData (); // write to prefs
	}
	
	public void SaveScoreData ()
	{
		PlayerPrefs.Save ();
	}
}

