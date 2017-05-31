﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController: MonoBehaviour {
	public static LevelController current;

	Vector3 startingPosition;
	void Awake ()
	{
		current = this;
	}
	public void setStartPosition (Vector3 pos){
		this.startingPosition = pos;
	}
	public void onRabitDeath (HeroRabit rabit){
        rabit.resetHealth();
		rabit.transform.position = this.startingPosition;
        
	}

}