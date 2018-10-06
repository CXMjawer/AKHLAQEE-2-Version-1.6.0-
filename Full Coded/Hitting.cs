using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitting : MonoBehaviour {

public GameObject HitAnimator;
public GameObject HitSFX;
public GameObject WeaponHand;
public GameObject WeaponBack;
public GameObject TaseringSFX;
public AudioClip[] shoot;
public AudioSource TaserSFX;
private AudioClip shootClip;
public float Timer = 5f;
int EnterCode = 1;

	void Start () {
		HitAnimator.GetComponent<Animator>().enabled=false;
		TaserSFX = TaseringSFX.GetComponent<AudioSource>();
	}
	
	
	void Update () {
		if ((Input.GetKey(KeyCode.K) || Input.GetKey("joystick button 0"))){
			HitAnimator.GetComponent<Animator>().enabled=true;
			HitSFX.SetActive(true);
			WeaponHand.SetActive(true);
			WeaponBack.SetActive(false);
			
			

		if ( EnterCode == 1){
			StartCoroutine(LateCall());
			int index = Random.Range(0, shoot.Length);
            shootClip = shoot[index];
            TaseringSFX.GetComponent<AudioSource>().clip = shootClip;
            TaseringSFX.SetActive(true);
            TaseringSFX.GetComponent<AudioSource>().Play();
            EnterCode = 0;
        }

		}else{
			HitAnimator.GetComponent<Animator>().enabled=false;
			HitSFX.SetActive(false);
			WeaponHand.SetActive(false);
			WeaponBack.SetActive(true);
			TaseringSFX.SetActive(false);
		}
	}

	 IEnumerator LateCall()
     {
 
         yield return new WaitForSeconds(Timer);
         EnterCode = 1;
    
     }
}
