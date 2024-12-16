using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int TriesNumber = 0;
    public static int Perls = 0;
    public static int HighScore = 0;
    public static int Points = 0;
    public static int Deaths = 0;
    public static bool Death = false;
    public static bool Point = false;
    public static bool Sound = true;
    [SerializeField] TextMeshProUGUI PointsOnScreen;
    [SerializeField] TextMeshProUGUI PointsOnScreenShadow;
    [SerializeField] TextMeshProUGUI CurrentScore;
    [SerializeField] TextMeshProUGUI CurrentScoreShadow;
    [SerializeField] TextMeshProUGUI BestScore;
    [SerializeField] TextMeshProUGUI BestScoreShadow;
    [SerializeField] GameObject GameOver;
    [SerializeField] GameObject Respawn;
    [SerializeField] GameObject Pause;
    [SerializeField] private AudioSource PointSound;
    [SerializeField] private bool Endless = false;

    private void Awake()
    {
        //QualitySettings.vSyncCount = -1;
        //Application.targetFrameRate = 90;
    }
    private void Start()
    {
        QualitySettings.vSyncCount = -1;
        Application.targetFrameRate = 60;
        LoadSave();
    }
    private void Update()
    {
        if(Point == true)
        {
            PointUp();
            Point = false;
        }
        if(Death == true)
        {
            Deaths = Deaths + 1;
            if(Deaths == 2)
            {
                Dead();
            }
            else if(Deaths == 1)
            {
                Respawntry();
            }
            Death = false;
        }
    }

    public void Respawntry()
    {
        Time.timeScale = 0;
        Pause.SetActive(false);
        Respawn.SetActive(true);
    }

    public void RefuseRespawn()
    {
        Deaths = 0;
    }

    public void Dead()
    {
        Time.timeScale = 1;
        Pause.SetActive(false);
        PointsOnScreen.gameObject.SetActive(false);
        PointsOnScreenShadow.gameObject.SetActive(false);
        TriesNumber = TriesNumber + 1;
        if(Endless == true)
        {
            if (Points > HighScore)
            {
                HighScore = Points;
            }
        }
        CurrentScore.text = Points.ToString();
        CurrentScoreShadow.text = Points.ToString();
        BestScore.text = HighScore.ToString();
        BestScoreShadow.text = HighScore.ToString();
        GameOver.SetActive(true);
        Perls = Perls + Points;
        Points = 0;
        Deaths = 0;
        SaveSystem.SaveGame(this);
    }

    public void PointUp()
    {
        PointSound.Play();
        Points = Points + 1;
        PointsOnScreen.text = Points.ToString();
        PointsOnScreenShadow.text = Points.ToString();
    }

    public void LoadSave()
    {
        PlayerData data = SaveSystem.LoadGame();

        Perls = data.Perls;
        HighScore = data.HighScore;
    }

    public void SaveGame()
    {
        SaveSystem.SaveGame(this);
    }

    public void PointsDelete()
    {
        TriesNumber = TriesNumber + 1;
        if (Points > HighScore)
        {
            HighScore = Points;
        }
        CurrentScore.text = Points.ToString();
        CurrentScoreShadow.text = Points.ToString();
        BestScore.text = HighScore.ToString();
        BestScoreShadow.text = HighScore.ToString();
        Perls = Perls + Points;
        Points = 0;
        Deaths = 0;
        SaveSystem.SaveGame(this);
    }
    public void AddPoints()
    {
        Perls = Perls + 100;
        SaveSystem.SaveGame(this);
        SaveSystem.LoadGame();
    }
}
