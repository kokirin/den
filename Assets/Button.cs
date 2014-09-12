using UnityEngine;
using System.Collections;

public class Button : TouchScript {
	public GameObject text;
	public GameObject cam;
	public int test;
	// Use this for initialization
	void Start () {

		test = 1;

		//cam = GameObject.Find (MainCamera);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnButton( int a, int b ){

	}
}
