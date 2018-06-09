using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Product : MonoBehaviour {

    public string product_name;
    public float price;
    public string description;

    public Text name_text;
    public Text price_text;
    public Text description_text;
    public bool counterfeit;

    public GameObject player;
	public CanvasGroup price_tag;

    bool active_state;              //if the stall is the active state

    PlayerManager player_manager;

    public GameObject receipt;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player_manager = player.GetComponent<PlayerManager>();
        price_tag = GameObject.Find ("Price Tag").GetComponent<CanvasGroup> ();
        receipt = GameObject.Find("Receipt");
	}

    void SetState(bool newBool)
    {
        active_state = newBool;
    }

    void OnMouseEnter()
    {
        if (active_state)
        {
			price_tag.alpha = 1;
            name_text.text = product_name;
            price_text.text = "£" + price.ToString();
            description_text.text = description;
        }
    }

    void OnMouseOver()
    {
        if (active_state)
        {
            if (Input.GetMouseButtonDown(0))
            {
               
                if (counterfeit == true)
                {
                    player.SendMessage("Economy", 1);
                }

                if (counterfeit == false)
                {
                    player.SendMessage("Economy", -1);
                }

                if (player_manager.money >= price)
                {
                    player.SendMessage("TakeOffMoney", price);
				    price_tag.alpha = 0;
                    name_text.text = null;
                    price_text.text = null;
                    description_text.text = null;
                    gameObject.SetActive(false);
                    receipt.SendMessage("AddToList", product_name);
					//endGameScript.items.Add(name_text);
                }
            }
        }
    }

    void OnMouseExit()
    {
		price_tag.alpha = 0;
        name_text.text = null;
        price_text.text = null;
        description_text.text = null;
    }

       
}
