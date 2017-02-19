using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravGunArrowScript : MonoBehaviour {

	GameObject gun;

	// Use this for initialization
	void Start () {
		gun = GameObject.Find ("Gun");
	}
	
	// Update is called once per frame
	void Update () {

		if (gun.GetComponent<GunScript>().gunDownPressed) {
			transform.eulerAngles = new Vector3 (0, 0, 180f);
		}

		if (gun.GetComponent<GunScript>().gunUpPressed) {
			transform.eulerAngles = new Vector3 (0, 0, 0f);
		}

		if (gun.GetComponent<GunScript>().gunRightPressed) {
			transform.eulerAngles = new Vector3 (0, 0, 270f);
		}

		if (gun.GetComponent<GunScript>().gunLeftPressed) {
			transform.eulerAngles = new Vector3 (0, 0, 90f);
		}
	}
}
