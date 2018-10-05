using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSlide : MonoBehaviour {

    [SerializeField]
    float slideSpeed = 10f;
    [SerializeField]
    float mySeconds = 5;

    Rigidbody controller;
    Vector3 movement;

    bool isAPressed, isDPressed, isWPressed, isSPressed;

	// Use this for initialization
	void Start () {
        controller = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {

        movement = new Vector3(Input.GetAxis("VerticalKey"), 0f, Input.GetAxis("HorizontalKey"));
        if (Input.GetKeyDown(KeyCode.LeftShift) && isGrounded())
        {
            controller.AddForce(movement * slideSpeed, ForceMode.Impulse);
            resize();
            StartCoroutine("waitForSlideAnimation");
        }
        //if (!Input.GetKeyDown(KeyCode.LeftShift)) {
            //resetSize();
        //}
    }

    bool isGrounded() {
        return Physics.Raycast(transform.position, -Vector3.up, GetComponent<Collider>().bounds.extents.y + 0.1f);
    }

    void resize() {
        controller.transform.localScale = new Vector3(1, 0.5f, 1);
    }

    void resetSize() {
        controller.transform.localScale = new Vector3(1, 1, 1);
    }

    IEnumerator waitForSlideAnimation() {
        yield return new WaitForSeconds(mySeconds);
        resetSize();
    }

}
