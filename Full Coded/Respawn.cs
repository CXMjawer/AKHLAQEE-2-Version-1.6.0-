using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	public float ZRespawnFloat;
   		void OnTriggerEnter(Collider Col)
    	 {  

    	 	if (Col.gameObject.CompareTag("Cars")){
       	 	   Col.transform.Translate(0.0f, 0.0f, ZRespawnFloat);
  			}  	 
    	 
    	 }
}