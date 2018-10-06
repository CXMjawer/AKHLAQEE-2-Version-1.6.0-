using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSelfDestruct : MonoBehaviour {

public GameObject Object;
	void Start () {
		Destroy (Object, 1.15f);
	}

}
