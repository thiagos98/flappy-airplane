using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    [SerializeField] private Image _GameOverPanel;
    [SerializeField] private Text _ScoreText;
    [SerializeField] private Text _MaxScoreText;

    public void SetGameOverPanel(bool set)
    {
        _GameOverPanel.gameObject.SetActive(set);
    }
    
    public void UpdateScoreText(Score score)
    {
        _ScoreText.text = score.CurrentScore.ToString();
    }
    
    public void UpdateMaxScoreText()
    {
        _MaxScoreText.text = PlayerPrefs.GetInt("MaxScore").ToString();
    }
}
