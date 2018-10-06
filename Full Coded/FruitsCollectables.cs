using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FruitsCollectables : MonoBehaviour {

		Text text;
		public static int FruitCounter;
		public GameObject[] Fruits;
		public GameObject ChewSFX;
		public GameObject PercentAnimator;
	 	public Slider slider;
		void OnTriggerEnter(Collider Col){

			if (Col.CompareTag("Fruits")){
				FruitCounter+=1;
				ScoreCollected.ScoreAmount+=500;
				Destroy (Col.gameObject);
				ChewSFX.GetComponent<AudioSource>().Play();
				PercentAnimator.GetComponent<Animator>().Play("");
				slider.value+=0.2f;

			}

	}
		void Start(){
			Fruits = GameObject.FindGameObjectsWithTag("Fruits");
			text = GetComponent<Text>();
		}

		void Update () {
			text.text = FruitCounter.ToString()+" x ";
		}
}
	
