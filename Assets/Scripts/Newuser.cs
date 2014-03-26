//C#
using UnityEngine;
using System.Collections;

public class Newuser : MonoBehaviour {
	public string stringToEdit;
	
	void OnGUI () {
		//Create centered box
		GUI.BeginGroup (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 500, 500));
		// Make a background box
		GUI.Box(new Rect(10,10,350,350), "New User Input");
		// Make standard text saying enter name
		GUI.Label ( new Rect (50, 90, 280, 20), "  Please Enter Your Name  :");
		//Create text inputbox.
		stringToEdit = GUI.TextField(new Rect(20,150,280,30), stringToEdit,25);
		//create Enter button to input text

		if(GUI.Button(new Rect(20,200,280,20), "Enter")) {
			Application.LoadLevel("MainMenu");
		}

		// 
		if(GUI.Button(new Rect(20,250,280,20), "Main Menu")) {
			Application.LoadLevel("MainMenu");
		}
		
		GUI.EndGroup ();

	}
}