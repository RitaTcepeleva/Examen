﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Save : MonoBehaviour {

	public string filename;

	// Use this for initialization
	void Start () {
		if (filename == "") filename = "C:\\Users\\1\\Documents\\Ригелина\\Ригелина\\ПрогаПрогам\\Save\\Save.sg";
	}

	void OnGUI () {
		if (GUI.Button (new Rect (55, 12, 60, 20), "Write")) {
			StreamWriter sw = new StreamWriter (filename);
			sw.WriteLine (Game.money);
			Debug.Log ("Save");
			sw.Close();

		}
	}
} 
