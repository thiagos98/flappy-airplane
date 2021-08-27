using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneController : MonoBehaviour
{
    [SerializeField] private float impulse;
    private Rigidbody2D _mRigidbody;
    
    private void Awake()
    {
        _mRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var space = Input.GetButtonDown("Jump");
        if (space)
        {
            Boost();
        }
    }

    private void Boost()
    {
        _mRigidbody.AddForce(Vector2.up * impulse, ForceMode2D.Impulse);
    }
}
