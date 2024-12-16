using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pufferfish : MonoBehaviour
{
    [SerializeField] private AudioSource Inhale;
    [SerializeField] private AudioSource Exhale;
    private bool first = true;

    void Start()
    {
        InvokeRepeating("PufferfishAnim", 0f, 1.5f);
    }

    void PufferfishAnim()
    {
        this.GetComponent<Animator>().SetTrigger("Anim");
        if(first == true)
        {
            Inhale.Play();
            first = false;
        }
        else
        {
            Exhale.Play();
            first = true;
        }
    }
}
