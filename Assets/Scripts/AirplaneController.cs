using UnityEngine;

public class AirplaneController : MonoBehaviour 
{
    private Rigidbody2D _rigidbody;
    [SerializeField] private float force = 6;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            Boost();
        }
    }

    private void Boost()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }
}