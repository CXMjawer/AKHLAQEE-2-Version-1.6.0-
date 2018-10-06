using System.Collections;
using UnityEngine;

public class TransMosque : MonoBehaviour {

public GameObject GardenEnvironment;
public GameObject MosqueEnvironment;
public GameObject HouseyEnvironment;

	void OnTriggerEnter(Collider Col){
		if (Col.gameObject.tag == "Player") {
			GardenEnvironment.SetActive(false);
			MosqueEnvironment.SetActive(true);
			HouseyEnvironment.SetActive(false);
		}
	}

}

