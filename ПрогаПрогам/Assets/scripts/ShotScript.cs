﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{

    public int damage = 1;

    public bool isEnemyShot = false;

    // Use this for initialization
    void Start()
    {
        //Destroy(gameObject, 20);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Component comp = collision.GetComponent<Component>();
        if (comp && comp.tag.Contains("Border"))
            Destroy(gameObject);
    }
}
