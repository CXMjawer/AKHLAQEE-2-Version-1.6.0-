using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NPC : MonoBehaviour {
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ThePlayer;
	public GameObject TextBox;
	public GameObject NPCName;
	public GameObject NPCText;


	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver () {
		if (TheDistance <= 3) {
			ActionText.GetComponent<Text> ().text = "Talk";
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}

		if (Input.GetButtonDown ("Action")) {
			if (TheDistance <= 3) {
				ActionDisplay.SetActive (false);
				ActionText.SetActive (false);
				//ThePlayer.SetActive (false);
				StartCoroutine (NPC001Active ());
			}
		}
	}

	void OnMouseExit() {
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}

	IEnumerator NPC001Active () {
		TextBox.SetActive (true);
		NPCName.GetComponent<Text> ().text = "Father";
		NPCName.SetActive (true);
		NPCText.GetComponent<Text>().text = "Hello my kid, I want u to explore the garden .";
		NPCText.SetActive(true);
		yield return new WaitForSeconds(5.5f);
		NPCName.SetActive(false);
		NPCText.SetActive(false);
		TextBox.SetActive(false);
		ActionDisplay.SetActive (true);
		ActionText.SetActive (true);

	}

}

