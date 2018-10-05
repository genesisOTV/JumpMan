using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharRespawn : MonoBehaviour {

    [SerializeField] Transform player;
    [SerializeField] Transform respawnPoint;
    bool respawnReady;

	// Use this for initialization
	void Start () {
        respawnReady = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(player.transform.position.y <= -16.57){
            respawnReady = true;
        }

        if (respawnReady == true)
        {
            respawnPlayer();
            respawnReady = false;
        }
	}

    public void respawnPlayer()
    {
        if (GameObject.Find("Checkpoint Pole").GetComponent<changePoleMaterial>().changedSP == true)
        {
            player.transform.position = respawnPoint.transform.position;
        }
        else
        {
            player.transform.position = new Vector3(0, 13, 0);
        }
        
    }


}
