using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("Audio Source")]
    public AudioSource sfxSource;
    public AudioSource musicSource;

    [Header("Audio Clips")]
    public AudioClip jumpClip;
    public AudioClip hitClip;
    public AudioClip buttonClip;



    public void PlaySFX(AudioClip clip)
    {
        if (clip != null)
        {
            sfxSource.PlayOneShot(clip);
        }
    }

    public void PlayJump()
    {
        PlaySFX(jumpClip);
    }

    public void PlayHit()
    {
        PlaySFX(hitClip);
    }

    public void PlayButton()
    {
        PlaySFX(buttonClip);
    }
}
