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
	public float weapCoolDown = 5f;
	public static GravityScriptEnemy instance;
	Rigidbody rb;
	GameObject gun;
	public bool hitByDown;
	public bool hitByUp;
	public bool hitByLeft;
	public bool hitByRight;
	public float rocketForce = 2000f;
	public float radius = 5.0f;
	public float upForce = 5f;
	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		rb = GetComponent<Rigidbody> ();
		gun = GameObject.Find ("Gun");
		beam = GameObject.Find ("Beam");
		hitByDown = true;
	}
	
	// Update is called once per frame
	void Update () {
//		velocityY = velocityY - gravityY * Time.deltaTime; 
//		velocityX = velocityX - gravityX * Time.deltaTime;	

		//Use time.deltatime for weapon cooldown.

		//set gravity to normal (down is down) for enemies. 

		//		if (gun.GetComponent<GunScript>().gunDownPressed) {
//			GravNormal ();
//		}
//	
		

		Ray ray = new Ray (gun.transform.position, gun.transform.right);
		RaycastHit rayHit = new RaycastHit ();
 

		if (Physics.Raycast (ray, out rayHit, 1000f) && Input.GetKeyDown(KeyCode.Space) && gun.GetComponent<GunScript>().gunDownPressed) {
			if (rayHit.transform == this.transform) { 		//Adds reverse gravity (up in this case) when raycast hits object. BOOL VERSION.
				Debug.Log("DOWN");
				ShowBeam();
				Invoke("HideBeam", 0.5f);
				hitByUp = false;
				hitByLeft = false;
				hitByRight = false;
				hitByDown = true;
			}
		}

		if (Physics.Raycast (ray, out rayHit, 1000f) && Input.GetKeyDown(KeyCode.Space) && gun.GetComponent<GunScript>().gunUpPressed) {
			if (rayHit.transform == this.transform) { 		//Adds reverse gravity (up in this case) when raycast hits object. BOOL VERSION.
				Debug.Log("UP");
 				hitByUp = true;
				hitByLeft = false;
				hitByRight = false;
				hitByDown = false;				
				ShowBeam();
				Invoke("HideBeam", 0.5f);

			}
		}

		if (Physics.Raycast (ray, out rayHit, 1000f) && Input.GetKeyDown(KeyCode.Space) && gun.GetComponent<GunScript>().gunRightPressed) {
			if (rayHit.transform == this.transform) { 		//Adds reverse gravity (up in this case) when raycast hits object. BOOL VERSION.
 				hitByRight = true;
				Debug.Log("RIGHT");
 				hitByUp = false;
				hitByLeft = false;
				hitByDown = false;
				ShowBeam();
				Invoke("HideBeam", 0.5f);
			}
		}

		if (Physics.Raycast (ray, out rayHit, 1000f) && Input.GetKeyDown(KeyCode.Space) && gun.GetComponent<GunScript>().gunLeftPressed) {
			if (rayHit.transform == this.transform) { 		//Adds reverse gravity (up in this case) when raycast hits object. BOOL VERSION.
 				hitByLeft = true;
				hitByUp = false;
				hitByDown = false;
				hitByRight = false;
				Debug.Log("LEFT");
				ShowBeam();
				Invoke("HideBeam", 0.5f);
			}
		}

		if (Physics.Raycast (ray, out rayHit, 1000f) && Input.GetKeyDown(KeyCode.Space) && gun.GetComponent<GunScript>().rocketPressed) {
			if (rayHit.transform.gameObject.tag == "Environment") { 		//Adds reverse gravity (up in this case) when raycast hits object. BOOL VERSION.
				player.GetComponent<Rigidbody>().AddExplosionForce(rocketForce, rayHit.point, radius);
				Debug.Log("LEFT");
			}
		}


		//Adds reverse gravity (up in this case) when raycast hits object. BOOL VERSION. Problem here is everything is affected by the toggle: if you shoot one object, then press a different grav gun setting, the object is still affected. 
		if (hitByDown) {
			rb.AddForce (Vector3.down * gravForce * Time.deltaTime);
 			
		}

		if (hitByLeft) {
			rb.AddForce (Vector3.left * gravForce * Time.deltaTime);
 			

		}

		if (hitByRight) {
			rb.AddForce (Vector3.right * gravForce * Time.deltaTime);
 			

		}

		if (hitByUp) {
			rb.AddForce (Vector3.up * gravForce * Time.deltaTime);
 		
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

 	void ShowBeam(){
		beam.GetComponent<MeshRenderer>().enabled = true;
	}

	void HideBeam(){
		beam.GetComponent<MeshRenderer>().enabled = false;
	}

	

	
}

