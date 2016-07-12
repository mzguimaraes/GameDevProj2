using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class worldEngine : MonoBehaviour {

	private string currentRoom = "Lobby";
	private bool isWeeb = false;
	private bool weebFlipped = false; 
	private bool hasMoney = false;

	// Update is called once per frame
	void Update () {
		string textBuffer = "You are currently in: " + currentRoom;

		if (currentRoom == "Lobby") {
			if (!isWeeb) {
				textBuffer += "\nYou see the security guard."
							+ "\nA smelly man clutching an anime body pillow approaches you, arm outstreched"
							+ "\n\tlike the protean Adam to his Creator."
							+ "\nThe security guard stares at his phone, unresponsive.";

				textBuffer += "\npress [W] to go to the elevators";
				textBuffer += "\npress [S] to go outside";
				//textBuffer += "\npress [F] to grab the weeaboo's hand, against your judgement";

				if (hasMoney) {
					textBuffer += "\npress [F] to feed the weeaboo your dollar bill.";
				}
			}
			else {
				textBuffer += "\nYou've returned to the lobby, but it's not as you left it."
							+ "\nYou notice a malodorous scent emanating from neath your arms."
							+ "\nIn your right hand is a body pillow, though you don't remember getting it."
							+ "\nYou look to where the smelly man was, but he's gone."
							+ "\nIn his place: someone who looks just like you.  Could it be...?"
							+ "\n\npress [W] to go to the elevators"
							+ "\npress [S] to go outside"
							+ "\npress [F] to grab your own hand";
			}
			if (Input.GetKeyDown(KeyCode.W))
				currentRoom = "Elevators";
			else if (Input.GetKeyDown(KeyCode.S))
				currentRoom = "Outside";
			else if (Input.GetKeyDown(KeyCode.F) && hasMoney)
				currentRoom = "WEEB ZONE";
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
			hasMoney = true;
			textBuffer += "\nYou exit the hotel onto the street, sun beating down above you."
						+ "\nSuddenly you see them--weeaboos.  Everywhere."
						+ "\nYour soul cannot bear to leave."
						+ "\n\nOn the plus side, you found a $1 bill on the ground.  Sweet!"
						+ "\npress [Q] to flee.";

			if (Input.GetKeyDown(KeyCode.Q))
				currentRoom = "Lobby";
		}

		else if (currentRoom == "Elevator Cabin") {
			textBuffer += "\nThe bellhop is incredibly tall.  He gazes over you, his head cast in silhouette."
						+ "\nHe speaks, and the room temperature seems to drop.";
			if (isWeeb) {
				textBuffer += "\n\nAs he begins, however, he starts making the same sound over and over, "
							+ "\n\tseveral times a second.  He seems...broken."
							+ "\nAs if to confirm your suspicion, a shaggy dog appears on his face where his lips were."
							+ "\nIt barks at you."
							+ "\nThe elevator doors shut, and the car begins to ascend."
							+ "\n\npress [C] to continue...";
				if (Input.GetKeyDown(KeyCode.C))
					currentRoom = "Top Floor";
			}
			else {
				textBuffer += "\n\"I'm sorry, but I don't recognize you.  I shan't be taking you anywhere.\""
							+ "\nThe vacant gaze in his eyes tells you he's serious.  You decide to leave."
							+ "\npress [R] to return to the elevator room.";
				if (Input.GetKeyDown(KeyCode.R))
					currentRoom = "Elevators";
			}
		}

		else if (currentRoom == "Top Floor") {
			textBuffer += "\nYou stumble out of the elevator when it reaches its destination."
						+ "\nYou fall to the ground, but the body pillow breaks your fall."
						+ "\nWhat a long, strange trip it's been."
						+ "\nYou shut your eyes."
						+ "\n\nYou have died of dysentery."
						+ "\nYou win!";
		}

		else if (currentRoom == "WEEB ZONE") { 
			if (!weebFlipped){ //prevents isWeeb from flipping every frame
				isWeeb = !isWeeb;
				weebFlipped = true;
			}
			textBuffer += "\nThis place exists within that liminal zone between worlds."
						+ "\nThough you hear no words, you get the sense that you do not belong here."
						+ "\nYou have seen through the seams of reality, and your soul will bear the scars."
						+ "\nYou see a dim light some distance away.  You reach for it..."
						+ "\npress [R] to return to the lobby.";
			if (Input.GetKeyDown(KeyCode.R)) {
				weebFlipped = false;
				currentRoom = "Lobby";
			}
		}

		GetComponent<Text>().text = textBuffer;
	}
}
