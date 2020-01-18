using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControll : MonoBehaviour
{
    public float Xspeed;
    public float Yspeed;
    public float Zspeed;

    void Update()
    {
        this.gameObject.transform.Translate(Xspeed, Yspeed, Zspeed);
    }
}
