using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TurretRotation : MonoBehaviour {

	private Vector3 mousePos;
	private Vector3 offset;
	private float rotateAngle;
	
	void FixedUpdate () {
		mousePos = Camera.main.ScreenToWorldPoint(CrossPlatformInputManager.mousePosition);
		mousePos.z = -10f;
		offset = transform.position - mousePos;
		rotateAngle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0, 0, rotateAngle);
	}
}
