using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour {

	public float posY;
	public float posX;
	public float gravity;
	public float velocity;
	// Use this for initialization
	void Start () {
		gravity = 9.8f;

	}
	
	// Update is called once per frame
	void Update () {


	
		velocity = velocity - gravity * Time.deltaTime; 
		//transform.position = new Vector2 (posX, posY -= velocity * Time.deltaTime);

		//add an upward translate to the player.

		if (Input.GetKey (KeyCode.X)) {
			gravity = 0f;
			velocity = 0f;
			Debug.Log ("X was pressed");
		}

		if (Input.GetKey (KeyCode.W)) {
			gravity = 9.8f;
			//transform.Translate (Vector3.down * 50f * Time.deltaTime);
			Debug.Log ("W was pressed");
		}

		if(Input.GetKey (KeyCode.S)){
			//transform.Translate(Vector3.up * 50f * Time.deltaTime);
			gravity = -9.8f;
			Debug.Log ("S was pressed");
		}
			
	}
}
