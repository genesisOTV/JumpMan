using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRegion : MonoBehaviour {

    public Transform cam;
    private Vector3 offset;

	 // Use this for initialization
	void Start () {
		offset = new Vector3(-8, 10, -8);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeRegion()
	{
		cam.position = transform.root.position + offset;
	}
}
