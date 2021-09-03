using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    [SerializeField] private Image _GameOverPanel;
    [SerializeField] private Text _ScoreText;
    [SerializeField] private Text _MaxScoreText;
    [SerializeField] private Image _Medal;
    [SerializeField] private Sprite _GoldMedal;
    [SerializeField] private Sprite _SilverMedal;
    [SerializeField] private Sprite _BronzeMedal;
    private float _maxScore;
    private Score _score;

    private void Start()
    {
        _score = FindObjectOfType<Score>();
    }

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
        _maxScore = PlayerPrefs.GetInt("MaxScore");
        _MaxScoreText.text = _maxScore.ToString();
        CheckMedalColor();
    }

    private void CheckMedalColor()
    {
        if (_score.CurrentScore > _maxScore - 1)
        {
            _Medal.sprite = _GoldMedal;
        }
        else if (_score.CurrentScore > (_maxScore / 2))
        {
            _Medal.sprite = _SilverMedal;
        }
        else
        {
            _Medal.sprite = _BronzeMedal;
        }
        
    }
}
