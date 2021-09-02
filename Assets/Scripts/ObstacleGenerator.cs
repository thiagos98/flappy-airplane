using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] private float _timeToGenerateEasy;
    [SerializeField] private float _timeToGenerateHard;
    [SerializeField] private GameObject _obstacle;
    private float _stopwatch;
    private const float _maxRange = 1.90f;
    private const float _minRange = -1.76f;
    private DifficultyController _difficultyController;

    private void Awake()
    {
        _stopwatch = _timeToGenerateEasy;
    }

    private void Start()
    {
        _difficultyController = FindObjectOfType<DifficultyController>();
    }

    private void Update()
    {
        _stopwatch -= Time.deltaTime;
        if (_stopwatch < 0)
        {
            transform.position = new Vector3(transform.position.x, Random.Range(_minRange, _maxRange));
            Instantiate(_obstacle, transform.position, Quaternion.identity);
            _stopwatch = Mathf.Lerp(_timeToGenerateEasy, _timeToGenerateHard, _difficultyController.Difficulty);
        }
    }
}
