using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DezactivateJump : MonoBehaviour
{
    public JumpNew JumpREF;
    public StartGround sg;

    private void Start()
    {
        StartCoroutine("StartGame");
        //JumpREF = GameObject.FindGameObjectWithTag("Player").GetComponent(typeof(Jump)) as Jump;
    }
    IEnumerator StartGame()
    {
        JumpREF.enabled = false;
        sg.enabled = false;
        yield return new WaitForSeconds(1f);
        JumpREF.enabled = true;
        sg.enabled = true;
    }
}
