using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private SharedVariable _speed;
    private GameController _gameController;

    private void Start()
    {
        _gameController = FindObjectOfType<GameController>();
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        transform.Translate(Vector3.left * (Time.deltaTime * _speed.value));
    }

    // Adiciona pontos quando jogador passar pelo obstaculo
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            _gameController.CountPoints();
        }
    }
}
