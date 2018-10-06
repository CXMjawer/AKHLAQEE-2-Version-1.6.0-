using System.Collections;
using UnityEngine;

public class TransPlaces : MonoBehaviour {

public GameObject GardenEnvironment;
public GameObject MosqueEnvironment;
public GameObject HouseyEnvironment;
public GameObject NeighbEnvironment;
public bool Garden;
public bool Mosque;
public bool Housey;
public bool Neighb;

	void OnTriggerEnter(Collider Col){
		if (Col.gameObject.tag == "Player") {
			GardenEnvironment.SetActive(Garden);
			MosqueEnvironment.SetActive(Mosque);
			HouseyEnvironment.SetActive(Housey);
			NeighbEnvironment.SetActive(Neighb);
		}
	}
}

