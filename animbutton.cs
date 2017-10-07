using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animbutton : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	public void StartAnimation(){
		anim.SetTrigger ("start");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
