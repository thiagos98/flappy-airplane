using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] private float _timeToGenerate;
    [SerializeField] private GameObject _obstacle;
    private float _stopwatch;
    private const float _maxRange = 1.90f;
    private const float _minRange = -1.76f;

    private void Awake()
    {
        _stopwatch = _timeToGenerate;
    }

    private void Update()
    {
        _stopwatch -= Time.deltaTime;
        if (!(_stopwatch < 0)) return;
        transform.position = new Vector3(transform.position.x, Random.Range(_minRange, _maxRange));
        Instantiate(_obstacle, transform.position, Quaternion.identity);
        _stopwatch = _timeToGenerate;
    }
}
