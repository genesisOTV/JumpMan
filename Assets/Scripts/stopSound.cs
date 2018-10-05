using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopSound : MonoBehaviour {

    [SerializeField]
    AudioSource music;

    // Use this for initialization
	void Start () {
        music.Stop();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
