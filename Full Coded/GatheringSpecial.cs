using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatheringSpecial : MonoBehaviour {

		public static int CollectFiveInfosToGetOneStar = 0;
		public static int CollectFiveStarsToGetOneTrophy = 0;
	 	public AudioSource Source;
	 	public float DestroyTimer = 0.0f;

	void Start()
	{
		 Source = GetComponent<AudioSource>();
	
	}

	void OnTriggerEnter(Collider Other)
	{
		Destroy (gameObject, DestroyTimer);
	   if (Other.gameObject.CompareTag("Player"))
	  
	   	{
//INFOS
		//InfoCollected.CoinsAmount += 1;
			StarsCollected.StarsAmount+=1;
		ScoreCollected.ScoreAmount+=5000;//5000 Score!
		CollectFiveInfosToGetOneStar += 5;

//TROPHIES
		if (CollectFiveStarsToGetOneTrophy == 5){
			CollectFiveStarsToGetOneTrophy=0;
			TrophiesCollected.TrophiesAmount+=1;
		}
		Source.Play();

   		gameObject.GetComponent<Renderer>().enabled = false;
   		gameObject.GetComponent<Collider>().enabled = false;		
		}

	}
}