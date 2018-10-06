using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLevels : MonoBehaviour {
public GameObject Effects;

	void OnTriggerEnter(Collider Col) {
		Effects.SetActive(true);
	}
	
	void OnTriggerExit(Collider Col) {
		Effects.SetActive(false);
	}
}
