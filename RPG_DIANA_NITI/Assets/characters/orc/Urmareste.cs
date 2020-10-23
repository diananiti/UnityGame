using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Urmareste : MonoBehaviour {
	public Slider HPbar;
	public Transform player;
 Animator animatie;   //acesta nu trebuie sa fie static deoarece dupa ce am apelat fct 
	//destroy pe un enemy nu mai poate fi instantiat animatorul pentru ceilalti inamici=> erori
	//public Slider StaminaEn;
	void Start () {
		animatie = GetComponent<Animator> ();
	}
	void Update ()
	{
		if (HPbar.value <= 0) {
			animatie.SetBool ("ataca", false);
			animatie.SetBool ("merge", false);
			animatie.SetBool ("sta", true);
			return;

		}//oprim restul codului
		else {

			Vector3 direction = player.position - this.transform.position;
			float angle = Vector3.Angle (direction, this.transform.forward);
			if (Vector3.Distance (player.position, this.transform.position) < 20 && angle < 120) {
			
				direction.y = 0;
				this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);

				animatie.SetBool ("sta", false);
				Debug.Log ("0");
				if (direction.magnitude > 2f) {
					this.transform.Translate (0, 0, 0.05f);
					animatie.SetBool ("merge", true);
					animatie.SetBool ("ataca", false);
					Debug.Log ("1");

				} else {
					animatie.SetBool ("merge", false);
					animatie.SetBool ("ataca", true);
					//	
			
					Debug.Log ("2");
				}
			} else {
				animatie.SetBool ("sta", true);
				animatie.SetBool ("merge", false);
				animatie.SetBool ("ataca", false);
				Debug.Log ("3");
			}


		}
	}
}
