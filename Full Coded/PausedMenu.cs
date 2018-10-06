using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System;

public class PausedMenu : MonoBehaviour {
		public Transform Pause;
		public Transform Player;
		public static short Pauser =0;

		void Update()
		{
			try{
			if ((Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("joystick button 7")) && Pauser == 0)
			{
				Pauser = 1;
				if (Pause.gameObject.activeInHierarchy == false){
					Pause.gameObject.SetActive(true);
					Time.timeScale=0;
					//AudioListener.volume = 0;
					Player.GetComponent<FirstPersonController>().enabled = false;
					

				}else{

					Pause.gameObject.SetActive(false);
					Time.timeScale=1;
					//AudioListener.volume = 1;
					Player.GetComponent<FirstPersonController>().enabled = true;
				
				}
			}
			else if ((Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("joystick button 7")) && Pauser == 1){
				Pauser = 0;
					Pause.gameObject.SetActive(false);
					Time.timeScale=1;
					//AudioListener.volume = 1;
					Player.GetComponent<FirstPersonController>().enabled = true;
			}
				} catch (NullReferenceException NRE){
				//Do nothing and Don't crash either..
			}
		}
	public void SetLevel(){
		Application.LoadLevel ("StartMenu");
	}
	public void SetResume(){
					Pauser =0;
					Pause.gameObject.SetActive(false);
					Time.timeScale=1;
					AudioListener.volume = 1;
					Player.GetComponent<SimpleCharacterControl>().enabled = true;
					Player.GetComponent<ThirdPersonCharacter>().enabled = true;
					Player.GetComponent<ThirdPersonUserControl>().enabled = true;
				

	}


}
