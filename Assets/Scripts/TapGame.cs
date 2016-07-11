using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class TapGame : MonoBehaviour {

	public Text textObject;

	private int tapCount = 0;
	private bool hasWon = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.Space) && !hasWon) {
			tapCount++;
			textObject.text = "CURRENT SCORE: " + tapCount.ToString();
		}
		if (Input.GetKeyDown(KeyCode.C) && !hasWon) {
			tapCount+= 100;
			textObject.text = "CURRENT SCORE: " + tapCount.ToString();
		}
		if (tapCount > 101) {
			hasWon = true;
			textObject.text = "YOU WIN!!!!";
		}

	}
}
