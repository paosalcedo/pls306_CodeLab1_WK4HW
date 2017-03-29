using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour {

	public float startTime = 0f;
		
	private float timeToComplete;

	private float timeSpent = 0f;

	private float goodTime = 175f;

	private const string PREF_GOOD_TIME = "goodTimePref";

	public static TimerScript instance;

	public float TimeSpent{
		get{
			return timeToComplete;	
		}

		set{
			timeToComplete = value;

 			if(timeToComplete < GoodTime){
				GoodTime = timeToComplete;
				Debug.Log("New best time!!!!!!");
			}

 		}
	}

	public float GoodTime {
		get{
			goodTime = PlayerPrefs.GetFloat(PREF_GOOD_TIME);
			return goodTime;
		}

		set{
			Debug.Log("New best time!");
			goodTime = value;
			PlayerPrefs.SetFloat(PREF_GOOD_TIME, goodTime);
		}
	}

	// Use this for initialization
	void Start () {
		PlayerPrefs.DeleteKey(PREF_GOOD_TIME);
		timeSpent = startTime;
		if(instance == null){
			//set instance to this instance of ScoreManager
			instance = this;
			//Dont destroy this gameObject when you go to a new scene
			DontDestroyOnLoad(this);
		} else { //otherwise, if we already have a singleton
			//Destroy the new one, since there can only be one
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		CountUp();	
		CheckTime();		
	}

	void CountUp ()
	{
//		Debug.Log(timeSpent);
		timeSpent += Time.deltaTime;
//		if (ScoreChangerScript.instance.Score > 30) {
//			timeSpent = timeToComplete;
//			Invoke ("RestartGame", 3f);
//			}
	}

	void CheckTime ()
	{
		if (Input.GetKeyDown (KeyCode.P)) {
			Debug.Log ("GoodTime is " + GoodTime);
			Debug.Log ("goodTime is " + goodTime);
			Debug.Log ("time spent to complete is: " + timeToComplete);
			PlayerPrefs.DeleteKey(PREF_GOOD_TIME);

		}
	}
	void RestartGame()
	{
		SceneManager.LoadScene("Main");
	}
}

