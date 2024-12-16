using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int HighScore;
    public int Perls;

    public PlayerData(Score score)
    {
        HighScore = Score.HighScore;
        Perls = Score.Perls;
    }
}
