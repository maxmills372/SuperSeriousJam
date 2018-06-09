using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StallClick : MonoBehaviour {

    public GameObject manager;
    public GameObject this_camera;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            manager.SendMessage("StartStall", this_camera);
        }
    }
}
