using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField]
    Transform player;
    [SerializeField]
    Vector3 offset;

    // Use this for initialization
    void Start()
    {
        //GameObject player = GameObject.Find("Character");
        //Transform CameraTransform = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}
