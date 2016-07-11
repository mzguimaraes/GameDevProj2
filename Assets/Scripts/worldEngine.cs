using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class worldEngine : MonoBehaviour {

	private enum rooms {
		Lobby, 
		Elevators, 
		Outside
	}
	private string currentRoom = rooms.Lobby;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "You are currently in: " + currentRoom;

		if (currentRoom == "Lobby") {
			textBuffer += "\nYou see the security guard.";

			textBuffer += "\npress [W] to go to elevators";
			textBuffer += "\npress [S] to go outside";

			if (Input.GetKeyDown(KeyCode.W))
				currentRoom = rooms.Elevators;
			else if (Input.GetKeyDown(KeyCode.S))
				currentRoom = rooms.Outside;
		}
		else if (currentRoom == "Elevators") {
			//elevators code
		}
		else if (currentRoom == "Outside") {
			//outside code
		}

		GetComponent<Text>().text = textBuffer;
	}
}
