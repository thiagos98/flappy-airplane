using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] private float _timeToGenerate;
    [SerializeField] private GameObject _obstacles;
    private float _stopwatch;

    private void Awake()
    {
        _stopwatch = _timeToGenerate;
    }

    private void Update()
    {
        _stopwatch -= Time.deltaTime;
        if (!(_stopwatch < 0)) return;
        Instantiate(_obstacles, transform.position, Quaternion.identity);
        _stopwatch = _timeToGenerate;
    }
}
