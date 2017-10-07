using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;
public class TRANSITION : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
	public void ColoringBook()
	{
		SceneManager.LoadScene ("main");


	}
	public void Game(){
		SceneManager.LoadScene ("game");
	}
	public void NewsPaper()
	{
		SceneManager.LoadScene ("newspaper");
	
	}
}
