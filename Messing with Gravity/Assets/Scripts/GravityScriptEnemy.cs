using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScriptEnemy : MonoBehaviour {

//	float posY;
//	float posX;
//	public float gravityY;
//	public float gravityX;
//	public float velocityY;
//	public float velocityX;


	public static GravityScriptEnemy instance;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
//
//		velocityY = velocityY - gravityY * Time.deltaTime; 
//		velocityX = velocityX - gravityX * Time.deltaTime;


/*------------------------------------------------------------------------------------
------------------------------TRANSLATE MOVEMENT--------------------------------------
-------------------------------------------------------------------------------------*/
//		//TRANSLATE-based movement along the Y-axis.
	//	transform.position = new Vector2 (posX, posY -= velocityY * Time.deltaTime);
//
//		//TRANSLATE-based movement along the Y-axis.
	//	transform.position = new Vector2 (posX -= velocityX * Time.deltaTime, posY);

//		if (Input.GetKey (KeyCode.X)) {
//			gravityY = 0f;
//			velocityY = 0f;
//			Debug.Log ("X was pressed");
//		}
//
//		if (Input.GetKey (KeyCode.W)) {
//			gravityY = 9.8f;
//			//transform.Translate (Vector3.down * 50f * Time.deltaTime);
//			Debug.Log ("W was pressed");
//		} 
//
//		if(Input.GetKey(KeyCode.S)){
//			//transform.Translate(Vector3.up * 50f * Time.deltaTime);
//			gravityY = -9.8f;
//			Debug.Log ("S was pressed");
//		} 
//
//		if (Input.GetKey (KeyCode.A)) {
//			gravityX = -9.8f;
//			//transform.Translate (Vector3.down * 50f * Time.deltaTime);
//			Debug.Log ("A was pressed");
//		}  
//
//		if(Input.GetKey (KeyCode.D)){
//			//transform.Translate(Vector3.up * 50f * Time.deltaTime);
//			gravityX = 9.8f;
//			Debug.Log ("D was pressed");
//		}  


/*------------------------------------------------------------------------------------
------------------------------ADDFORCE MOVEMENT--------------------------------------
-------------------------------------------------------------------------------------*/			


/*------------------------------------------------------------------------------------
------------------------------CLAMP SPEED--------------------------------------
-------------------------------------------------------------------------------------*/			

		


/*------------------------------------------------------------------------------------
------------------------------GRAVITY EXPERIMENT--------------------------------------
-------------------------------------------------------------------------------------*/			

	

	}

	//Sets normal gravity (down on the Y-axis)
	void GravNormal() {
		Physics.gravity = new Vector3(0, -9.8F, 0);
	}

	//Sets gravity to pull up on the Y-axis
	void GravUp(){
		Physics.gravity = new Vector3(0, 9.8F, 0);
	}

	//Sets gravity to pull left on the X-axis
	void GravLeft(){
		Physics.gravity = new Vector3 (-9.8f, 0, 0);
	}

	//Sets gravity to pull right on the X-axis
	void GravRight(){
		Physics.gravity = new Vector3 (9.8f, 0, 0);
	}

	//NOTE: you can control everyone else's gravity by sending them a message. 
	

	
}

