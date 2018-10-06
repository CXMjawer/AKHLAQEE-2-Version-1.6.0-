using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitalPlayerPosition : MonoBehaviour {
public float x=0.0f;
public float y=0.0f;
public float z=0.0f;

	// Use this for initialization
	void Start () {
		  transform.position = new Vector3(x, y, z);
	}
	
	
}
