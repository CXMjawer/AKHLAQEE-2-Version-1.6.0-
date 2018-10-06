using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {
 float speed = 10f;

	void Update () {
		if(Time.timeScale==1){
		transform.Translate(0, 0, speed);
		}else{
			transform.Translate(0, 0, 0);
		}

}
}
