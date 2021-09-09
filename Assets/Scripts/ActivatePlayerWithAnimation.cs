using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivatePlayerWithAnimation : MonoBehaviour
{
    [SerializeField] private UnityEvent _WhenEndingAnimation;

    public void EnablePhysics()
    {
        _WhenEndingAnimation.Invoke();
    }
}
