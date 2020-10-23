using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow2 : MonoBehaviour {

	GameObject playerObj;
	Vector3 cameraOffSet;
	// Use this for initialization
	void Start () {

		playerObj = GameObject.Find("Hero");
		cameraOffSet = new Vector3 (-5, 3, -5);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = playerObj.transform.position + cameraOffSet;
	}
}
