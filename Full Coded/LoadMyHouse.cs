using System.Collections;
using UnityEngine;

public class LoadMyHouse : MonoBehaviour {

	void OnTriggerEnter(Collider Col){
		if (Col.gameObject.tag == "Player") {
			Application.LoadLevel ("MyHome");
		}
	}

}
