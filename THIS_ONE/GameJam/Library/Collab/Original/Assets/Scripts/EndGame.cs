using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

    public Text endText;
    public GameObject image;
	public Text listText;


	public List<Text> itemsText;
	List<string> itemsName;

    void endGame()
    {
        endText.text = "End of the Day! \n Thanks for Playing";
        image.SetActive(true);

		listText.text = itemsName;




    }
}
