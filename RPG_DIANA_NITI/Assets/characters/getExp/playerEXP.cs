using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerEXP : MonoBehaviour {

//	public Animator anim;

	public int level ;
	public Text levelText;//referinta catre text
	public int experience { get;  set; }
	public Transform experienceBar;//referinta catre silder de exp

	//public int experienceNeeded;





	void Start () {
		experienceBar = UIController.instance.transform.Find ("Experience") ;
		levelText = UIController.instance.transform.Find ("Level_Text").GetComponent<Text> ();
		//SetExperience (0);
	}
	

	void Update () {
		
	}
	public void SetExperience(int exp){
		experience+= exp;
		float experienceNeeded=GameLogic.ExperienceForNextLevel(level);
		float previousExperience=GameLogic.ExperienceForNextLevel(level-1);
		//lvl up
		if (experience>=experienceNeeded){
			LevelUp();
		experienceNeeded=GameLogic.ExperienceForNextLevel(level);
			previousExperience=GameLogic.ExperienceForNextLevel(level-1);

		}
		experienceBar.Find("Fill_bar").transform.GetComponent<Image>().fillAmount=(experience-previousExperience)/(experienceNeeded-previousExperience);
	}
	void LevelUp(){
		level++;
		levelText.text = "Level" + level.ToString ("00");
	}0

}
