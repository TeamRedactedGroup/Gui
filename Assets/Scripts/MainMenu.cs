//C#
using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	void OnGUI () 
	{

		GUI.BeginGroup (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 500, 500));
		// All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.
		
		// We'll make a box so you can see where the group is on-screen.
	

		// Make a background box
		GUI.Box(new Rect(10,10,300,340), "Tic Tac Toe Menu");

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,280,40), "New User")) {
			Application.LoadLevel("NewUser");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(20,90,280,40), "Returning User")) {
			Application.LoadLevel("About");

		}
		if(GUI.Button(new Rect(20,140,280,40), "Guest")) {
			Application.LoadLevel(3);
		}
		if(GUI.Button(new Rect(20,190,280,40), "Scores")) {
			Application.LoadLevel(4);
		}
		if(GUI.Button(new Rect(20,240,280,40), "Options")) {
			Application.LoadLevel("Options");
		}
		if(GUI.Button(new Rect(20,290,280,40), "About")) {
			Application.LoadLevel("About");
		}
	GUI.EndGroup ();
	}

}