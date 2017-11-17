using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	
	public float MoveSpeed;
	public float JumpHeight;

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
		if (transform.position.y <= -20) {
			SceneManager.LoadScene ("Debug",LoadSceneMode.Single);
		}
	}

	void FixedUpdate () {
		//Move
		MoveInput.y = Rb.velocity.y - 1;
		MoveVelocity = MoveInput;
		Rb.velocity = MoveVelocity;
		//Jump (Detect For Ground Will Be Done Later!)
		if (Input.GetButton("Key_Jump")) {
			Rb.AddForce(new Vector2(0f, JumpHeight));
		}
	}
}

