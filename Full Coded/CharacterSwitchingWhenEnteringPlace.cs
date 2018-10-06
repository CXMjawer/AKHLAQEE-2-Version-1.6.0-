using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitchingWhenEnteringPlace : MonoBehaviour {

	public GameObject Player1;
	public GameObject Player2;
	public GameObject Player3;

	void OnTriggerEnter (Collider Col) {

		if (CameraModes.Index2 == 1){

			Player1.SetActive(true);
			Player2.SetActive(false);
			Player3.SetActive(false);
		}
		if (CameraModes.Index2 == 2){

			Player1.SetActive(false);
			Player2.SetActive(true);
			Player3.SetActive(false);
		}
		if (CameraModes.Index2 == 3){

			Player1.SetActive(false);
			Player2.SetActive(false);
			Player3.SetActive(true);
		}
		
	}
}
