using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkinImport : MonoBehaviour
{
    public static int currentskinindex = 0;
    public TextMeshProUGUI displayindex;
    public GameObject[] Skin;
    public RespawnPlayer respawnplayer;
    public DeleteBackground deletebackground;
    public DeleteBackground deletebackground1;
    public DeleteBackground deletebackground2;

    private void Start()
    {
        LoadSkins();
        displayindex.text = currentskinindex.ToString();
        Skin[currentskinindex].SetActive(true);
        deletebackground.target = Skin[currentskinindex].gameObject;
        deletebackground1.target = Skin[currentskinindex].gameObject;
        deletebackground2.target = Skin[currentskinindex].gameObject;
        respawnplayer.player = Skin[currentskinindex].gameObject;
    }
    public void LoadSkins()
    {
        PlayerSkins data = SaveSystem.LoadSkins();

        currentskinindex = data.currentskinindex;
    }
}
