using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    GameObject player;
    Vector3 difference;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        difference = this.transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.position = player.transform.position + difference;
	}
}
