using System.Collections;
using UnityEngine;

public class LoadGarden : MonoBehaviour {

	void OnTriggerEnter(Collider Col){
		if (Col.gameObject.tag == "Player") {
			Application.LoadLevel ("Loading");
		}
	}

}
