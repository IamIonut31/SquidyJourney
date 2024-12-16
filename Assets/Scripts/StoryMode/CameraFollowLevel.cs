using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowLevel : MonoBehaviour
{
    public float yOffset = 1f;
    public Transform target;
    private Vector3 newPos;
    [SerializeField] private int Hight;

    private void Start()
    {
        Screen.SetResolution((int)Screen.width, (int)Screen.height, true);
        //target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            newPos = new Vector3(target.position.x, target.position.y + yOffset, -10f);
            if (newPos.y > transform.position.y && newPos.y < Hight)
            {
                //transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
                transform.position = newPos;
            }
        }
        else
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
}
