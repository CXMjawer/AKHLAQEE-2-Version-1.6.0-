using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsCollected : MonoBehaviour {
	
	public static int StarsAmount;
	Text text;
	void Start () {
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = StarsAmount.ToString();

		}
	}

