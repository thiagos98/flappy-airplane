using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Image _GameOverImage;
    [SerializeField] private Text _ScoreText;
    private Score _score;
    private AudioSource _audioGameOver;
    public AudioClip AudioGameOverClip;

    private void Awake()
    {
        _audioGameOver = GetComponent<AudioSource>();
        _score = GetComponent<Score>();
    }

    public void GameOver()
    {
        SetTimeScale(0f);
        _audioGameOver.PlayOneShot(AudioGameOverClip);
        _GameOverImage.gameObject.SetActive(true);
        
    }

    public void RestartGame()
    {
        _score.ZeroPoints();
        UpdateScoreText();
        SceneManager.LoadScene("Game");
        _GameOverImage.gameObject.SetActive(false);
        SetTimeScale(1f);
    }

    public void CountPoints()
    {
        _score.AddPoints();
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        _ScoreText.text = _score.CurrentScore.ToString();
    }

    private void SetTimeScale(float time)
    {
        Time.timeScale = time;
    }
}
