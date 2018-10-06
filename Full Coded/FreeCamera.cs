using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCamera : MonoBehaviour {

//Axis Movement
 float ZoomIn = 0.1f;//o
 float ZoomOut = -0.1f;//u
 float MoveUp = 0.1f;//w
 float MoveDown = -0.1f;//s
 float MoveRight = 0.1f;//d
 float MoveLeft = -0.1f;//a

//Axis Rotation
 float RotateUp = -0.5f;//i
 float RotateDown= 0.5f;//k
 float RotateRight = 0.5f;//l
 float RotationLeft = -0.5f;//j

//Position
public GameObject ResetPosition;
	
	void Update () {
		//Movement
		if (Input.GetKey(KeyCode.O)){
			transform.Translate(0, 0, ZoomIn);
		}
		if (Input.GetKey(KeyCode.U)){
			transform.Translate(0, 0, ZoomOut);
		}
		if (Input.GetKey(KeyCode.W)){
			transform.Translate(0, MoveUp, 0);
		}
		if (Input.GetKey(KeyCode.S)){
			transform.Translate(0, MoveDown, 0);
		}
		if (Input.GetKey(KeyCode.D)){
			transform.Translate(MoveRight, 0, 0);
		}
		if (Input.GetKey(KeyCode.A)){
			transform.Translate(MoveLeft, 0, 0);
		}

		//Rotation
		if (Input.GetKey(KeyCode.I)){
			transform.Rotate(RotateUp, 0 , 0);
		}
		if (Input.GetKey(KeyCode.K)){
			transform.Rotate(RotateDown, 0 , 0);
		}
		if (Input.GetKey(KeyCode.L)){
			transform.Rotate(0, RotateRight, 0);
		}
		if (Input.GetKey(KeyCode.J)){
			transform.Rotate(0, RotationLeft, 0);
		}



	
		
	}
}
