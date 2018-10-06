using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System;

public class PopUpInfo : MonoBehaviour {
		public Transform Messages;
		public Transform Player;

	void OnTriggerEnter(Collider Col){
	
	 				Messages.gameObject.SetActive(true);//MessagePopUp
	 				//Contorollers Disable
					Player.GetComponent<ThirdPersonUserControl>().enabled = false;
					Player.GetComponent<SimpleCharacterControl>().enabled = false;
					Player.GetComponent<ThirdPersonCharacter>().enabled = false;
					AudioListener.volume = 0;//Shutdown Sounds
			 
		

		
}
}
