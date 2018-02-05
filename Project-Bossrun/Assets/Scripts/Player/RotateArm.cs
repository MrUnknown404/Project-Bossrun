using UnityEngine;

public class RotateArm : MonoBehaviour {

	[SerializeField]
	private Camera cam;
	private Vector3 mousePos;

	private void Update() {
		mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z - cam.transform.position.z));
		transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((mousePos.y - transform.position.y), (mousePos.x - transform.position.x)) * Mathf.Rad2Deg);
	}
}
