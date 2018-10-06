using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OpenGame : MonoBehaviour {
public int InformationGained  = 0;
public int StarsGained  = 0;
public int TrophiesGained  = 0;
public int QuizzesSolved  = 0;
public int TrashCleaned  = 0;
public float Percent  = 0f;
public int Score  = 0;
public int Liver = 4;
public int Gems = 0;
public Slider Health;
public int HealthValue;
	
	void  Start () {

		
		InfoCollected.CoinsAmount = InformationGained;
		StarsCollected.StarsAmount = StarsGained;
		TrophiesCollected.TrophiesAmount = TrophiesGained;
		QuizCollected.QuizAmount  = QuizzesSolved;
		Cleaning.Clearing = TrashCleaned;
		PercentCollected.PercentNum = Percent;
		ScoreCollected.ScoreAmount = Score;
		Lives.Life = Liver;
		GemGather.GemGet = Gems;
		Health.value = HealthValue;
		
	}
	
	public void SetLife(Slider L){

		Lives.Life = (int)L.value; 
	}
}
