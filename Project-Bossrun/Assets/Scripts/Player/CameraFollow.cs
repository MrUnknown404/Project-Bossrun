using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Transform target;
	private float smoothSpeed = 6f;
	private Vector3 offset = new Vector3(0f, 2.5f, -12f);

	private void Start() {
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}

	private void LateUpdate() {
		Vector3 desiredPosition = target.TransformPoint(offset);
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
		transform.position = smoothedPosition;
	}
}
