using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObject : MonoBehaviour {
public GameObject LevelEnabler;
public GameObject LevelDisabler;

 void OnTriggerEnter(Collider Col){

 	LevelEnabler.SetActive(true);
 	LevelDisabler.SetActive(false);

 }
}
