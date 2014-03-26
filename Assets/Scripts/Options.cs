using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour {

	// Use this for initialization
	void OnGUI () {
		GUI.BeginGroup (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 500, 500));
		
		// We'll make a box so you can see where the group is on-screen.
		GUI.Box (new Rect (0,0,310,320), "Options");
	

		//GUI.Button (new Rect (10,40,80,30), "Click me");
		
		// End the group we started above. This is very important to remember!
		if(GUI.Button(new Rect(20,280,230,20), "Main Menu")) {
			Application.LoadLevel("MainMenu");
		}
		GUI.EndGroup ();
	}
	
}