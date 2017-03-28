using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChangerScript : MonoBehaviour {

	private const int SCORE_START = 0;

	private static int score;

	public static ScoreChangerScript instance;

	public int scoreAmt = 10;

	public int Score{ 
		get{
			Debug.Log(score);
			return score;
		}

		set{
			score = value;
		}
	}

 
	void Start () { 
		Score = SCORE_START;

		if(instance == null){
			instance = this;
			DontDestroyOnLoad(this);
		} else {
			Destroy(gameObject);
		}
	}
	
	void Update () {

	}

	void IncreaseScore(){		
		Score += scoreAmt;
		Debug.Log(name + " Score: " + Score);
	}

}