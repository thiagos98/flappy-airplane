using System;
using UnityEngine;

public class Score : MonoBehaviour
{
    private AudioSource _audioScore;
    public AudioClip AudioScoreClip;
    public int CurrentScore { get; private set; }

    private void Awake()
    {
        _audioScore = GetComponent<AudioSource>();
    }

    private void Start()
    {
        CurrentScore = 0;
    }

    public void AddPoints()
    {
        CurrentScore++;
        _audioScore.PlayOneShot(AudioScoreClip);
    }

    public void ZeroPoints()
    {
        CurrentScore = 0;
    }
}
