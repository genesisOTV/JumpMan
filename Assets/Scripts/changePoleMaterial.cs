using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePoleMaterial : MonoBehaviour {

    public Material matRed;
    public Material matGreen;

    public bool changedSP;
    public float crX, crY, crZ;

	void Start () {
        changedSP = false;

        GetComponent<Renderer>().material = matRed;
	}

    void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("cpRegion"))
        {
            GetComponent<Renderer>().material = matGreen;

            changedSP = true;
        }
    }
}
