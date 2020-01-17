using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObjects : MonoBehaviour
{

    public GameObject effect;

    public void Update()
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
                    //add destroy effect on each destroyed object 
                    GameObject effectInst = (GameObject)Instantiate(effect, transform.position, transform.rotation);
                    Destroy(effectInst, 2f);

    				Destroy(bc.gameObject);
    			}
    		}
    	}
    }

}
