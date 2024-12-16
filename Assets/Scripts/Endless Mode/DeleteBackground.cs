using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBackground : MonoBehaviour
{
    public GameObject target;
    public GameObject BackgroudLight;
    public GameObject Backgroud;
    public static bool WithLight = true;

    void Update()
    {
        if(target)
        {
            if (target.transform.position.y - this.gameObject.transform.position.y >= 15f)
            {
                if (WithLight == false)
                {
                    Instantiate(Backgroud, new Vector3(0f, this.gameObject.transform.position.y + 30f, 0f), Quaternion.identity);
                    WithLight = true;
                }
                else if (WithLight == true)
                {
                    Instantiate(BackgroudLight, new Vector3(0f, this.gameObject.transform.position.y + 30f, 0f), Quaternion.identity);
                    WithLight = false;
                }
                Destroy(this.gameObject);
            }
        }
        else
        {
            target = GameObject.FindWithTag("Player");
        }
    }
}
