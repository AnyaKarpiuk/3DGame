using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObjects : MonoBehaviour
{
	public int destroyedObjects;
	public Text destroyedObjectsCount;


	void Start()
	{
		destroyedObjects = 0;
		setCountText();
	}

    void Update()
    {
    	//if the player click on any of the objects it's destroyed
    	if (Input.GetMouseButtonDown(0))
    	{
    		RaycastHit hit;
    		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

    		if (Physics.Raycast(ray, out hit))
    		{
    			BoxCollider bc = hit.collider as BoxCollider;
    			if(bc != null && bc.gameObject.tag == "food")
    			{
    				Destroy(bc.gameObject);
    				destroyedObjects += 1;
    				setCountText();
    			}
    		}
    	}
    }


    //display a number of destroyed objects on the screen
    void setCountText()
    {
    	destroyedObjectsCount.text = destroyedObjects.ToString();
    }
}
