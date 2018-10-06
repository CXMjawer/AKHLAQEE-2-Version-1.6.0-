using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class CameraModes : MonoBehaviour {

public GameObject MODER1;
public GameObject MODER2;
public GameObject MODER3;

public GameObject Trackor1;
public GameObject Trackor2;
public GameObject Trackor3;

public GameObject Face1;
public GameObject Face2;
public GameObject Face3;

public GameObject P1Camera1;
public GameObject P1Camera2;
public GameObject P1Camera3;
public GameObject P1Camera4;

public GameObject P2Camera1;
public GameObject P2Camera2;
public GameObject P2Camera3;
public GameObject P2Camera4;

public GameObject P3Camera1;
public GameObject P3Camera2;
public GameObject P3Camera3;
public GameObject P3Camera4;

public GameObject UICamera1;
public GameObject UICamera2;
public GameObject UICamera3;
public GameObject UICamera4;

public GameObject P1C;
public GameObject P2C;
public GameObject P3C;

public GameObject P1T;
public GameObject P2T;
public GameObject P3T;

public GameObject P1Name;
public GameObject P2Name;
public GameObject P3Name;

public static short Index1=1;
public static short Index2=1;

	void Update () {
		if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown("joystick button 6")){
				Index1++;	

				if(Index1==1){
					P1Camera1.SetActive(true);
					P1Camera2.SetActive(false);
					P1Camera3.SetActive(false);
					P1Camera4.SetActive(false);
					P2Camera1.SetActive(true);
					P2Camera2.SetActive(false);
					P2Camera3.SetActive(false);
					P2Camera4.SetActive(false);
					P3Camera1.SetActive(true);
					P3Camera2.SetActive(false);
					P3Camera3.SetActive(false);
					P3Camera4.SetActive(false);

					UICamera1.SetActive(true);
					UICamera2.SetActive(false);
					UICamera3.SetActive(false);
					UICamera4.SetActive(false);
				}
				if(Index1==2){
					P1Camera1.SetActive(false);
					P1Camera2.SetActive(true);
					P1Camera3.SetActive(false);
					P1Camera4.SetActive(false);
					P2Camera1.SetActive(false);
					P2Camera2.SetActive(true);
					P2Camera3.SetActive(false);
					P2Camera4.SetActive(false);
					P3Camera1.SetActive(false);
					P3Camera2.SetActive(true);
					P3Camera3.SetActive(false);
					P3Camera4.SetActive(false);

					UICamera1.SetActive(false);
					UICamera2.SetActive(true);
					UICamera3.SetActive(false);
					UICamera4.SetActive(false);
				}
				if(Index1==3){
					P1Camera1.SetActive(false);
					P1Camera2.SetActive(false);
					P1Camera3.SetActive(true);
					P1Camera4.SetActive(false);
					P2Camera1.SetActive(false);
					P2Camera2.SetActive(false);
					P2Camera3.SetActive(true);
					P2Camera4.SetActive(false);
					P3Camera1.SetActive(false);
					P3Camera2.SetActive(false);
					P3Camera3.SetActive(true);
					P3Camera4.SetActive(false);

					UICamera1.SetActive(false);
					UICamera2.SetActive(false);
					UICamera3.SetActive(true);
					UICamera4.SetActive(false);
				}
				if(Index1==4){
					P1Camera1.SetActive(false);
					P1Camera2.SetActive(false);
					P1Camera3.SetActive(false);
					P1Camera4.SetActive(true);
					P2Camera1.SetActive(false);
					P2Camera2.SetActive(false);
					P2Camera3.SetActive(false);
					P2Camera4.SetActive(true);
					P3Camera1.SetActive(false);
					P3Camera2.SetActive(false);
					P3Camera3.SetActive(false);
					P3Camera4.SetActive(true);

					UICamera1.SetActive(false);
					UICamera2.SetActive(false);
					UICamera3.SetActive(false);
					UICamera4.SetActive(true);
				}
				if(Index1>=4){
					Index1=0;
				}
		}
	if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown("joystick button 4")){
							Index2--;
							if(Index2<=0){
									Index2=1;
								}
						}
		if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown("joystick button 5")){
			Index2++;
				if(Index2>=3){
					Index2=3;
				}
		
			}

				if(Index2==1){
					MODER1.SetActive(true);
					MODER2.SetActive(false);
					MODER3.SetActive(false);

					Trackor1.SetActive(true);
					Trackor2.SetActive(false);
					Trackor3.SetActive(false);

					Face1.SetActive(true);
					Face2.SetActive(false);
					Face3.SetActive(false);

					P1Name.SetActive(true);
					P2Name.SetActive(false);
					P3Name.SetActive(false);

					P1C.GetComponent<SimpleCharacterControl>().enabled = true;
					P2C.GetComponent<SimpleCharacterControl>().enabled = false;
					P3C.GetComponent<SimpleCharacterControl>().enabled = false;

					P1T.GetComponent<ThirdPersonUserControl>().enabled = true;
					P2T.GetComponent<ThirdPersonUserControl>().enabled = false;
					P3T.GetComponent<ThirdPersonUserControl>().enabled = false;
				}
				if(Index2==2){
					MODER1.SetActive(false);
					MODER2.SetActive(true);
					MODER3.SetActive(false);

					Trackor1.SetActive(false);
					Trackor2.SetActive(true);
					Trackor3.SetActive(false);

					Face1.SetActive(false);
					Face2.SetActive(true);
					Face3.SetActive(false);

					P1Name.SetActive(false);
					P2Name.SetActive(true);
					P3Name.SetActive(false);

					P1C.GetComponent<SimpleCharacterControl>().enabled = false;
					P2C.GetComponent<SimpleCharacterControl>().enabled = true;
					P3C.GetComponent<SimpleCharacterControl>().enabled = false;
					
					P1T.GetComponent<ThirdPersonUserControl>().enabled = false;
					P2T.GetComponent<ThirdPersonUserControl>().enabled = true;
					P3T.GetComponent<ThirdPersonUserControl>().enabled = false;
				}
				if(Index2==3){
					MODER1.SetActive(false);
					MODER2.SetActive(false);
					MODER3.SetActive(true);

					Trackor1.SetActive(false);
					Trackor2.SetActive(false);
					Trackor3.SetActive(true);

					Face1.SetActive(false);
					Face2.SetActive(false);
					Face3.SetActive(true);

					P1Name.SetActive(false);
					P2Name.SetActive(false);
					P3Name.SetActive(true);

					P1C.GetComponent<SimpleCharacterControl>().enabled = false;
					P2C.GetComponent<SimpleCharacterControl>().enabled = false;
					P3C.GetComponent<SimpleCharacterControl>().enabled = true;

					P1T.GetComponent<ThirdPersonUserControl>().enabled = false;
					P2T.GetComponent<ThirdPersonUserControl>().enabled = false;
					P3T.GetComponent<ThirdPersonUserControl>().enabled = true;
				}
			
		
	}
}
