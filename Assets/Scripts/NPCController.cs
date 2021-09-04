using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    private AirplaneController _airplane;
    [SerializeField] private float minRange;
    [SerializeField] private float maxRange;

    private void Start()
    {
        _airplane = GetComponent<AirplaneController>();
        StartCoroutine(Boost());
    }
    private IEnumerator Boost()
    {
        while(true)
        {
            var timer = Random.Range(minRange, maxRange);
            yield return new WaitForSeconds(timer);
            _airplane.CanBoost();
        }
    }
}
