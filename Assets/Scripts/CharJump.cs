using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharJump : MonoBehaviour {
    
    [Range(1, 20)]
    [SerializeField]
    float jumpSpeed = 10f;
    Rigidbody controller;
    bool jumpRequest;

	// Use this for initialization
	void Start () {
        controller = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && isGrounded())
        {
            jumpRequest = true;
        }
    }
    void FixedUpdate()
    {   
        if(jumpRequest)
        {
            controller.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            jumpRequest = false;
        }
    }

    bool isGrounded()
	{
		return Physics.Raycast(transform.position, -Vector3.up, GetComponent<Collider>().bounds.extents.y + 0.1f);
	}
}
