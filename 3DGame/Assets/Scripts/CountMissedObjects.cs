using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountMissedObjects : MonoBehaviour
{

	public int calories;
	public Text caloriesCount;

	public void Start() 
	{
		calories = 0;
		SetCountText();
	}

    void OnTriggerEnter(Collider c)
    {
    	if (c.gameObject.tag == "food")
    	{
    		calories += 1;
    		c.gameObject.SetActive(false);
    		SetCountText();
    	}
    }

    void SetCountText() {
    	caloriesCount.text = calories.ToString();
    }
}
