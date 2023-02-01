using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SoundManager : MonoBehaviour
{
    public Sound[] Sounds;
    public Effect[] Effects;
    private AudioSource[] soundAudioSources;

    public string mainTheme;

    private void Awake()
    {
            if (!PlayerPrefs.HasKey("Sound")) PlayerPrefs.SetInt("Sound", 1);
            if (!PlayerPrefs.HasKey("Effect")) PlayerPrefs.SetInt("Effect", 1);
            if (!PlayerPrefs.HasKey("SoundSlider")) PlayerPrefs.SetFloat("SoundSlider", 1f);
            if (!PlayerPrefs.HasKey("EffectSlider")) PlayerPrefs.SetFloat("EffectSlider", 1f);
        //var i = 0;
        foreach (Sound sound in Sounds)
        {
            // sound.AudioSource = gameObject.AddComponent<AudioSource>();
            // sound.AudioSource.clip = sound.clip;
            
            sound.AudioSource.volume = sound.Volume;
            sound.AudioSource.mute = sound.Mute;
           // soundAudioSources[i] = sound.AudioSource;
           // i++;
        }
        foreach (Effect sound in Effects)
        {
           // sound.AudioSource = gameObject.AddComponent<AudioSource>();
            //sound.AudioSource.clip = sound.clip;
            sound.AudioSource.volume = sound.Volume;
            sound.AudioSource.mute = sound.Mute;
        }
    }

    private void Start()
    {
        Play(mainTheme);
    }

    private void Update()
    {
        SoundCheck();
        EffectCheck();
       SoundSliderCheck();
      //  EffectSliderCheck();
    }

    public void Play(string soundName)
    {
        Sound s = Array.Find(Sounds, Sound => Sound.nameSound == soundName);

        if (s == null)
        {
            Debug.LogError(soundName + " ���� �� ������!");
            return;
        }
        s.AudioSource.Play();
    }

    public void SoundCheck()
    {
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            foreach (Sound sound in Sounds)
            {
                sound.AudioSource.mute = false;   
            }
        }
        else
        {
            foreach (Sound sound in Sounds)
            {
                sound.AudioSource.mute = true;
            }
        }
    }

    public void EffectCheck()
    {
        if (PlayerPrefs.GetInt("Effect") == 1)
        {
            foreach (Effect sound in Effects)
            {
                sound.AudioSource.mute = false;
            }
        }
        else
        {
            foreach (Effect sound in Effects)
            {
                sound.AudioSource.mute = true;
            }
        }
    }

    public void SoundSliderCheck()
    {
       
           // var j = 0;
            foreach (Sound sound in Sounds)
            {
                sound.AudioSource.volume = PlayerPrefs.GetFloat("SoundSlider");
               // soundAudioSources[j].volume = PlayerPrefs.GetFloat("SoundSlider");
                Debug.Log(sound.AudioSource.volume);
                //j++;
            }
        
    }

    public void EffectSliderCheck()
    {
        if (PlayerPrefs.GetFloat("Effect") == 1)
        {
            foreach (Effect sound in Effects)
            {
                sound.AudioSource.volume = PlayerPrefs.GetFloat("EffectSlider");
            }
        }
    }
}
