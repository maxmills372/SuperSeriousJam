using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timerText;
    private float startTime;
    private float h;
    private float m;
    private string hours;
    private string mins;
    
	public bool endofDay;
  
    public GameObject sun;

	// Use this for initialization
	void Start () 
	{
        startTime = Time.time+0.5f;
        endofDay = false;
        
    }
	
	// Update is called once per frame
	void Update () 
	{
        h = Time.time + 720.0f;
        m = Time.time - startTime;

       hours = ((int) h / 60).ToString();
       mins = (m % 60).ToString("f0");

         if ((int)Time.time % 10 == 0)
         {
             timerText.text = hours + ":" + mins;
         }

         sun.transform.Rotate(0.01f, 0.0f, 0.0f);    
     

        if ((int)Time.time > 180)

        {
            timerText.text = "End Of Day";
            endofDay = true;
        }
    }
}
