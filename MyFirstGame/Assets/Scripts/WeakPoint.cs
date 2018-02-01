﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakPoint : MonoBehaviour {
	public GameObject bloodSpray;

	// Collision with enemy
	void OnTriggerEnter(Collider other) {
		Debug.Log ("Collided!" + other.tag);
		if (other.tag == "Enemy") {
			//Debug.Log ("Collided!");
			Vector3 collisionPoint = GetComponent<Collider> ().ClosestPointOnBounds (other.transform.position);
			Instantiate (bloodSpray, collisionPoint, Quaternion.identity);
		}
	}
}
