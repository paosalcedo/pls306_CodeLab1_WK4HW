using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravArrowScript : MonoBehaviour {

	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (player.GetComponent<GravityScript>().downIsDown) {
			transform.eulerAngles = new Vector3 (0, 0, 180f);
		}

		if (player.GetComponent<GravityScript>().upIsDown) {
			transform.eulerAngles = new Vector3 (0, 0, 0f);
		}

		if (player.GetComponent<GravityScript>().rightIsDown) {
			transform.eulerAngles = new Vector3 (0, 0, 270f);
		}

		if (player.GetComponent<GravityScript>().leftIsDown) {
			transform.eulerAngles = new Vector3 (0, 0, 90f);
		}
		
	}
}
