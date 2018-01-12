using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class RedBullet : MonoBehaviour {

    public GameObject parent;

	float speed = 75.0f;

    private void Start()
    {
		
    }

   public void Fire() {
        GetComponent<Rigidbody2D>().AddForce(this.transform.right * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Component comp = collision.GetComponent<Component>();
        if (comp && (comp.tag.Contains("Border") || comp.tag == "BlueWarrior"))
        {
            if (comp.tag == "BlueWarrior")
                Destroy(comp.gameObject);
            Destroy(gameObject);
        }
    }
}
