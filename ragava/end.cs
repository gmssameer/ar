﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour {
    public GameObject sphere;
	// Use this for initialization
	void Start () {
        sphere.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        sphere.SetActive(false);
    }
}
