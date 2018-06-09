using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_Manager : MonoBehaviour {

    enum States
    {
        MOVEMENT,
        STALL,
        END
    };

    States game_state;

    GameObject player;
    GameObject[] products;

    public GameObject outcamera;
    public GameObject incamera;

    public GameObject stall_canvas;
    public GameObject end_canvas;

	// Use this for initialization
	void Start ()
    {
        game_state = States.MOVEMENT;

        player = GameObject.FindGameObjectWithTag("Player");
        products = GameObject.FindGameObjectsWithTag("Product");
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit ();
		}

        if ((int)Time.time > 180)
        {
            StartEnd();
        }

            switch (game_state)
        {
            case States.MOVEMENT:
                player.SendMessage("StateUpdate");
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i].activeInHierarchy)
                    {
                        products[i].SendMessage("SetState", false);
                    }
                }
                outcamera.SetActive(true);
                incamera.SetActive(false);

                stall_canvas.SetActive(false);

                break;
            case States.STALL:
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i].activeInHierarchy)
                    {
                        products[i].SendMessage("SetState", true);
                    }
                }
                outcamera.SetActive(false);
                incamera.SetActive(true);

                stall_canvas.SetActive(true);

                break;
            case States.END:
                player.SendMessage("endGame");
                break;
        }
    }

    void StartMovement()
    {
        game_state = States.MOVEMENT;
    }

    void StartStall(GameObject new_camera)
    {
        game_state = States.STALL;
        incamera = new_camera;
    }

    void StartEnd()
    {
        game_state = States.END;

    }
}
