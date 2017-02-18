using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

	GameObject player;
	// Use this for initialization
	public float rotateSpeed = 10f;
	bool gunUp;
	public bool gunUpPressed;
	bool gunDown;
	public bool gunDownPressed;
	bool gunLeft;
	public bool gunLeftPressed;
	bool gunRight;
	public bool gunRightPressed;

	void Start () {
		player = GameObject.Find ("Player");
		gunUpPressed = false;
		gunDownPressed = false;
		gunLeftPressed = false;
		gunRightPressed = false;

	}
	
	// Update is called once per frame
	void Update () {
		//Aim ();

		//testing gun rotation controls. Rotates the "Gun" object around an axis which is at the center of Player transform.
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.RotateAround (player.transform.position, Vector3.forward, rotateSpeed * Time.deltaTime);			
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.RotateAround (player.transform.position, Vector3.forward, -rotateSpeed * Time.deltaTime);			
		}


/*--------------------------------------------------------------------------
 --------------------ASSIGNING GRAV GUN SETTINGS TO NUMBERS 1-4------------
 ---------------------------------------------------------------------------*/
		if(Input.GetKeyDown(KeyCode.Alpha1) && gunDownPressed == false){
			gunDown = true;
			gunDownPressed = true;
			gunUpPressed = false;
			gunLeftPressed = false;
			gunRightPressed = false;
			Debug.Log ("1 Grav Gun Normal Setting");
		}

		if(Input.GetKeyDown(KeyCode.Alpha2) && gunUpPressed == false){
			gunUp = true;
			gunDownPressed = false;
			gunUpPressed = true;
			gunLeftPressed = false;
			gunRightPressed = false;
			Debug.Log ("2 Grav Gun Up is Down Setting");
		}

		if(Input.GetKeyDown(KeyCode.Alpha3) && gunLeftPressed == false){
			gunLeft = true;
			gunDownPressed = false;
			gunUpPressed = false;
			gunLeftPressed = true;
			gunRightPressed = false;
			Debug.Log ("3 Grav Gun Left is Down Setting");
		}

		if(Input.GetKeyDown(KeyCode.Alpha4) && gunRightPressed == false){
			gunRight = true;
			gunDownPressed = false;
			gunUpPressed = false;
			gunLeftPressed = false;
			gunRightPressed = true;
			Debug.Log ("4 Grav Gun Right Is Down Setting");
		}
	}
	void Aim () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + rotateSpeed);
			Debug.Log ("Rotating!");
		}
			
	}
}
