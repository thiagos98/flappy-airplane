using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private GameController _gameController;
    private Vector3 _airplanePosition;
    private bool _isScored;

    private void Start()
    {
        Destroy(gameObject, 5f);
        _gameController = FindObjectOfType<GameController>();
        _airplanePosition = GameObject.FindObjectOfType<AirplaneController>().transform.position;
    }

    private void Update()
    {
        transform.Translate(Vector3.left * (Time.deltaTime * _speed));
        if (!_isScored && transform.position.x < _airplanePosition.x)
        {
            _gameController.CountPoints();
            _isScored = true;
        }
    }
}
