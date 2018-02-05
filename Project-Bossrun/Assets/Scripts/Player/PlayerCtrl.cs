using UnityEngine;

public class PlayerCtrl : MonoBehaviour {
	
	private float speed = 5f;
	private float jumpForce = 50000f;
	private bool isGrounded;

	private Rigidbody rb;

	private void Start() {
		rb = GetComponent<Rigidbody>();
	}

	private void Update() {
		float _xMov = Input.GetAxisRaw("Key_Horizontal");
		Vector3 _movHorz = transform.right * _xMov;
		Vector3 _velocity = _movHorz.normalized * speed;
		Vector3 _jumpForce = Vector3.zero;

		Move(_velocity);

		if (Input.GetKeyDown(KeyCode.W) && isGrounded == true) {
			_jumpForce = Vector3.up * jumpForce;
		}

		if (_jumpForce != Vector3.zero) {
			rb.AddForce(_jumpForce * Time.fixedDeltaTime, ForceMode.Acceleration);
		}
	}

	private void Move(Vector3 _velocity) {
		if (_velocity != Vector3.zero) {
			rb.MovePosition(rb.position + _velocity * Time.fixedDeltaTime);
		}
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Ground") {
			isGrounded = true;
		}
	}

	void OnCollisionExit(Collision col) {
		if (col.gameObject.tag == "Ground") {
			isGrounded = false;
		}
	}
}
