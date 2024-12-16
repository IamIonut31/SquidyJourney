using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    Scene scene;
    [SerializeField] Animator transition;
    [SerializeField] GameObject GameOver;
    [SerializeField] private int SceneNumber;
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    public void ExitToMainMenu()
    {
        StartCoroutine(LoadMenu());
    }

    IEnumerator LoadMenu()
    {
        transition.SetTrigger("End");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneNumber);
    }

    public void Restart()
    {
        StartCoroutine(LoadGame());
    }

    IEnumerator LoadGame()
    {
        transition.SetTrigger("End");
        yield return new WaitForSeconds(1.5f);
        GameOver.SetActive(false);
        SceneManager.LoadScene(scene.buildIndex);
    }

    public void Continue()
    {
        Time.timeScale = 1;
    }

    public void Stop()
    {
        Time.timeScale = 0;
    }
}

