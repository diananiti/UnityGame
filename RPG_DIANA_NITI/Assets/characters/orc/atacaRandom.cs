using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class atacaRandom : MonoBehaviour {

	public Slider HPbarEnemy;
	public float delay = 1f;
	Animator animatie;
	public string enemy;
	public GameObject go;
	public int expGranted;
	public Slider StaminaEn;
	public Slider PtStamina;
	public Slider PtHp;
	public Slider NextStamina;
	public Slider NextHp;

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag != enemy)
			return; //cand este atacat de hero
		else {
			
			HPbarEnemy.value -= 21;
			StaminaEn.value -= 21;
	
		}
		if (HPbarEnemy.value <= 0) {
			Die (); 
			return; 

		}
		if (StaminaEn.value <= 0) {
			GetComponent<Controls> ().enabled = false;
			animatie.SetBool ("sta",true);
			animatie.SetBool ("ataca", false);
			animatie.SetBool ("merge", false);

		}
		Debug.Log ("Lovit");

	}
	void Awake() {
		go = GameObject.FindGameObjectWithTag ("Hero");
		animatie = GetComponent<Animator> ();
	
	}


	void Update () {

	}
	void Die(){
		
		animatie.SetBool ("moare", true);
		PtStamina.value = 100;
		PtHp.value = 100;
		go.GetComponent<playerEXP>().SetExperience(expGranted);
		GetComponent<Urmareste>().enabled=false; //dezactiveaza urmarirea jucatorului dupa ce a murit
		//GameObject.Destroy (this.gameObject, 5);//mobul dispare dupa 5 sec
		Destroy(this.gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length+delay);
		NextStamina.value = 100;
		NextHp.value = 100;
	}
}
