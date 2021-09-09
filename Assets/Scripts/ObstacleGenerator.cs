using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] private float _timeToGenerateEasy;
    [SerializeField] private float _timeToGenerateHard;
    [SerializeField] private GameObject _obstacle;
    private float _stopwatch;
    [SerializeField] private float _maxRange;
    [SerializeField] private float _minRange;
    private DifficultyController _difficultyController;
    private bool isStopped;

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
        if (isStopped) return;

        _stopwatch -= Time.deltaTime;
        if (_stopwatch < 0)
        {
            transform.position = new Vector3(transform.position.x, Random.Range(_minRange, _maxRange));
            Instantiate(_obstacle, transform.position, Quaternion.identity);
            _stopwatch = Mathf.Lerp(_timeToGenerateEasy, _timeToGenerateHard, _difficultyController.Difficulty);
        }
    }

    public void StopObstacles()
    {
        isStopped = true;
    }

    public void RestartObstacles()
    {
        isStopped = false;
    }
}
