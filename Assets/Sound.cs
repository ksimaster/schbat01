using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound : MonoBehaviour
{
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float Volume = 1f;

    public bool Loop = false;

    [HideInInspector]
    public AudioSource AudioSource;
}
