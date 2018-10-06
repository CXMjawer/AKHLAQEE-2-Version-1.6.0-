using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthRestoreFew : MonoBehaviour {

public Slider Health;
	void Update () {
		Health.value+=0.001f;
	}
}
