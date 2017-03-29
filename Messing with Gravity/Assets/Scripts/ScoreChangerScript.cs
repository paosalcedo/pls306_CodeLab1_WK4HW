using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChangerScript : MonoBehaviour {

	private const string PREF_HIGH_SCORE = "highScorePref";
	
	private int score;


	public int scoreAmt = 10;

	public int Score { 
		get {
			return score;
		}

		set {
			score = value;

			if (score > HighScore) {
				HighScore = score;
			}
			Debug.Log(score);
		}
	}

	private int highScore = 20;

	public int HighScore {
		get{ 
			return highScore;
		}
		set{ 
			Debug.Log("NEW HIGH SCORE!!! CONGRATULATIONS!!!");
			highScore = value;
			PlayerPrefs.SetInt(PREF_HIGH_SCORE, highScore);
		}
	}

	public static ScoreChangerScript instance;

	void Start ()
	{ 
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this);
		} else {
			Destroy(gameObject);
		}
	}
	
	void Update () {

	}

	void IncreaseScore(){		
		Score += scoreAmt;
//		Debug.Log(name + " Score: " + Score);
	}

}