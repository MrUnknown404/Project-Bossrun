using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	public float MoveSpeed;

	private Rigidbody Rb;
	private Vector3 MoveInput;
	private Vector3 MoveVelocity;

	void Start () {
		//ID
		Rb = GetComponent<Rigidbody>();
	}

	void Update () {
		//Get Input
		MoveInput = new Vector3(Input.GetAxisRaw("Key_Horizontal"),0f,0f) * MoveSpeed;
	}

	void FixedUpdate () {
		//Move
		MoveInput.y = Rb.velocity.y;
		MoveVelocity = MoveInput;
		Rb.velocity = MoveVelocity;
	}
}

