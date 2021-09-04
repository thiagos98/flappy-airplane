using System;
using UnityEngine;
using UnityEngine.Events;

public class AirplaneController : MonoBehaviour 
{
    [SerializeField] private float _force = 6;
    [SerializeField] private UnityEvent _onCollision;
    private Rigidbody2D _rigidbody;
    private bool canBoost;
    private Animator _animator;
    private Vector3 _initialPosition;

    private void Awake()
    {
        _initialPosition = transform.position;
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update () 
    {
        _animator.SetFloat("SpeedY", _rigidbody.velocity.y);
    }

    private void FixedUpdate()
    {
        if (canBoost)
        {
            Boost();
        }
    }

    public void CanBoost()
    {
        canBoost = true;
    }

    private void Boost()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
        canBoost = false;
    }
    
    public void RestartAirplane()
    {
        transform.position = _initialPosition;
        _rigidbody.simulated = true;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _rigidbody.simulated = false;
        _onCollision.Invoke();
    }
}