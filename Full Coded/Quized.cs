using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Quized : MonoBehaviour {

	   	 
public GameObject Source;

	


	void OnTriggerEnter(Collider Other){
		Destroy (gameObject, 0f);
			
			if (Other.gameObject.CompareTag("Player")){
			QuizCollected.QuizAmount += 1;
			PercentCollected.PercentNum += 0.6f;
			
			ScoreCollected.ScoreAmount += 600;
			Source.GetComponent<AudioSource>().Play();


		gameObject.GetComponent<Renderer>().enabled = false;
   		gameObject.GetComponent<Collider>().enabled = false;
   		
		}
}
}

				