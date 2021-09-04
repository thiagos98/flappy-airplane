using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Carousel[] _scenery;
    private ObstacleGenerator _obstacleGen;
    private AirplaneController _airplane;
    private bool isDead;

    private void Start()
    {
        _airplane = GetComponentInChildren<AirplaneController>();
        _scenery = GetComponentsInChildren<Carousel>();
        _obstacleGen = GetComponentInChildren<ObstacleGenerator>();
    }

    public void Disable()
    {
        isDead = true;
        _obstacleGen.StopObstacles();
        foreach(var carousel in _scenery)
        {
            carousel.enabled = false;
        }
    }

    public void Enable()
    {
        if (!isDead) return;

        _airplane.RestartAirplane();
        _obstacleGen.RestartObstacles();
        foreach (var carousel in _scenery)
        {
            carousel.enabled = true;
        }
        isDead = false;
    }
}
