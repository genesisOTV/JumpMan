using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {

	public Transform target;

	public float horizMove = 90f;

	public void MoveHorizontal(bool left)
	{
		float direction = 1;
		if(!left)
			direction *= -1;
		transform.RotateAround(target.position, Vector3.up, horizMove * direction);
	}
}
