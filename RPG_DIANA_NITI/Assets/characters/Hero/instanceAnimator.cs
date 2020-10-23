using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanceAnimator : MonoBehaviour {
	public static Object instance;
	// Use this for initialization
	void Awake () {//Awake deoarece incepe inainte de start
		if (!instance)
			instance = this;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
