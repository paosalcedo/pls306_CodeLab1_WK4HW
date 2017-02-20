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
	public static GunScript instance;
	public bool rocketPressed;
	AudioSource gravgunSound;
	 

	void Start () {
		player = GameObject.Find ("Player");
		gunUpPressed = false;
		gunDownPressed = true;
		gunLeftPressed = false;
		gunRightPressed = false;
		rocketPressed = false;

	}
		

	void Update () {
		//Aim ();

	
		//testing gun rotation controls. Rotates the "Gun" object around an axis which is at the center of Player transform.
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.RotateAround (player.transform.position, Vector3.forward, rotateSpeed * Time.deltaTime);			
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.RotateAround (player.transform.position, Vector3.forward, -rotateSpeed * Time.deltaTime);			
		}


		//Adding gravgun audio
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (gunDownPressed || gunUpPressed || gunLeftPressed || gunRightPressed) {
				gravgunSound = GetComponent<AudioSource> ();
				gravgunSound.Play ();
			}


		}
		


/*--------------------------------------------------------------------------
 --------------------ASSIGNING GRAV GUN SETTINGS TO NUMBERS 1-4------------
 ---------------------------------------------------------------------------*/
		if(Input.GetKeyDown(KeyCode.Alpha1) && gunDownPressed == false){
		  //	gunDown = true;
			gunDownPressed = true;
			gunUpPressed = false;
			gunLeftPressed = false;
			gunRightPressed = false;
			rocketPressed = false;

			Debug.Log ("1 Grav Gun Normal Setting");
		}

		if(Input.GetKeyDown(KeyCode.Alpha2) && gunUpPressed == false){
			//gunUp = true;
			gunDownPressed = false;
			gunUpPressed = true;
			gunLeftPressed = false;
			gunRightPressed = false;
			rocketPressed = false;

			Debug.Log ("2 Grav Gun Up is Down Setting");
		}

		if(Input.GetKeyDown(KeyCode.Alpha3) && gunLeftPressed == false){
			//gunLeft = true;
			gunDownPressed = false;
			gunUpPressed = false;
			gunLeftPressed = true;
			gunRightPressed = false;
			rocketPressed = false;

			Debug.Log ("3 Grav Gun Left is Down Setting");
		}

		if(Input.GetKeyDown(KeyCode.Alpha4) && gunRightPressed == false){
			//gunRight = true;
			gunDownPressed = false;
			gunUpPressed = false;
			gunLeftPressed = false;
			gunRightPressed = true;
			rocketPressed = false;

			Debug.Log ("4 Grav Gun Right Is Down Setting");
		}

		if(Input.GetKeyDown(KeyCode.Alpha5) && rocketPressed == false){
			rocketPressed = true;
			gunDownPressed = false;
			gunUpPressed = false;
			gunLeftPressed = false;
			gunRightPressed = false;

			Debug.Log ("5 Rocket Selected");
		}
	}
}
