using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationInputManager : MonoBehaviour {

	CameraRotate cam;

	// Use this for initialization
	void Start () {
		cam = GetComponent<CameraRotate>();
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Input.GetKeyDown(KeyCode.Q))
		{
			cam.MoveHorizontal(true);
		}
		else if(Input.GetKeyDown(KeyCode.E))
		{
			cam.MoveHorizontal(false);
		}*/
	}
}
