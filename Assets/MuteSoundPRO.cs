using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteSoundPRO : MonoBehaviour
{
    public GameObject soundCheck;
    public Slider soundSlider;
    
    private void Start()
    {
        soundCheck.GetComponent<Toggle>().isOn = PlayerPrefs.GetInt("Sound") == 1 ? true : false;
        soundSlider.value = PlayerPrefs.GetFloat("SoundSlider");
    }
    private void Update()
    {
        AudioChecker(soundCheck, "Sound");
        SoundSliderChanger();
    }

    public void AudioChecker(GameObject audioCheck, string namePref)
    {
        if (audioCheck.GetComponent<Toggle>().isOn) 
        {
            PlayerPrefs.SetInt(namePref, 1);
        }
        else
        {
            PlayerPrefs.SetInt(namePref, 0);
        }
    } 

    public void SoundSliderChanger()
    {
        PlayerPrefs.SetFloat("SoundSlider", soundSlider.value);
    }

}
