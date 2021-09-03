using System;
using UnityEngine;

public class AirplaneController : MonoBehaviour 
{
    private Rigidbody2D _rigidbody;
    [SerializeField] private float _force = 6;
    private GameController _gameController;
    private bool canBoost;
    private Animator _animator;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        _gameController = GameObject.FindObjectOfType<GameController>();
    }

    private void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            canBoost = true;
        }
        _animator.SetFloat("SpeedY", _rigidbody.velocity.y);
    }

    private void FixedUpdate()
    {
        if (canBoost)
        {
            Boost();
        }
    }

    private void Boost()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
        canBoost = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _gameController.GameOver();
    }
}