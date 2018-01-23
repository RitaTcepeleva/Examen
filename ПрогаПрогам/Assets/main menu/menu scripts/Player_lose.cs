using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_lose : MonoBehaviour {
	bool isOutsideScreen = false;

	void OnGUI(){
		if (isOutsideScreen == true) {
			GUI.Box(new Rect(Screen.width/2-100,Screen.height/2-150,200,300),"МЕНЮ");

			if (GUI.Button (new Rect (Screen.width / 2-50, Screen.height / 2-100, 100, 25), "играть")) {
				Application.LoadLevel ("sceneSQUARE");
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 25), "настройки")) {
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2 , 100, 25), "магазин")) {
			}

			if (GUI.Button (new Rect (Screen.width / 2-50, Screen.height / 1-100, 100, 25), "выход")) {
				Application.Quit ();
			}
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		}
	}

