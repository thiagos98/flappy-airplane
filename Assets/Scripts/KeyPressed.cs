using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyPressed : MonoBehaviour
{
    [SerializeField] private KeyCode _key;
    [SerializeField] private UnityEvent _whenPressingKey;

    private void Update()
    {
        if(Input.GetKeyDown(_key))
        {
            _whenPressingKey.Invoke();
        }
    }
}
