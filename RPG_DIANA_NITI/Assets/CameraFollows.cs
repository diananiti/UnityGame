
using UnityEngine;

public class CameraFollows : MonoBehaviour {


	public Transform target;

	public float smoothSpeed=0.125f;
	public Vector3 offset;//offset pe toate axele


	void FixedUpdete(){
		Vector3 desiredPosition=target.position+offset;
		Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
		transform.position=smoothedPosition;

		transform.LookAt (target);
	}

}
