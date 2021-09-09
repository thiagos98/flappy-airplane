using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameControllerMultiplayer : GameController
{
    private bool isSomeoneDead;
    private int _pointsSinceTheDeath;
    [SerializeField] private int _pointsToRevive = 2;
    private Player[] _players;
    private InactiveCanvasInterface _inactiveCanvas;

    protected override void Start()
    {
        base.Start();
        _players = FindObjectsOfType<Player>();
        _inactiveCanvas = FindObjectOfType<InactiveCanvasInterface>();
    }

    public override void RestartGame(string scene)
    {
        base.RestartGame("Game Coop");
        RevivePlayers();
    }

    public void ReviveIfNeed()
    {
        if(isSomeoneDead)
        {
            _pointsSinceTheDeath++;
            _inactiveCanvas.UpdateText(_pointsToRevive - _pointsSinceTheDeath);
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
            _inactiveCanvas.DisableBackground();
            player.Enable();
        }
    }

    public void SomeoneDied(Camera camera)
    {
        if(isSomeoneDead)
        {
            _inactiveCanvas.DisableBackground();
            GameOver();
        }
        else
        {
            isSomeoneDead = true;
            _pointsSinceTheDeath = 0;
            _inactiveCanvas.UpdateText(_pointsToRevive);
            _inactiveCanvas.EnableBackground(camera);
        }
    }
}
