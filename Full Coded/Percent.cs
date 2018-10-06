using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PercentCollected : MonoBehaviour {
	
	public static float PercentNum;
	Text text;
	void Start () {
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = PercentNum.ToString();

		}
	}

