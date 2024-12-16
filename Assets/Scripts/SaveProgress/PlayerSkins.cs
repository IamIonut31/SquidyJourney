using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerSkins
{
    public int currentskinindex;
    public bool[] SquidSkins;

    public PlayerSkins(ShopManager shopmanager)
    {
        currentskinindex = ShopManager.currentskinindex;

        SquidSkins = new bool[12];
        SquidSkins[0] = true;
        for(int i=1; i<=11; i++)
        {
            SquidSkins[i] = shopmanager.squidskins[i];
        }
    }
}
