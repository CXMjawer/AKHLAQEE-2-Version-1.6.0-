using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerSound : MonoBehaviour {

	[SerializeField] private AudioSource SoundEffect;

	void Start(){
    SoundEffect = GetComponent<AudioSource>();
    }


	void OnTriggerEnter(Collider Col){
	SoundEffect.clip = Resources.Load<AudioClip>("SleepDua");
	SoundEffect.Play();
	}
}
