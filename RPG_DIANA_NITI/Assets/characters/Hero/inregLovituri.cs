using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class inregLovituri : MonoBehaviour {

	public Slider HPbar;
	Animator animatie;
	public string Myenemy;
	//public Slider StaminaHero;
	public Slider StaminaAdversar;
	public Slider MyStaminaIncrease;

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag != Myenemy)
			return; //coliderul nu va mai inregistra lovituri pe propriul colider
		else {// daca el m-a  lovit 
			HPbar.value -= Random.Range (20, 30); //cu cat imi scade mie HP
			StaminaAdversar.value -= Random.Range (20, 30);//cu cat ii scade lui Stamina
		}
		if (HPbar.value <= 0) {
			animatie.SetBool ("moare", true);
			GetComponent<Controls> ().enabled = false;//dupa ce moare jucatorul nu ne mai putem deplasa
		}
		if (StaminaAdversar.value <= 0) {
			animatie.SetBool ("sta",true);
			animatie.SetBool ("ataca",false);
		}
		//Debug.Log ("Lovit");
	//
	}
	void Start () {

		animatie = GetComponent<Animator> ();

	}
	

	void Update () {
		
	}


}
