using UnityEngine;
using System.Collections;
using TMPro;

public class ShowFPS : MonoBehaviour
{
    public TextMeshProUGUI fpsText;
    public float deltaTime;
    private float fps;

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        fps = 1.0f / deltaTime;
        fpsText.text = Mathf.Ceil(fps).ToString();
    }
}