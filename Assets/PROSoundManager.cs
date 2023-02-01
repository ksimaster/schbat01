using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class PROSoundManager : MonoBehaviour
{
    private void Awake()
    {
            if (!PlayerPrefs.HasKey("Sound")) PlayerPrefs.SetInt("Sound", 1);
            if (!PlayerPrefs.HasKey("SoundSlider")) PlayerPrefs.SetFloat("SoundSlider", 1f);
    }
    private void Update()
    {
       SoundCheck();
       SoundSliderCheck();
    }
    public void SoundCheck()
    {
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            AudioListener.pause = false;
        }
        else
        {
            AudioListener.pause = true;
        }
    }
    public void SoundSliderCheck()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("SoundSlider");
        Debug.Log(AudioListener.volume);   
    }

   
}
