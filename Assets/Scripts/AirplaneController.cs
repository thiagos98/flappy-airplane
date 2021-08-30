using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AirplaneController : MonoBehaviour
{
    [SerializeField] private float _impulse = 10;
    private Rigidbody2D _rigidbody;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Boost();
        }
    }

    private void Boost()
    {
        _rigidbody.AddForce(Vector2.up * _impulse, ForceMode2D.Impulse);
    }
}
