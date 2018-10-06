using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnablePlayers : MonoBehaviour {

	public GameObject Player1;
	public GameObject Player2;
	public GameObject Player3;

void OnTriggerEnter (Collider Col) {

			Player1.SetActive(true);
			Player2.SetActive(true);
			Player3.SetActive(true);
		
}
}