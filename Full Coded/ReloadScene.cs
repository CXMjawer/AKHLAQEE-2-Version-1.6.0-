using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadScene : MonoBehaviour {

	
	public void SetRestart () {
		 Application.LoadLevel(Application.loadedLevel);
	}
	

}
