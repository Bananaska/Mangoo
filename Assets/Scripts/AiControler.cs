using UnityEngine;
using Random = UnityEngine.Random;

public class AiControler : MonoBehaviour
{
    [SerializeField] private Transform[] _targetPoints;
    [SerializeField] private float _chasingSpeed;
    [SerializeField] private float _walkingSpeed;
    [SerializeField] private float _viewDistance;

    private RaycastHit2D _hit;
    private Rigidbody2D _rigidbody2D;
    private Transform _currentPoint;
    private Transform _target;
    private float _minDistance = 0.1f;
    private float _currentSpeed;
    private float _direction;
    private bool _isChasing;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

        SelectCurrentPoint();
        _currentSpeed = _walkingSpeed;
    }
    private void SelectCurrentPoint()
    {
        if (_isChasing) return;
        int pointIndex = Random.Range(0, _targetPoints.Length);
        _currentPoint = _targetPoints[pointIndex];
    }
    private void FixedUpdate()
    {
        _direction = _currentPoint.position.x - transform.position.x;
        _direction = _direction < 0 ? -1 : 1;
        Rotate();
        Move();
    }
    private void Rotate()
    {
        transform.rotation = Quaternion.Euler(0, - _direction *90 +90, 0);
    }
    private void Move()
    {
        _rigidbody2D.velocity = new Vector2(_direction * _chasingSpeed, _rigidbody2D.velocity.y);
    }
}
