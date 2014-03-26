//C#
using UnityEngine;
using System.Collections;

public class About : MonoBehaviour {
	public string stringToEdit;
	
	void OnGUI () {

		GUI.BeginGroup (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 500, 500));
		// Make a background box
		GUI.Box(new Rect(10,10,250,300), "About Team Redacted!");
		// Make standard text saying enter name
		GUI.Label ( new Rect (50, 100, 230, 20), "Robert  -Team Lead");
		GUI.Label ( new Rect (50, 130, 230, 20), "Sean    -SQA");
		GUI.Label ( new Rect (50, 170, 230, 20), "Tuan    -Slave");
		GUI.Label ( new Rect (50, 200, 230, 20),"Patrick -Secretary ");
		GUI.Label ( new Rect (50, 230, 230, 20), "Xuan   -Peasant");
		// 
		if(GUI.Button(new Rect(20,280,230,20), "Main Menu")) {
			Application.LoadLevel("MainMenu");
		}
		
		
		GUI.EndGroup ();
	}
}