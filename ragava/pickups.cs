using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickups : MonoBehaviour {
    public GameObject pickup;
    int count;
	// Use this for initialization
	void Start () {
        pickup.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "pickup")
        {
            pickup.SetActive(false);
            count++;
        }
    }
}
