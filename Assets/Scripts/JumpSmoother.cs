using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSmoother : MonoBehaviour {

	[Range(1, 20)]
	[SerializeField]
	float fallMultiplier = 2.5f;
	[Range(1, 20)]
	[SerializeField]
	float lowJumpMultiplier = 2f;

	//CharacterController controller;
	Rigidbody controller;

	// Use this for initialization
	void Start () {
		//controller = GetComponent<CharacterController>();
		controller = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(controller.velocity.y < 0)
		{
			//controller.Move(Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime);
			controller.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
		}
		else if(controller.velocity.y > 0 && !Input.GetButton("Jump"))
		{
			//controller.Move(Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime);
			controller.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;

		}
	}
}
