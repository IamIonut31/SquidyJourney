using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    private Scene scene;
    [SerializeField] Animator transition;
    int LevelNumber;
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        LevelNumber = scene.buildIndex + 1;
    }
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
