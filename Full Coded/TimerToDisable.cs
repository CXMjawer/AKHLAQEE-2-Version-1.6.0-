using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerToDisable : MonoBehaviour {
public GameObject gameObject;
	 public float sec = 2f;
     void Start()
     {
         if (gameObject.activeInHierarchy)
             gameObject.SetActive(true);
 
         StartCoroutine(LateCall());
     }
 
     IEnumerator LateCall()
     {
 
         yield return new WaitForSeconds(sec);
 
         gameObject.SetActive(false);
         //Do Function here...
     }
 }