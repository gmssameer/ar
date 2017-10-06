using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;
public class statemanager : MonoBehaviour {

	void Awake(){
		MixedRealityController.Instance.SetMode (MixedRealityController.Mode.HANDHELD_AR);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}	}
}
