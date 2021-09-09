using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InactiveCanvasInterface : MonoBehaviour
{
    [SerializeField] private GameObject _background;
    [SerializeField] private Text _pointsToReviveText;
    private Canvas _canvas;

    private void Awake()
    {
        _canvas = GetComponent<Canvas>();
    }

    public void UpdateText(int pointsToRevive)
    {
        _pointsToReviveText.text = pointsToRevive.ToString();
    }

    public void EnableBackground(Camera camera)
    {
        _canvas.worldCamera = camera;
        _background.SetActive(true);
    }

    public void DisableBackground()
    {
        _background.SetActive(false);
    }
}
