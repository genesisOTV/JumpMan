using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSlideSound : MonoBehaviour {

    public AudioSource slideSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            slideSound.Play();
        }
	}
}
