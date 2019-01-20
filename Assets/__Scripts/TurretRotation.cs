using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TurretRotation : MonoBehaviour {

	private Vector3 mousePos;
	private Vector3 turretPos;
	private Vector3 offset;
	private float rotateAngle;
	
	void FixedUpdate () {
		mousePos = Camera.main.ScreenToWorldPoint(CrossPlatformInputManager.mousePosition);
		mousePos.z = -10f;
		targetPos = transform.position - mousePos;
		rotateAngle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
	}
}
