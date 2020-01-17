using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectsMenu : MonoBehaviour
{
    public GameObject[] randObjects;
    public Vector3 value;
    public int startWait;
    public float spawnWait;
    public float maxWaitTime;
    public float leastWaitTime;
    public bool stop;

    int random;

    void Start() 
    {
    	StartCoroutine(wait());
    }

    void Update()
    {
    	spawnWait = Random.Range(leastWaitTime, maxWaitTime);
    }

    IEnumerator wait() 
    {
    	yield return new WaitForSeconds(startWait);

    	while (!stop)
    	{
    		random = Random.Range(0,2);

    		Vector3 position = new Vector3(Random.Range(-value.x, value.x), 1, Random.Range(-value.z, value.z));

    		Instantiate(randObjects[random], position + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

    		yield return new WaitForSeconds(spawnWait);
    	}
    }

}