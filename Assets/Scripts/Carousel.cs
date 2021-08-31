using UnityEngine;

public class Carousel : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Vector3 _initialPosition;
    private float _imageSize;

    private void Awake()
    {
        _initialPosition = transform.position;
        _imageSize = GetComponent<SpriteRenderer>().size.x * transform.localScale.x;
    }

    private void Update()
    {
        var displacement = Mathf.Repeat(_speed * Time.timeSinceLevelLoad, _imageSize);
        transform.position = _initialPosition + Vector3.left * displacement;
    }
}
