using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minmap : MonoBehaviour {

	public Transform player;

	void LateUpdate(){
try{
		Vector3 newPosition = player.position;
		newPosition.y = transform.position.y;
		transform.position = newPosition;
		transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
			} catch (UnassignedReferenceException URE){
				//Do nothing and Don't crash either..
			}
	}
}
