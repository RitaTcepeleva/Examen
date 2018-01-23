using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript1 : MonoBehaviour {

	public int hp1 = 1;

	public bool isEnemy = true;

	public void Damage (int damageCount){
		hp1 --;

		if (hp1 <= 0) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D otherCollider){
		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
		if (shot != null) {
			if (shot.isEnemyShot != isEnemy) {
				Damage (shot.damage);
				Destroy (shot.gameObject);
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
