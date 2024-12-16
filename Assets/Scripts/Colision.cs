using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.SetActive(false);
            if(this.gameObject.tag == "Ground")
            {
                Score.Deaths = 1;
                Score.Death = true;
            }
            else
            {
                Score.Death = true;
            }
        }
    }
}
