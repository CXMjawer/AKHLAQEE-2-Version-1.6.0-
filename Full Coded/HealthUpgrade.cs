using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUpgrade : MonoBehaviour {
	 public GameObject HealthAnimator;
	 public float Timer = 5.25f;
	 int Exit=1;
     void Update()
     {
         if (FruitsCollectables.FruitCounter == 100 && Exit == 1){
             HealthAnimator.GetComponent<Animator>().enabled = true;
             StartCoroutine(LateCall());
             Exit = 2;
             Timer = 5.25f;
         }
         if (FruitsCollectables.FruitCounter == 500 && Exit == 2){
             HealthAnimator.GetComponent<Animator>().enabled = true;
             StartCoroutine(LateCall());
             Exit = 3;
             Timer = 5.25f;
         }
         if (FruitsCollectables.FruitCounter == 1000 && Exit == 3){
             HealthAnimator.GetComponent<Animator>().enabled = true;
             StartCoroutine(LateCall());
             Exit = 0;
             Timer = 5.25f;
         }
 
         
     }
 
     IEnumerator LateCall()
     {
 
         yield return new WaitForSeconds(Timer);
 
         HealthAnimator.GetComponent<Animator>().enabled = false;
         //Do Function here...
     }
 }

