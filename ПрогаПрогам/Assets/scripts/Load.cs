using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Load : MonoBehaviour {

	public static float money2 = Game.money;

	// Use this for initialization
	void Start () {
		StreamReader streamReader = new StreamReader ("C:\\Users\\1\\Documents\\Ригелина\\Ригелина\\ПрогаПрогам\\Save\\Save.sg");
		if (streamReader != null) {
			while (!streamReader.EndOfStream) {
				money2 = System.Convert.ToSingle (streamReader.ReadLine ());
			}
			if (money2 != 0)
				Game.money = money2;
		}
	}
}
