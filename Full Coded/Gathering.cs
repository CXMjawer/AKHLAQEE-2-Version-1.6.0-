using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Gathering : MonoBehaviour {

		public static int CollectFiveInfosToGetOneStar = 0;
		public static int CollectFiveStarsToGetOneTrophy = 0;
		public GameObject ObjectEnabler;  
	 	public GameObject CoinsAudioSource;
	 	public GameObject StarsAudioSource;
	 	public GameObject TrophAudioSource;
	 	public Slider slider;
	 	public GameObject PercentAnimator;
		public Transform RespawnPoint;
		public Transform player1;
		public Transform player2;
		public Transform player3;
		public GameObject Continue;
		public GameObject HealthWarning;
		public GameObject Completion;


	void OnTriggerEnter(Collider Other){
		try{
			
		
			Destroy (gameObject, 0.1f);
			if (Other.gameObject.CompareTag("Player")){
			InfoCollected.CoinsAmount += 1;
			slider.value+=0.1f;
			PercentCollected.PercentNum += 0.67f;
			PercentAnimator.GetComponent<Animator>().Play("");
			ScoreCollected.ScoreAmount+=100;
			CoinsAudioSource.GetComponent<AudioSource>().Play();
			CollectFiveInfosToGetOneStar += 1;
		
		
			if (CollectFiveInfosToGetOneStar == 5){
		    CollectFiveInfosToGetOneStar=0;
			StarsCollected.StarsAmount+=1;
			slider.value+=0.2f;
			PercentCollected.PercentNum += 0.67f;
			PercentAnimator.GetComponent<Animator>().Play("");
			ScoreCollected.ScoreAmount+=500;
			StarsAudioSource.GetComponent<AudioSource>().Play();
			CollectFiveStarsToGetOneTrophy+=1;
			Lives.Life+=1;
						
		}

			if (CollectFiveStarsToGetOneTrophy == 5){
			TrophiesCollected.TrophiesAmount+=1;
			PercentCollected.PercentNum += 0.67f;
			PercentAnimator.GetComponent<Animator>().Play("");
			slider.value+=0.3f;
			ScoreCollected.ScoreAmount+=5000;
			Lives.Life+=1;
			TrophAudioSource.GetComponent<AudioSource>().Play();

		}
		
		

		gameObject.GetComponent<Renderer>().enabled = false;
   		gameObject.GetComponent<Collider>().enabled = false;
		}


		}catch (UnassignedReferenceException URE){
			//Handle it and don't suddenly crash 
		}
}


	void Update(){
		if (CollectFiveStarsToGetOneTrophy == 5) {
			ObjectEnabler.SetActive(true);
			CollectFiveStarsToGetOneTrophy = 0;
		}
		if (CollectFiveStarsToGetOneTrophy == 3){
			ObjectEnabler.SetActive(false);
		}
		if (InfoCollected.CoinsAmount >= 100){
			InfoCollected.CoinsAmount =100;
		}
		if(StarsCollected.StarsAmount >= 25){
			StarsCollected.StarsAmount = 25;
		}
		if(TrophiesCollected.TrophiesAmount >= 5){
			TrophiesCollected.TrophiesAmount = 5;
			CollectFiveInfosToGetOneStar = 0;
		    CollectFiveStarsToGetOneTrophy = 0;
			Destroy (ObjectEnabler.gameObject, 1);
		}
		if(QuizCollected.QuizAmount >= 10){
			QuizCollected.QuizAmount  = 10;
		}
		if(Cleaning.Clearing >= 15){
			Cleaning.Clearing=15;
		}
		if(PercentCollected.PercentNum >= 100){
			PercentCollected.PercentNum = 100;
			Completion.SetActive(true);
		}
		
		if(slider.value <=0){
			
			if (CameraModes.Index2==1){

			CameraModes.Index2=1;
			player1.transform.position = RespawnPoint.transform.position;
			slider.value = 1;
			Lives.Life-=1;

			}
			if (CameraModes.Index2==2){

			CameraModes.Index2=2;
			player2.transform.position = RespawnPoint.transform.position;
			slider.value = 1;
			Lives.Life-=1;

			}
			if (CameraModes.Index2==3){

			CameraModes.Index2=3;
			player3.transform.position = RespawnPoint.transform.position;
			slider.value = 1;
			Lives.Life-=1;

			}
			if(Lives.Life <= 0){

			Lives.Life = 4;
			Continue.SetActive(true);
			
			}

		
		}	
			if(slider.value<=1.0f){
						HealthWarning.GetComponent<Animator>().enabled = true;
						//HeartSound.clip = Resources.Load<AudioClip>("Heart Beat");
						//HeartSound.Play();
					}else {
						HealthWarning.GetComponent<Animator>().enabled = false;
						HealthWarning.GetComponent<Image>().color = new Color32(99,0,0,255);
						//HeartSound.Stop();
					}
	}

	
}