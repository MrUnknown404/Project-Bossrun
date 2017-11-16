using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public Transform Target;
	public float SmoothSpeed = 10f;
	public Vector3 Offset;

	private Camera MainCamera;

	void Start () {
		//ID
		MainCamera = FindObjectOfType<Camera>();
	}

	void FixedUpdate () {
		//Vectors
		Vector3 DesiredPosition = Target.position + Offset;
		Vector3 SmoothedPosition = Vector3.Lerp (transform.position,DesiredPosition,SmoothSpeed * Time.deltaTime);
		//Move Camera
		transform.position = SmoothedPosition;
	}
}
