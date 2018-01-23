using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Buttons : MonoBehaviour {
	public GameObject healther;
	public GameObject speeder;
	public string filename2;
	public float money3;
	// Use this for initialization
	void Start () {
		if (filename2 == "") filename2 = "C:\\Users\\1\\Documents\\Ригелина\\Ригелина\\ПрогаПрогам\\Save\\Save.sg";
		StreamReader streamReader = new StreamReader (filename2);
		if (streamReader != null) {
			while (!streamReader.EndOfStream) {
				money3 = System.Convert.ToSingle (streamReader.ReadLine ());
			}
			if (money3 != 0)
				Game.money = money3;
		}

	}

	// Update is called once per frame
	void Update () {
	}
	void OnGUI () {
		if (GUI.Button(new Rect(500, 100, 60, 20), "купить"))
		{
			if (money3 >= 1000)
			{
				Game.money = (money3 - 1000);
				StreamWriter sw = new StreamWriter(filename2);
				sw.WriteLine(Game.money);
				Debug.Log("Save-1000");
				sw.Close();
				healther.GetComponent<HealthScript1>().hp1 += 1;
			}
		}
		if (GUI.Button(new Rect(500, 250, 60, 20), "купить")) {
			if (money3>=3000) {
				Game.money = (money3 - 3000);
				StreamWriter sw = new StreamWriter(filename2);
				sw.WriteLine(Game.money);
				Debug.Log("Save-3000");
				sw.Close();
				speeder.GetComponent<MoveScript>().speed = new Vector2(10, 10);
			}
		}
	}
}