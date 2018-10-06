using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System;

public class DisableEnableObject : MonoBehaviour {

public GameObject EnableObject;
public GameObject DisableObject;
public GameObject ObjectAnimatorOFF; 
public GameObject ObjectAnimatorON; 
	public Transform ThirdPersonControlOFF;
	public Transform ThirdPersonControlON;
	public Transform SimpleCharacterOFF;
	public Transform SimpleCharacterON;

	void OnTriggerEnter(Collider Col){

if (Col.gameObject.tag == "Player"){
	try{
	EnableObject.gameObject.SetActive(true);
	DisableObject.SetActive(false);
	ObjectAnimatorOFF.GetComponent<Animator>().enabled = false;
	ObjectAnimatorON.GetComponent<Animator>().enabled = true;
			SimpleCharacterOFF.GetComponent<SimpleCharacterControl>().enabled = false;
			ThirdPersonControlOFF.GetComponent<ThirdPersonUserControl>().enabled = false;
			SimpleCharacterON.GetComponent<SimpleCharacterControl>().enabled = true;
			ThirdPersonControlON.GetComponent<ThirdPersonUserControl>().enabled = true;
			} catch (UnassignedReferenceException URE){
				//Do nothing and Don't crash either..
			}
	}
}
}
