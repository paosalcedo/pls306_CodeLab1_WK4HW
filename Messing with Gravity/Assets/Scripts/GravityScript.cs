using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour {

	public float posY;
	public float posX;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		//add an upward translate to the player.
		if (Input.GetKeyDown (KeyCode.W)) {
			//transform.Translate (Vector3.down * 50f * Time.deltaTime);
			transform.position = new Vector2 (posX, posY += 9.8f * Time.deltaTime);
			Debug.Log ("W was pressed");
		}

		if(Input.GetKeyDown (KeyCode.S)){
			//transform.Translate(Vector3.up * 50f * Time.deltaTime);
			transform.position = new Vector2 (posX += 9.8f * Time.deltaTime, posY);
			Debug.Log ("S was pressed");
		}
	}
}
