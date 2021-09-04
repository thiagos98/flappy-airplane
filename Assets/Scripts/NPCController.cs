using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    private AirplaneController _airplane;

    private void Start()
    {
        _airplane = GetComponent<AirplaneController>();
        StartCoroutine(Boost());
    }
    private IEnumerator Boost()
    {
        while(true)
        {
            var timer = Random.Range(0.4f, 0.7f);
            yield return new WaitForSeconds(timer);
            _airplane.CanBoost();
        }
    }
}
