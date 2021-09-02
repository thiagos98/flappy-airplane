using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyController : MonoBehaviour
{
    [SerializeField] private float _timeToMaximumDifficulty;
    private float _timePast;
    public float Difficulty { get; private set; }

    private void Update()
    {
        _timePast += Time.deltaTime;
        Difficulty = _timePast / _timeToMaximumDifficulty;
        Difficulty = Mathf.Min(1f, Difficulty);
    }
}
