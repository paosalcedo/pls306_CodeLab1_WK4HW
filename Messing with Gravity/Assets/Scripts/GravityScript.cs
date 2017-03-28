using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour {

//	float posY;
//	float posX;
//	public float gravityY;
//	public float gravityX;
//	public float velocityY;
//	public float velocityX;
	
	public bool downIsDown;
	public bool leftIsDown;
	public bool rightIsDown;
	public bool upIsDown;
	
	public float moveSpeed;
	public float jumpForce;
	public float maxVelocity;

//	public KeyCode downKey = KeyCode.S;
//	public KeyCode leftKey = KeyCode.A;
//	public KeyCode rightKey = KeyCode.D;
//	public KeyCode upKey = KeyCode.W;
//	public KeyCode jumpKey;

	public KeyCode downKey;
	public KeyCode leftKey;
	public KeyCode rightKey;
	public KeyCode upKey; 


	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		GravNormal ();
 	}
	
	// Update is called once per frame
	void Update (){
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

		//Clamping velocity
		if (rb.velocity.magnitude > maxVelocity) {
			rb.velocity = rb.velocity.normalized * maxVelocity;
		}

//		Debug.Log (rb.velocity.magnitude);


		//Change the movement keys to correspond to where gravity is pulling from.
		if (downIsDown) {
			Move (Vector3.left, leftKey);
			Move (Vector3.right, rightKey);
			Move (Vector3.down, downKey);
			Jump(Vector3.up, upKey);
		}

		if (upIsDown) {
			Jump(Vector3.down, downKey);
			Move (Vector3.left, leftKey);
			Move (Vector3.right, rightKey);
			Move (Vector3.up, upKey);				
		}

		if (leftIsDown) {
			Jump(Vector3.right, rightKey);
			Move (Vector3.up, upKey);
			Move (Vector3.right, rightKey);
			Move (Vector3.down, downKey);				
		}

		if (rightIsDown) {
			Jump(Vector3.left, leftKey);
			Move (Vector3.up, upKey);
			Move (Vector3.right, rightKey);
			Move (Vector3.down, downKey);				
		}

/*------------------------------------------------------------------------------------
------------------------------CLAMP SPEED--------------------------------------
-------------------------------------------------------------------------------------*/			

		


/*------------------------------------------------------------------------------------
------------------------------GRAVITY EXPERIMENT--------------------------------------
-------------------------------------------------------------------------------------*/			

		//Binding gravity manipulation to keys.
		if(Input.GetKeyDown(KeyCode.U) ){
			GravUp ();
	
		}

		if(Input.GetKeyDown(KeyCode.J)){
			GravNormal ();

		}

		if(Input.GetKeyDown(KeyCode.H)){
			GravLeft ();

		}

		if(Input.GetKeyDown(KeyCode.K)){
			GravRight ();
			
		}


	}

	//Sets normal gravity (down on the Y-axis)
	void GravNormal() {
		Physics.gravity = new Vector3(0, -9.8F, 0);
		upIsDown = false;
		downIsDown = true;
		rightIsDown = false;
		leftIsDown = false;
		//GravityScriptEnemy.instance.SendMessage("GravNormal");
	}

	//Sets gravity to pull up on the Y-axis
	void GravUp(){
		Physics.gravity = new Vector3(0, 9.8F, 0);
		upIsDown = true;
		downIsDown = false;
		rightIsDown = false;
		leftIsDown = false;
//		GravityScriptEnemy.instance.SendMessage("GravUp");
	}

	//Sets gravity to pull left on the X-axis
	void GravLeft(){
		Physics.gravity = new Vector3 (-9.8f, 0, 0);
		upIsDown = false;
		downIsDown = false;
		rightIsDown = false;
		leftIsDown = true;
//		GravityScriptEnemy.instance.SendMessage("GravLeft");
	}

	//Sets gravity to pull right on the X-axis
	void GravRight(){
		Physics.gravity = new Vector3 (9.8f, 0, 0);
		upIsDown = false;
		downIsDown = false;
		rightIsDown = true;
		leftIsDown = false;
//		GravityScriptEnemy.instance.SendMessage("GravRight");
	}

	//NOTE: you can control everyone else's gravity by sending them a message. 
	

	void Move(Vector3 dir, KeyCode key){
		if(Input.GetKey(key)){
			rb.AddForce (dir * moveSpeed * Time.deltaTime, ForceMode.Impulse);
		}
	}


	void Jump(Vector3 dir, KeyCode key){
		if(Input.GetKeyDown(key)){
			rb.AddForce (dir * jumpForce * Time.deltaTime, ForceMode.Impulse);
			//transform.Translate(dir * speed * Time.deltaTime);
		}
	}
}

