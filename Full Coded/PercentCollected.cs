using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Percent : MonoBehaviour {
	
	public static float PercentNum;
	
	Text text;
	void Start () {
		text = GetComponent<Text>();
text.text = PercentNum.ToString("F3");
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = PercentNum.ToString("F3");
		}
	}

