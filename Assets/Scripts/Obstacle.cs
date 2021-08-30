using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        transform.Translate(Vector3.left * (Time.deltaTime * _speed));
    }
}
