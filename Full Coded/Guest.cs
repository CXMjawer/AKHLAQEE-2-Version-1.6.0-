using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guest : MonoBehaviour {

    public void StartGame(){
		Application.LoadLevel ("StartMenu");
	}
	public void LoginGame(){
		Application.LoadLevel ("Login Menu");
	}

}
