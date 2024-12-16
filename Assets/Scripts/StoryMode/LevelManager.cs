using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    Scene scene;
    public static bool[] LevelState = new bool[40];
    [SerializeField] private GameObject[] Numbers;
    [SerializeField] private TextMeshProUGUI[] NumbersColor;
    [SerializeField] private GameObject[] LocksImages;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        LoadSave();
        if(scene.buildIndex == 2)
        {
            for (int i = 0; i <= 39; i++)
            {
                if(LevelState[i] == true)
                {
                    LocksImages[i].SetActive(false);
                    Numbers[i].SetActive(true);
                    NumbersColor[i].color = new Color32(0, 210, 0, 255);
                }
                else
                {
                    Numbers[i].SetActive(false);
                    LocksImages[i].SetActive(true);

                    if (i == 0 || LevelState[i-1] == true)
                    {
                        LocksImages[i].SetActive(false);
                        Numbers[i].SetActive(true);
                    }
                    NumbersColor[i].color = new Color32(210, 0, 0, 255);
                }
            }
        }
        for (int i = 0; i <= 39; i++)
        {
            //Debug.Log(LevelState[i]);
        }
    }
    public void LoadSave()
    {
        LevelData data = SaveSystem.LoadLevels();
        for(int i = 0; i <= 39; i++)
        {
            LevelState[i] = data.LevelState[i];
        }
    }
    public void SaveGame()
    {
        SaveSystem.SaveLevels(this);
    }
    public void LevelCompleted()
    {
        LevelState[scene.buildIndex - 3] = true;
        SaveSystem.SaveLevels(this);
    }
}
