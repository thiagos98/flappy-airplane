using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameControllerMultiplayer : GameController
{
    private bool isSomeoneDead;
    private int _pointsSinceTheDeath;
    private readonly int _pointsToRevive = 2;
    private Player[] _players;

    protected override void Start()
    {
        base.Start();
        _players = FindObjectsOfType<Player>();
    }

    public void ReviveIfNeed()
    {
        if(isSomeoneDead)
        {
            _pointsSinceTheDeath++;
            if(_pointsSinceTheDeath >= _pointsToRevive)
            {
                RevivePlayers();
            }
        }
    }

    private void RevivePlayers()
    {
        isSomeoneDead = false;
        foreach(var player in _players)
        {
            player.Enable();
        }
    }

    public void SomeoneDied()
    {
        isSomeoneDead = true;
        _pointsSinceTheDeath = 0;
    }
}
