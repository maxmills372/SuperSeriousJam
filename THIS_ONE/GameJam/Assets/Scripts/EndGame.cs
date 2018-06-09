using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

    public Text endText;
    public GameObject image;




    void endGame()
    {
        endText.text = "End of the Day! \n Thanks for Playing";
        image.SetActive(true);

	



    }
}
