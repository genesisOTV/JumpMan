using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPole : MonoBehaviour {

    public Animator animator;

    public Material matRed;
    public Material matGreen;

    public GameObject endGameUI;

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material = matRed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("cpRegion"))
        {
            GetComponent<Renderer>().material = matGreen;

            Time.timeScale = 0f;

            endGameUI.SetActive(true);

            //Time.timeScale = 0f;
            animator.SetBool("isEndGame", true);

        }
    }
}
