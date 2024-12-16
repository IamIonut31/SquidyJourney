using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] GameObject levelCompleted;
    [SerializeField] LevelManager levelmanager;
    [SerializeField] Score score;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.SetActive(false);
            Score.Perls = Score.Perls + Score.Points;
            Score.Points = 0;
            score.SaveGame();
            levelmanager.LevelCompleted();
            levelCompleted.SetActive(true);
        }
    }
}
