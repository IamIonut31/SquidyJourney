using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] Animator transition;

    public void StartGame()
    {
        StartCoroutine(LoadLevel());
    }
    public void StartStory()
    {
        StartCoroutine(LoadSelector());
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("End");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);
    }
    IEnumerator LoadSelector()
    {
        transition.SetTrigger("End");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(2);
    }
}
