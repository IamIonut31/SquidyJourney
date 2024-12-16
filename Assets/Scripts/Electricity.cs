using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electricity : MonoBehaviour
{
    [SerializeField] private GameObject eel;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Electrocute", 0f, 1.5f);
    }

    void Electrocute()
    {
        if(this.GetComponent<BoxCollider2D>().enabled == false)
        {
            this.GetComponent<BoxCollider2D>().enabled = true;
            this.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            this.GetComponent<BoxCollider2D>().enabled = false;
            this.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!eel)
        {
            Destroy(this.gameObject);
        }
    }
}
