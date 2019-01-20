using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ShipMovement : MonoBehaviour {

	private float horizMovement;
	private float verticalMovement;
	private Vector3 movementWithSpeed;
	public float speed;
	
	void FixedUpdate() {
		horizMovement = CrossPlatformInputManager.GetAxis("Horizontal");
		verticalMovement = CrossPlatformInputManager.GetAxis("Vertical");
		movementWithSpeed = new Vector3(horizMovement, verticalMovement, 0) * speed * Time.deltaTime;
		transform.position += movementWithSpeed;
	}
}
