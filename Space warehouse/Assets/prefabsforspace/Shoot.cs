﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bullet;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 dannyp = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Instantiate(bullet, dannyp, Quaternion.identity);
        }
	}
}
