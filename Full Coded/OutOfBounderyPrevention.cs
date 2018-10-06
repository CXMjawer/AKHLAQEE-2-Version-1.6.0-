using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounderyPrevention : MonoBehaviour {

	[SerializeField] private Transform player1;
	[SerializeField] private Transform player2;
	[SerializeField] private Transform player3;
	[SerializeField] private Transform RespawnPoint;
	[SerializeField] private AudioSource SoundEffect;
	
    void Start(){
	SoundEffect = GetComponent<AudioSource>();
  }


    void OnTriggerEnter(Collider Col){
		if (CameraModes.Index2==1){

			player1.transform.position = RespawnPoint.transform.position;

			}
			if (CameraModes.Index2==2){

			player2.transform.position = RespawnPoint.transform.position;
			
			}
			if (CameraModes.Index2==3){

			player3.transform.position = RespawnPoint.transform.position;
			
			}
	SoundEffect.clip = Resources.Load<AudioClip>("Warp");
	SoundEffect.Play();
	}
}

