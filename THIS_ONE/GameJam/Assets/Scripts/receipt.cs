using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class receipt : MonoBehaviour {

    public List<string> bought_items;
    public Text receipt_text;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void AddToList(string new_item)
    {
        bought_items.Add(new_item);
    }

    void PrintList()
    {
        
    }
}
