using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private GameObject destroyer;
    [SerializeField] private GameObject respawnscreen;
    [SerializeField] GameObject Pause;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Respawn()
    {
        StartCoroutine("destroyertimer");
    }

    IEnumerator destroyertimer()
    {
        destroyer.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        destroyer.SetActive(false);
        player.SetActive(true);
        player.GetComponent<JumpNew>().RespawnJN();
        Pause.SetActive(true);
        respawnscreen.SetActive(false);
    }
}
