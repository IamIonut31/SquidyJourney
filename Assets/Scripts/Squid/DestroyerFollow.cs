using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerFollow : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        if(target)
        {
            transform.position = new Vector3(target.position.x, target.position.y);
        }
        else
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
}
