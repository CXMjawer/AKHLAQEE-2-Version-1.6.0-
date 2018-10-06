using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class InfoCollected : MonoBehaviour {
	
	public static int CoinsAmount=0;
	Text text;
	
	void Start () {
		text = GetComponent<Text>();
	}
	

	void Update () {
		try{

		text.text = CoinsAmount.ToString();

		}
		catch (NullReferenceException NRE){

		}
	}
}
