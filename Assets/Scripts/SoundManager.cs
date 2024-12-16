using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public static bool Music = true;
    public static bool Sound = true;
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject MuteButton;
    [SerializeField] private GameObject UnMuteButton;
    [SerializeField] private AudioMixerGroup Sounds;

    private void Awake()
    {
        if (Music == false)
        {
            Camera.GetComponent<AudioSource>().Stop();
            MuteButton.SetActive(true);
            UnMuteButton.SetActive(false);
        }
        else
        {
            Camera.GetComponent<AudioSource>().Play();
            UnMuteButton.SetActive(true);
            MuteButton.SetActive(false);
        }
    }


    private void Test()
    {
        if (Music == false)
        {
            Camera.GetComponent<AudioSource>().Stop();
            MuteButton.SetActive(true);
            UnMuteButton.SetActive(false);
        }
        else
        {
            Camera.GetComponent<AudioSource>().Play();
            UnMuteButton.SetActive(true);
            MuteButton.SetActive(false);
        }
        if(Sound == true)
        {
            Sounds.audioMixer.SetFloat("Sounds Volume", -80);
        }
        else
        {
            Sounds.audioMixer.SetFloat("Sounds Volume", 0);
        }
        if (Sound == false)
        {
            Camera.GetComponent<AudioListener>().enabled = false;
            MuteButton.SetActive(true);
            UnMuteButton.SetActive(false);
        }
        else
        {
            Camera.GetComponent<AudioListener>().enabled = true;
            UnMuteButton.SetActive(true);
            MuteButton.SetActive(false);
        }
    }
    public void Mute()
    {
        Music = false;
    }
    public void UnMute()
    {
        Music = true;
    }
    public void SoundMute()
    {
        Sound = false;
    }
    public void SoundUnMute()
    {
        Sound = true;
    }
}
