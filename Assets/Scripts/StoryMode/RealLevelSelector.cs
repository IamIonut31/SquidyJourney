using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RealLevelSelector : MonoBehaviour
{
    [SerializeField] Animator transition;
    [SerializeField] int LevelNumber;
    public void EnterLevel()
    {
        StartCoroutine(LoadSelector());
    }
    IEnumerator LoadSelector()
    {
        transition.SetTrigger("End");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(LevelNumber);
    }
}
