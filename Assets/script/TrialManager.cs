using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrialManager : MonoBehaviour {

	private int randomInt;

	public Text randomText;
	public GameObject startButton;

	// Use this for initialization
	void Start () {
	
		//kokokokookokokokokokokok
		//debug debug debug debug debug debug
	}


	public void ButtonClick(int buttonNum)
	{
		if (buttonNum == 0) {
			startButton.SetActive (false);
			randomInt = Random.Range (0, 20);
			randomText.text = randomInt.ToString ();
			StartCoroutine (ResetAll ());
		}
	}

	IEnumerator ResetAll()
	{
		yield return new WaitForSeconds (5);
		randomText.text = "";
		startButton.SetActive (true);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
