using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDestroyedObjects : MonoBehaviour
{

    private int destroyedObjects;
	public Text destroyedObjectsCount;

	public Text bestResult;

	public void Start()
	{
		destroyedObjects = 0;
		setCountText();

		bestResult.text = "Best result: " + PlayerPrefs.GetInt("BestResult", 0).ToString();
	}

    public void Update()
    {
    	//if the player click on any of the objects the number of destroyed objects is displayed
    	if (Input.GetMouseButtonDown(0))
    	{
    		RaycastHit hit;
    		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

    		if (Physics.Raycast(ray, out hit))
    		{
    			BoxCollider bc = hit.collider as BoxCollider;
    			if(bc != null && bc.gameObject.tag == "food")
    			{
    				destroyedObjects += 1;
    				setCountText();	
    			}

    			//display the best result 
    			if (destroyedObjects > PlayerPrefs.GetInt("BestResult", 0))
    			{
    				PlayerPrefs.SetInt("BestResult", destroyedObjects);
    				bestResult.text = "Best result: " + destroyedObjects.ToString();
    			}
    		}
    	}
    }


    //display a number of destroyed objects on the screen
    public void setCountText()
    {
    	destroyedObjectsCount.text = destroyedObjects.ToString();
    }
}
