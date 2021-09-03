using UnityEngine;

public class Carousel : MonoBehaviour
{
    [SerializeField] private SharedVariable _speed;
    private Vector3 _initialPosition;
    private float _imageSize;

    private void Awake()
    {
        _initialPosition = transform.position;
        _imageSize = GetComponent<SpriteRenderer>().size.x * transform.localScale.x;
    }

    private void Update()
    {
        var displacement = Mathf.Repeat(_speed.value * Time.timeSinceLevelLoad, _imageSize/2);
        transform.position = _initialPosition + Vector3.left * displacement;
    }
}