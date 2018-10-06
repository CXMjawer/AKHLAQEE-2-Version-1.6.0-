using System.Collections;
using UnityEngine;

public class LoadMosque : MonoBehaviour {

	void OnTriggerEnter(Collider Col){
		if (Col.gameObject.tag == "Player") {
			Application.LoadLevel ("Mosque");
		}
	}

}
