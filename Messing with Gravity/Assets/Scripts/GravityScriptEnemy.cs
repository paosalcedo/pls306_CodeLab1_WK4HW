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
	GameObject beam;
	public float gravForce = 100f; 
	public static GravityScriptEnemy instance;
	Rigidbody rb;
	GameObject gun;
	bool gunHit;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		gun = GameObject.Find ("Gun");
		beam = GameObject.Find ("Beam");
	}
	
	// Update is called once per frame
	void Update () {
//		velocityY = velocityY - gravityY * Time.deltaTime; 
//		velocityX = velocityX - gravityX * Time.deltaTime;	

		//set gravity to normal (down is down) for enemies. 
		if (gun.GetComponent<GunScript>().gunDownPressed) {
			GravNormal ();
		}
	
		Ray ray = new Ray (gun.transform.position, gun.transform.right);
		RaycastHit rayHit = new RaycastHit ();

		if (Physics.Raycast (ray, out rayHit, 1000f) && Input.GetKeyDown(KeyCode.Space)) {
			if (rayHit.transform == this.transform) { 		//Adds reverse gravity (up in this case) when raycast hits object. BOOL VERSION.
				Debug.Log ("raycast hit!");
				gunHit = true;
			}
		}

		//Adds reverse gravity (up in this case) when raycast hits object. BOOL VERSION.
		if (gunHit && gun.GetComponent<GunScript>().gunDownPressed) {
			rb.AddForce (Vector3.down * gravForce * Time.deltaTime);
			Debug.Log ("Grav down");
		}

		if (gunHit && gun.GetComponent<GunScript>().gunLeftPressed) {
			rb.AddForce (Vector3.left * gravForce * Time.deltaTime);
			Debug.Log ("Grav left");

		}

		if (gunHit && gun.GetComponent<GunScript>().gunRightPressed) {
			rb.AddForce (Vector3.right * gravForce * Time.deltaTime);
			Debug.Log ("Grav right");

		}

		if (gunHit && gun.GetComponent<GunScript>().gunUpPressed) {
			rb.AddForce (Vector3.up * gravForce * Time.deltaTime);
			Debug.Log ("Grav up");
		}

			
	

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
//	void GravNormal() {
//		Physics.gravity = new Vector3(0, -9.8F, 0);
//	}
//
//	//Sets gravity to pull up on the Y-axis
//	void GravUp(){
//		Physics.gravity = new Vector3(0, 9.8F, 0);
//	}
//
//	//Sets gravity to pull left on the X-axis
//	void GravLeft(){
//		Physics.gravity = new Vector3 (-9.8f, 0, 0);
//	}
//
//	//Sets gravity to pull right on the X-axis
//	void GravRight(){
//		Physics.gravity = new Vector3 (9.8f, 0, 0);
//	}

	void GravNormal() {
		rb.AddForce(Vector3.down * gravForce * Time.deltaTime);
	}

	//Sets gravity to pull up on the Y-axis
	void GravUp(){
		rb.AddForce(Vector3.up * gravForce * Time.deltaTime);
	}

	//Sets gravity to pull left on the X-axis
	void GravLeft(){
		rb.AddForce(Vector3.left * gravForce * Time.deltaTime);	
	}

	//Sets gravity to pull right on the X-axis
	void GravRight(){
		rb.AddForce(Vector3.right * gravForce * Time.deltaTime);	
	}

	void GetMouse(){
		
	}

	

	
}

