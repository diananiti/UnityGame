using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMerge : MonoBehaviour {
	


		Vector3 targetPosition;
		Vector3 lookAtTarget;
		Quaternion playerRot;
		float rotSpeed =1;
		float speed=2;
		bool moving=false;


		void Update () {
			if (Input.GetMouseButton (0)) {
				SetTargetPosition ();

			}
			if (moving) {
				Move ();
			}
		}

		void SetTargetPosition(){
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);//pozitia mousului 
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 1000)) {
				targetPosition = hit.point;
				//	this.transform.LookAt (SetTargetPosition);
				lookAtTarget=new Vector3(targetPosition.x-transform.position.x,
					transform.position.y,targetPosition.z-transform.position.z );
				playerRot = Quaternion.LookRotation (lookAtTarget);
				moving = true;
			}
		}

		void Move(){
			transform.rotation = Quaternion.Slerp (transform.rotation, playerRot
				, rotSpeed * Time.deltaTime);
			transform.position = Vector3.MoveTowards (transform.position, targetPosition, speed * Time.deltaTime);
			if (transform.position == targetPosition)
				moving = false;
		}




}
