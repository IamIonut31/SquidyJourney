using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayPerls : MonoBehaviour
{
    public static int Perls = 0;
    [SerializeField] TextMeshProUGUI PerlsOnScreen;
    void Start()
    {
        LoadSave();
        PerlsOnScreen.text = Perls.ToString();
    }

    public void ResetDisplayPerls()
    {
        PerlsOnScreen.text = Score.Perls.ToString();
        LoadSave();
    }

    public void LoadSave()
    {
        PlayerData data = SaveSystem.LoadGame();

        Perls = data.Perls;
    }
}
