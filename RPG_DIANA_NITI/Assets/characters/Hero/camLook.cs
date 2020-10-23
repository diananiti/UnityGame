
using UnityEngine;

public class camLook : MonoBehaviour {

	Vector2 mouseLook;//keeps track of the total movement of the mouse
	Vector2 smoothV;
	public float sensitivity=1.0f;
	public float smoothing = 0.5f;
	GameObject character;

	void Start () {
		character = this.transform.parent.gameObject;	
	}
	

	void Update () {
		var mouseDelta = new Vector2 (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
		mouseDelta=Vector2.Scale(mouseDelta,new Vector2(sensitivity*smoothing,sensitivity*smoothing));
			smoothV.x=Mathf.Lerp(smoothV.x,mouseDelta.x,1f /smoothing);	
			smoothV.y=Mathf.Lerp(smoothV.y,mouseDelta.y,1f /smoothing);	
			mouseLook+=smoothV;
			transform.localRotation=Quaternion.AngleAxis(-mouseLook.y,Vector3.right);
			character.transform.localRotation=Quaternion.AngleAxis(mouseLook.x,character.transform.up);

	}
}
