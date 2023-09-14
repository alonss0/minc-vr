using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource[] audioSources;

    private void Start()
    {
        audioSources = FindObjectsOfType<AudioSource>();
    }

    public void PlayAudio(AudioSource sourceToPlay)
    {
        foreach (var source in audioSources)
        {
            if (source == sourceToPlay)
            {
                source.Play();
            }
            else
            {
                source.Stop();
            }
        }
    }
}
