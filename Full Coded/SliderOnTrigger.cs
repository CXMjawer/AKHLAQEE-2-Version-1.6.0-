using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class SliderOnTrigger : MonoBehaviour {

	public Slider slider;
    public GameObject ObjectON;


	// if this script is on an object with a collider display the Gui
	void OnTriggerEnter(Collider Col) 
	{
		if (Col.gameObject.CompareTag("Player")){
	
		slider.value-=0.25f;
	
		if(slider.value<=0){
			ScoreCollected.ScoreAmount-=500;
			ObjectON.SetActive (true);//Score's Object
			if(ScoreCollected.ScoreAmount <= 0){
				ScoreCollected.ScoreAmount = 0;
				ObjectON.SetActive (false);
			}
		}
}
}
	void OnTriggerExit(Collider Col){
		
		ObjectON.SetActive (false);

		}
}
