using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAirplaneController : MonoBehaviour
{
    private AudioSource _audio;

    private void Awake() {
        _audio = GetComponent<AudioSource>();
    }

    public void Play()
    {
        _audio.Play();   
    }

    public void Stop()
    {
        _audio.Stop();
    }
}
