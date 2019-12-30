using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountMissedObjects : MonoBehaviour
{

	public int calories;
	public Text caloriesCount;

	public Image caloriesBar;
	public float startCal = 100;

    public GameObject losingScreen;

	public void Start() 
	{
		calories = 0;
		SetCountText();
        losingScreen.SetActive(false);
	}

    void OnTriggerEnter(Collider c)
    {
    	if (c.gameObject.tag == "food")
    	{
            //fill bar space every time an object is missed
            startCal -= 10;
            caloriesBar.fillAmount = startCal / 100f;

            //add 400 cal every time the object is missed
    		calories += 400;
    		c.gameObject.SetActive(false);
    		SetCountText();

            //display game over screen when the player exceet 4000cal
            if (calories > 3800)
            {
                gameOver();
            }
    	}
    }

    void SetCountText() {
    	caloriesCount.text = calories.ToString() + " cal";
    }

    //game over screen display
    public void gameOver()
    {
        losingScreen.SetActive(true);
    }
}
