using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

    public int money;
    public string eco_con;

    public Text ecoText;
    public Text balanceText;

    public int bad_eco = 0;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        balanceText.text = money.ToString("f2");
    }

    void TakeOffMoney(int amount)
    {
            money -= amount; 
    }

    void Economy(int b)
    {
        bad_eco += b;

        switch(bad_eco)
        {
            case 3:
                eco_con = "Bad";
                ecoText.text = "Economy Status: \n " + eco_con;
                break;
            case 6:
                eco_con = "Awful";
                ecoText.text = "Economy Status: \n " + eco_con;
                break;
            case 0:
                eco_con = "Normal";
                ecoText.text = "Economy Status: \n " + eco_con;
                break;
            case -3: 
                eco_con = "Good";
                ecoText.text = "Economy Status: \n " + eco_con;
                break;
            case -6:
                eco_con = "Excellent";
                ecoText.text = "Economy Status: \n " + eco_con;
                break;
       }
    }
}
