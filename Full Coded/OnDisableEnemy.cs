using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDisableEnemy : MonoBehaviour {

	public GameObject Sparkles;
	void OnDisable () {
		Sparkles.SetActive(true);
	}
	
}
