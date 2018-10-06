using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Timer : MonoBehaviour {

	public Text cText;
	public float Sec, Min;

	void Start () {
		cText = GetComponent<Text>() as Text;
	}
	

	void Update () {
		Min = (int)(Time.time/60f);
		Sec = (int)(Time.time%60f);
		//cText.text = Min.ToString("00") + ":" + Sec.ToString("00");
		cText.text = System.DateTime.Now.ToString("");
	}
}
