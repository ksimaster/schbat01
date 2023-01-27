using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public Sound[] Sounds;
    public Effect[] Effects;

    public string mainTheme;

    private void Awake()
    {
        foreach (Sound sound in Sounds)
        {
            sound.AudioSource = gameObject.AddComponent<AudioSource>();
            sound.AudioSource.clip = sound.clip;
            sound.AudioSource.volume = sound.Volume;
            sound.AudioSource.loop = sound.Loop;
        }
    }

}
