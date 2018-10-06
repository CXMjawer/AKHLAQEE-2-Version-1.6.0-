using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWalk : MonoBehaviour {

	public int Xpos;
	public int Zpos;
	public GameObject NPCDest;


	void Start () {
		Xpos = Random.Range(74, 105);
		Zpos = Random.Range(67, 86);
		NPCDest.transform.position = new Vector3(Xpos, 0, Zpos);
		StartCoroutine(RunRandomWalk());
	}


	void Update () {
		transform.LookAt(NPCDest.transform);
		transform.position = Vector3.MoveTowards(transform.position, NPCDest.transform.position, 0.0001f);
	}

	IEnumerator RunRandomWalk ()
	{
		yield return new WaitForSeconds(5);
		Xpos = Random.Range(74, 105);
		Zpos = Random.Range(67, 86);
		NPCDest.transform.position = new Vector3(Xpos, 0, Zpos);
		StartCoroutine(RunRandomWalk());
	}
}
