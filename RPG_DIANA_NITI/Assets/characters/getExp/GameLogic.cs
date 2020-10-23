using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic {

//calculeaza experienta necesara pentru a trece la nivelul urmator

	public static float ExperienceForNextLevel(int currentLevel){
		if (currentLevel == 0)
			return 0;
		return(currentLevel * currentLevel + currentLevel + 3) * 4;
	
	}
}
