using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VerticalLimiter : MonoBehaviour
{
    public UnityEvent _verticalLimiter;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            _verticalLimiter.Invoke();
        }
    }
}
