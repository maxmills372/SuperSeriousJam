using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	//Image to follow mouse movement
	public GameObject image;
	public float speed;
    public GameObject player;

	Vector3 pos;

	Vector2 unitV;

	public float distance;
	Vector3 temp;
	float xDiff,zDiff;
	bool move;
	bool test;


	Vector3 desiredPos;

	// Use this for initialization
	void Start () 
	{
        player = GameObject.FindGameObjectWithTag("Player");
		move = false;
		test = false;
	}

	// Update is called once per frame
	void StateUpdate ()
	{
		//Set Vector3 to player x position
		pos.x = transform.position.x;

		//cast ray from the camera to the mouse position
		Ray r = Camera.main.ScreenPointToRay (Input.mousePosition);

		//Create raycast hit
		RaycastHit hit;


		//Fill raycast hit info with our ray
		//if ray collides with something solid, the 'hit' structure will be filled with
		//collision info
		if (Physics.Raycast (r, out hit)) 
		{
			if (hit.collider.tag == "Ground") {
				//Debug.Log(hit.point.z);
				//Move player to position on click

					
				//set image position to where mouse collided with object
				image.transform.position = hit.point;


			}
		}

		//2 vectors x and z 
		//get dist 
		//get unit vector (z-x)/dist
		//translate by that


		xDiff = desiredPos.x - player.transform.position.x;
		zDiff =  desiredPos.z - player.transform.position.z;

		//calculate distance formula
		distance = Mathf.Sqrt (Mathf.Pow (xDiff, 2) + Mathf.Pow (zDiff, 2));

		unitV = new Vector2 (xDiff, zDiff) / distance;

		//pos.x = hit.point.x;
		//pos.z = hit.point.z;
		//pos.y = transform.position.y;
		//player.transform.position = pos;


		//Debug.Log(distance);



		if (distance < 0.5f) {
			unitV = Vector3.zero;
			move = false;
		}

		if (Input.GetMouseButtonDown (0)) {
			
			move = true;


			desiredPos = hit.point;
		}


		if (move) {


			player.transform.Translate (new Vector3 (unitV.x, 0, unitV.y) * speed);

		

		}
	}
}
