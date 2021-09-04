using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Carousel[] _scenery;
    private ObstacleGenerator _obstacleGen;

    private void Start()
    {
        _scenery = GetComponentsInChildren<Carousel>();
        _obstacleGen = GetComponentInChildren<ObstacleGenerator>();
    }

    public void Disable()
    {
        _obstacleGen.Stop();
        foreach(var carousel in _scenery)
        {
            carousel.enabled = false;
        }
    }
}
