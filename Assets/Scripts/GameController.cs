using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private InterfaceController _interfaceController;
    private Score _score;
    private AudioSource _audioGameOver;
    public AudioClip AudioGameOverClip;
    private AudioAirplaneController audioAirplane;
    
    private void Awake()
    {
        _audioGameOver = GetComponent<AudioSource>();
        _score = GetComponent<Score>();
    }

    private void Start()
    {
        _interfaceController = FindObjectOfType<InterfaceController>();
        audioAirplane = FindObjectOfType<AudioAirplaneController>();
        audioAirplane.Play();
    }

    public void GameOver()
    {
        SetTimeScale(0f);
        _audioGameOver.PlayOneShot(AudioGameOverClip);
        _interfaceController.SetGameOverPanel(true);
        MaxScore();
        audioAirplane.Stop();
    }

    private void MaxScore()
    {
        _score.SaveScore();
        _interfaceController.UpdateMaxScoreText();
    }
    
    public void RestartGame()
    {
        _score.ZeroScore();
        _interfaceController.UpdateScoreText(_score);
        SceneManager.LoadScene("Game Coop");
        _interfaceController.SetGameOverPanel(false);
        SetTimeScale(1f);
    }

    public void CountPoints()
    {
        _score.AddScore();
        _interfaceController.UpdateScoreText(_score);
    }
    
    private void SetTimeScale(float time)
    {
        Time.timeScale = time;
    }
}
