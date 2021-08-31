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
        _ScoreText.gameObject.SetActive(false);
        _GameOverImage.gameObject.SetActive(true);
        _score.ZeroPoints();
        UpdateScoreText();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
        _ScoreText.gameObject.SetActive(true);
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
