using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cleaned : MonoBehaviour {


	public GameObject CleanAudioSource;
	public float DestroyTimer = 0f;
	public Slider slider;



	void OnTriggerEnter(Collider Other)
	{
		Destroy (gameObject, DestroyTimer);//This is to free up ram...
		if (Other.gameObject.CompareTag("Player")){
			//INFOS

			Cleaning.Clearing+=1;
			slider.value+=0.1f;
			PercentCollected.PercentNum += 0.67f;
			if (Cleaning.Clearing == 15) {
				TrophiesCollected.TrophiesAmount+=1;
				PercentCollected.PercentNum += 0.67f;
			}
			ScoreCollected.ScoreAmount+=300;//300 Score!
			CleanAudioSource.GetComponent<AudioSource>().Play();

			gameObject.GetComponent<Renderer>().enabled = false;
			gameObject.GetComponent<Collider>().enabled = false;


		}

	}
}