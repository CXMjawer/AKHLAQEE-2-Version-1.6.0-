using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {

public Slider EnemyHealth;
public GameObject Slapper;
public GameObject[] Enemies;
public GameObject PercentAnimator;

	void OnTriggerEnter (Collider Col) {
		
		if (Slapper.CompareTag("Hurt")){
				EnemyHealth.value-=0.05f;

				if(EnemyHealth.value <= 0f && Col.gameObject.CompareTag("Enemy")){
					Col.gameObject.SetActive(false);
					ScoreCollected.ScoreAmount+=1000;
					PercentAnimator.GetComponent<Animator>().Play("");
				}

		}
	}

}
