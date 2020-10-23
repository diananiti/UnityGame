using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour {
	
	static Animator animatie;
	public float speed = 1.0f;
	public float rotationSpeed = 100.0f;
	//public Slider StaminaHero;
	void Start () {
		animatie = GetComponent<Animator> ();
	Cursor.lockState = CursorLockMode.Locked; // in timpul miscarii dispare cursorul
	}
	

	void Update () {
		float translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;//rotatie atasata straffe-ului stanga dreapta din sageti
		translation *= Time.deltaTime;//miscari uniforme in timp si spatiu z axes
		straffe *= Time.deltaTime;//tot transatie x axes
		transform.Translate (straffe, 0, translation);


		if (Input.GetMouseButton (1)) {
			animatie.SetTrigger("ataca");
		
		
		} else {
			
			animatie.SetBool ("sta", true);
		}
		//se misca
		if (translation != 0) {//daca se misca fata spate
			animatie.SetBool ("esteInMiscare", true);
			animatie.SetBool ("sta", false);
		} else 
		//sta
		{
			animatie.SetBool ("esteInMiscare", false);
			animatie.SetBool ("sta", true);
		}
		if (Input.GetKeyDown ("escape")) {
		Cursor.lockState = CursorLockMode.None;

		}
		if(Input.GetKeyDown("space")){
			Cursor.lockState = CursorLockMode.Locked;
		}
	}
}




