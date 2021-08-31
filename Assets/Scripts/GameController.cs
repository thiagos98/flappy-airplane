using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Image _GameOverImage;
    public void GameOver()
    {
        Time.timeScale = 0f;
        _GameOverImage.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
        _GameOverImage.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
