using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {
    public GameObject starting;
    public GameObject plane;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y<plane.transform.position.y-10)
        {
            transform.position = starting.transform.position;
        }
	}
}
