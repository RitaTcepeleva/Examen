using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour {

	void OnGUI (){
		if (GUI.Button (new Rect (Screen.width / 2-50, Screen.height / 2-100, 100, 25), "exit")) {
			Application.LoadLevel ("menu");
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
