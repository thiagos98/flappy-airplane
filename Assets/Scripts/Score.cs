using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    [SerializeField] private UnityEvent _whenScoring;
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

    public void AddScore()
    {
        CurrentScore++;
        _audioScore.PlayOneShot(AudioScoreClip);
        _whenScoring.Invoke();
    }

    public void ZeroScore()
    {
        CurrentScore = 0;
    }

    public void SaveScore()
    {
        if (CurrentScore > PlayerPrefs.GetInt("MaxScore"))
        {
            PlayerPrefs.SetInt("MaxScore", CurrentScore);
        }
    }
    
}
