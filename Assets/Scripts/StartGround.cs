using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGround : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            this.gameObject.SetActive(false);
        }
    }
}
