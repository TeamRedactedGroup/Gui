//C#
using UnityEngine;
using System.Collections;



public class MainMenu : MonoBehaviour {

	//Radio button variables
	public bool Player1First = false;
	public bool Player2First = false;
	public bool Random = false;

	void OnGUI () 
	{
//Font object
				//Font = new GUIStyle ();
				//Font.fontSize = 30;



				//GUI.BeginGroup (new Rect ((Screen.width / 2)-(Screen.width *0.45f) , (Screen.height / 2) - (Screen.height *0.45f), Screen.width, Screen.height));
				// All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.
		
				// We'll make a box so you can see where the group is on-screen.
	

				// Make a background box
				//GUI.Box(new Rect(Screen.width / 2  ,0,Screen.width,800), "Tic Tac Toe " , Font);
				//GUI.Label (new Rect (Screen.width/2, Screen.height/2, 100, 50), "Tic Tac Toe", centeredStyle );



//Pkayer 1 option box
				GUI.Box (new Rect (Screen.width / 10, Screen.height / 35, Screen.width / 4, Screen.height / 3), "Tic Tac Toe Player1");
				//GUI.Box(new Rect(Screen.width / 8,30,Screen.width /4,350), "Tic Tac Toe Player1");
				// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
//Player 1 options button box
				if (GUI.Button (new Rect (Screen.width / 9, Screen.height / 13, Screen.width / 4.5f, Screen.height / 19), "New User")) {
						Application.LoadLevel (1);
				}
		
				// Make the second button.
				if (GUI.Button (new Rect (Screen.width / 9, Screen.height / 13 + Screen.height / 19, Screen.width / 4.5f, Screen.height / 19), "Returning User")) {
						Application.LoadLevel (2);

				}
				if (GUI.Button (new Rect (Screen.width / 9, Screen.height / 13 + Screen.height / 19 + Screen.height / 19, Screen.width / 4.5f, Screen.height / 19), "Guest")) {
						Application.LoadLevel ("Guest");
				}
//Ready flag
				if (PlayerPrefs.HasKey ("player1")) {
			GUI.Box (new Rect (Screen.width / 9, Screen.height / 13 + Screen.height / 19 + Screen.height / 19+ Screen.height/19, Screen.width / 4.5f, Screen.height / 25), "Ready");
				}
		
				//Player 2 options text box
				GUI.Box (new Rect (Screen.width - (Screen.width / 5) - (Screen.width / 6), Screen.height / 35, Screen.width / 4, Screen.height / 3), "Tic Tac Toe Player2");

//Player 2 options button box		
				if (GUI.Button (new Rect (Screen.width - (Screen.width / 5) - (Screen.width / 6.4f), Screen.height / 13, Screen.width / 4.5f, Screen.height / 19), "New User")) {
						Application.LoadLevel (1);
				}
		
				// Make the second button.
				if (GUI.Button (new Rect (Screen.width - (Screen.width / 5) - (Screen.width / 6.4f), Screen.height / 13 + Screen.height / 19, Screen.width / 4.5f, Screen.height / 19), "Returning User")) {
						Application.LoadLevel (2);
			
				}
				if (GUI.Button (new Rect (Screen.width - (Screen.width / 5) - (Screen.width / 6.4f), Screen.height / 13 + Screen.height / 19 + Screen.height / 19, Screen.width / 4.5f, Screen.height / 19), "Guest")) {
						Application.LoadLevel (0);
				}
				if (GUI.Button (new Rect (Screen.width - (Screen.width / 5) - (Screen.width / 6.4f), Screen.height / 13 + Screen.height / 19 + Screen.height / 19 + Screen.height / 19, Screen.width / 4.5f, Screen.height / 19), "A.I.")) {
						Application.LoadLevel ("Ai");
				}
//Ready flag 2
				if (PlayerPrefs.HasKey ("player2")) 
				{
				//	GUI.Box (new Rect (Screen.width - (Screen.width / 5) - (Screen.width / 6.4f)), (Screen.height / 13 + (Screen.height / 19f )), Screen.width / 4.5f, Screen.height / 25, "Ready");
			GUI.Box (new Rect (Screen.width - (Screen.width / 5) - (Screen.width / 6.4f), Screen.height / 13 + Screen.height / 19 + Screen.height / 19+ Screen.height/19+Screen.height / 19, Screen.width / 4.5f, Screen.height / 25), "Ready");
				}
		
				// History button box
				GUI.Box (new Rect (Screen.width / 10, Screen.height / 2.5f, Screen.width / 4, Screen.height / 5), "");
//history button
				if (GUI.Button (new Rect (Screen.width / 9, Screen.height / 2.4f, Screen.width / 4.5f, Screen.height / 6), "History")) {
						Application.LoadLevel (4);
				}
//Start button box
				GUI.Box (new Rect (Screen.width - (Screen.width / 5) - (Screen.width / 6.2f), Screen.height / 2.5f, Screen.width / 4.1f, Screen.height / 5), "");
//Start button
				if (GUI.Button (new Rect (Screen.width - (Screen.width / 5) - (Screen.width / 6.2f), Screen.height / 2.4f, Screen.width / 4.1f, Screen.height / 13), "Start!")) {
						Application.LoadLevel (3);
				}
//exit button
				if (GUI.Button (new Rect (Screen.width - (Screen.width / 5) - (Screen.width / 6.2f), Screen.height / 2.0f, Screen.width / 4.1f, Screen.height / 12), "Exit")) {
						Application.Quit ();
						;
				}
//Radio Buttons for which player goes first
		GUI.Box (new Rect (Screen.width / 9 +Screen.width / 4.1f, Screen.height / 2.5f, Screen.width / 3.6f, Screen.height / 5), "Who goes first?");
		Player1First = GUI.Toggle (new Rect(Screen.width / 9 +Screen.width / 4.1f, Screen.height / 2.3f, Screen.width / 4.5f, 20), Player1First, "Player 1");
		Player2First = GUI.Toggle (new Rect (Screen.width / 9 +Screen.width / 4.1f, Screen.height / 2.3f+Screen.height / 20, Screen.width / 4.5f, 20), Player2First, "Player 2");
		Random = GUI.Toggle (new Rect (Screen.width / 9 +Screen.width / 4.1f,Screen.height / 2.3f+Screen.height / 20+Screen.height / 20 , Screen.width / 4.5f, 20), Random, "Random");
				if (Player1First == false || Player2First == false || Random == false) {
						if (Player1First == true) {
								Player2First = false;
								Random = false;
								//Insert code for Player 1 goes first
						}
			
						if (Player2First == true) {
								Player1First = false;
								Random = false;
								//Insert code for Player 2 goes first
						}
			
						//GUI.EndGroup ();
				}
		}	
	}