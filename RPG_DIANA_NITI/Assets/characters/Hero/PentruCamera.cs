using UnityEngine;
using System.Collections;

public class PentruCamera : MonoBehaviour {
	public float horizontalSpeed = 0.5F;
	public float verticalSpeed = 0.5F;
	GameObject character;
	void Start(){
		character = this.transform.parent.gameObject;
	}

	void Update() {
		float h = horizontalSpeed * Input.GetAxis("Mouse X");
		float v = verticalSpeed * Input.GetAxis("Mouse Y");
		transform.Rotate(v, h, 0);
		character.transform.localRotation=Quaternion.AngleAxis(h,character.transform.up);
	}
}