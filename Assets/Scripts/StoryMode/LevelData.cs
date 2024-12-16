using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelData
{
    public bool[] LevelState;
    public LevelData(LevelManager LevelMangaer)
    {
        LevelState = new bool[40];
        for(int i = 0; i <= 39; i++)
        {
            LevelState[i] = LevelManager.LevelState[i];
        }
    }
}
