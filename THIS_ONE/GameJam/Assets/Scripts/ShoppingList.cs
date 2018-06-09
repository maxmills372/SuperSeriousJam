using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingList : MonoBehaviour 
{
	// Variables 
	public string[] food;
	public string[] drink;
	public string[] clothing;
	public string[] misc;

	public Text item1_text;
	public Text item2_text;
	public Text item3_text;
	public Text item4_text;

	private string item1;
	private string item2;
	private string item3;
	private string item4;

	private int foodRando;
	private int drinkRando;
	private int clothingRando;
	private int miscRando;

	// Use this for initialization
	void Start () 
	{
		// Randomise numbers
		foodRando = Random.Range(0,3);
		drinkRando = Random.Range (0, 4);
		clothingRando = Random.Range (0, 5);
		miscRando = Random.Range (0, 4);

		item1 = food [foodRando];
		item2 = drink [drinkRando];
		item3 = clothing [clothingRando];
		item4 = misc [miscRando];

		item1_text.text = item1;
		item2_text.text  = item2;
		item3_text.text  = item3;
		item4_text.text  = item4;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
