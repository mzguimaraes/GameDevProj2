using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class worldEngine : MonoBehaviour {

	private string currentRoom = "Lobby";
	private bool hasBribe = false;

	// Update is called once per frame
	void Update () {
		string textBuffer = "You are currently in: " + currentRoom;

		if (currentRoom == "Lobby") {
			textBuffer += "\nYou see the security guard."
						+ "\nA smelly man clutching an anime body pillow approaches you, arm outstreched"
						+ "\n\tlike the protean Adam to his Creator."
						+ "\nThe security guard stares at his phone, unresponsive.";

			textBuffer += "\npress [W] to go to the elevators";
			textBuffer += "\npress [S] to go outside";
			textBuffer += "\npress [F] to grab the weeaboo's hand, against your judgement";

			if (Input.GetKeyDown(KeyCode.W))
				currentRoom = "Elevators";
			else if (Input.GetKeyDown(KeyCode.S))
				currentRoom = "Outside";
			else if (Input.GetKeyDown(KeyCode.F))
				currentRoom = "DEBUG ZONE";
		}
		else if (currentRoom == "Elevators") {
			textBuffer += "\nA hunched-over bellhop leers at you from within the center elevator."
						+ "\npress [W] to enter the cabin"
						+ "\npress [S] to slowly back away";

			if(Input.GetKeyDown(KeyCode.S))
				currentRoom = "Lobby";
			else if (Input.GetKeyDown(KeyCode.W))
				currentRoom = "Elevator Cabin";
		}
		else if (currentRoom == "Outside") {
			textBuffer += "\nYou exit the hotel onto the street, sun beating down above you."
						+ "\nSuddenly you see them--weeaboos.  Everywhere."
						+ "\nYour soul cannot bear to leave."
						+ "\npress [Q] to flee.";

			if (Input.GetKeyDown(KeyCode.Q))
				currentRoom = "Lobby";
		}
		else if (currentRoom == "Elevator Cabin") {
			//cabin code
		}
		else {
			textBuffer += "\nThis place exists within that liminal zone between worlds."
						+ "\nThough you hear no words, you get the sense that you do not belong here."
						+ "\nYou have seen through the seams of reality, and your soul will bear the scars."
						+ "\nYou see a dim light some distance away.  You reach for it..."
						+ "\npress [R] to return to the lobby.";
			if (Input.GetKeyDown(KeyCode.R))
				currentRoom = "Lobby";
		}

		GetComponent<Text>().text = textBuffer;
	}
}
