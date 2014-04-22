//C#
using UnityEngine;
using System.Collections;



public class MainMenu : MonoBehaviour {
	//Declaring font
	GUIStyle Font;
	public int labelWidth = 100, labelHeight = 50;

	void OnGUI () 
	{
//Font object
		Font = new GUIStyle ();
		Font.fontSize = 30;



		GUI.BeginGroup (new Rect (Screen.width / 2-600 , Screen.height / 2 - 400, Screen.width, Screen.height));
		// All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.
		
		// We'll make a box so you can see where the group is on-screen.
	

		// Make a background box
		//GUI.Box(new Rect(Screen.width / 2  ,0,Screen.width,800), "Tic Tac Toe " , Font);
		//GUI.Label (new Rect (Screen.width/2, Screen.height/2, 100, 50), "Tic Tac Toe", centeredStyle );



//Pkayer 1 option box
		GUI.Box(new Rect(Screen.width / 8,30,300,350), "Tic Tac Toe Player1");
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
//Player 1 options button box
		if(GUI.Button(new Rect(Screen.width / 8 +10,60,280,40), "New User")) {
			Application.LoadLevel("NewUser");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(Screen.width / 8 +10,110,280,40), "Returning User")) {
			Application.LoadLevel("return");

		}
		if(GUI.Button(new Rect(Screen.width / 8 +10,160,280,40), "Guest")) {
			Application.LoadLevel("Guest");
		}
	

//Player 2 options text box
		GUI.Box(new Rect(Screen.width / 8 +600,30,300,350), "Tic Tac Toe Player2");

//Player 2 options button box		
		if(GUI.Button(new Rect(Screen.width / 8 +610,60,280,40), "New User")) {
			Application.LoadLevel("NewUser");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(Screen.width / 8 +610,110,280,40), "Returning User")) {
			Application.LoadLevel("return");
			
		}
		if(GUI.Button(new Rect(Screen.width / 8 +610,160,280,40), "Guest")) {
			Application.LoadLevel("Guest");
		}
		if(GUI.Button(new Rect(Screen.width / 8 +610,210,280,40), "A.I.")) {
			Application.LoadLevel("Ai");
		}

// History button box
		GUI.Box(new Rect(Screen.width / 8 ,400,300,150), "");
//history button
		if(GUI.Button(new Rect(Screen.width / 8 +10,410,280,120), "History")) {
			Application.LoadLevel("History");
		}
//Start button box
		GUI.Box(new Rect(Screen.width / 8 +600,400,300,150), "");
//Start button
		if(GUI.Button(new Rect(Screen.width / 8 +610,410,280,120), "Start!")) {
			Application.LoadLevel("Start");
		}
		//exit button box
		GUI.Box(new Rect(Screen.width / 8 +600,590,280,120), "");
		//exit button
		if(GUI.Button(new Rect(Screen.width / 8 +610,590,260,100), "Exit")) {
			Application.Quit();;
		}
	//GUI.EndGroup ();
	}

}