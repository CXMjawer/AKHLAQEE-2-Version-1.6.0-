using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cleaning : MonoBehaviour {
	
	public static int Clearing;
	Text text;
	
	void Start () {
		text = GetComponent<Text>();
	
	}
	
	void Update () {
		text.text = Clearing.ToString();
	}
}