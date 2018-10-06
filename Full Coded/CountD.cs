using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountD : MonoBehaviour
{
	public static int timeLeft = 60;
	public Text countdownText;
	public GameObject gameObject;	
	public GameObject BlueButton;
	public GameObject GreenButton;
	public GameObject RedButton;
	public GameObject NightButton;
	public GameObject BlueGem;
	public GameObject GreenGem;
	public GameObject RedGem;
	public GameObject NightGem;
	
	void OnEnable()
	{
		StartCoroutine("LoseTime");
	}
	void OnDisable(){
		timeLeft = 60;
	}
	// Update is called once per frame
	void Update()
	{
		countdownText.text = ("" + timeLeft);

		if (timeLeft <= 0)
		{
			timeLeft=0;
			StopCoroutine("LoseTime");
			gameObject.SetActive(false);

			BlueButton.GetComponent<Animator>().speed = -1;
			BlueButton.SetActive(false);
			BlueButton.SetActive(true);

			GreenButton.GetComponent<Animator>().speed = -1;
			GreenButton.SetActive(false);
			GreenButton.SetActive(true);

			RedButton.GetComponent<Animator>().speed = -1;
			RedButton.SetActive(false);
			RedButton.SetActive(true);

			NightButton.GetComponent<Animator>().speed = -1;
			NightButton.SetActive(false);
			NightButton.SetActive(true);

			BlueGem.SetActive(false);
			GreenGem.SetActive(false);
			RedGem.SetActive(false);
			NightGem.SetActive(false);

		}
	}

	IEnumerator LoseTime()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			timeLeft--;
		}
	}

}
