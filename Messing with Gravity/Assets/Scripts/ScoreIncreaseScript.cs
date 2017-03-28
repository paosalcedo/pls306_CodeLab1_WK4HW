using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncreaseScript : MonoBehaviour {

	GameObject gameManager;
	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find("WK3GameManager");
	}
	
	// Update is called once per frame
	void Update () {
				
	}

	void OnTriggerEnter ()
	{
		gameManager.SendMessage("IncreaseScore");
	}
}
