using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour 
{	
	[Range(1, 20)]
	[SerializeField]
	float moveSpeed; //movement speed variable
	[Range(1, 2)]
	[SerializeField]
	float dragDividend;
    [Range(1, 2)]
    [SerializeField]
    float sensitivty; 

	Vector3 movement; //Vectors store direction

	Rigidbody controller;

    public CameraRegion region;

    bool rotateActive;

	// Use this for initialization
	void Start () 
	{
		controller = GetComponent<Rigidbody>();
        region = GetComponent<CameraRegion>();

		Cursor.lockState = CursorLockMode.Locked;

        rotateActive = true;
	}

	void Update()
	{
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            rotateActive = !rotateActive;
        }
        if (rotateActive == true)
        {
            float horizontalRotate = Input.GetAxis("Mouse X") * sensitivty;
            transform.Rotate(0, horizontalRotate, 0);
        }
        else if(rotateActive == false)
        {
            transform.Rotate(0, 0, 0);
        }
	}

	void FixedUpdate()
    {
        //movement = new Vector3(Input.GetAxis("VerticalKey"), 0f, Input.GetAxis("HorizontalKey"));
        movement = (transform.forward * Input.GetAxis("HorizontalKey")) + (transform.right * Input.GetAxis("VerticalKey"));
        StartCoroutine(move());
    }

	bool isGrounded()
	{
		return Physics.Raycast(transform.position, -Vector3.up, GetComponent<Collider>().bounds.extents.y + 0.1f);
	}

	IEnumerator move()
	{
		if(!isGrounded())
		{
            controller.MovePosition(transform.position + (movement.normalized*moveSpeed*Time.deltaTime/dragDividend));
			yield return null;
		}
		else if(isGrounded())
		{
            controller.MovePosition(transform.position + movement.normalized*moveSpeed*Time.deltaTime);
			yield return null;
		}
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Region"))
        {
            region = other.GetComponent<CameraRegion>();
            region.ChangeRegion();
        }
    }
}
