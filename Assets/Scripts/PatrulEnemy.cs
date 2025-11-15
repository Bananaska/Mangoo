using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class PatrulEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] _targetPoints;
    [SerializeField] private float _chasingSpeed;
    [SerializeField] private float _walkingSpeed;
    [SerializeField] private float _viewDistance;

    private Rigidbody2D _rigidbody2D;
    private Transform _currentPoint;
    private Transform _target;
    private float _minDistance;
    private float _curentSpeed;
    private float _direction;
    private bool _isChasing;

    private void Update()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

        SelectCurrentPoint();
        _curentSpeed = _walkingSpeed;
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
        TryFindPlayer();
        Move();
        Debug.Log("direction:" + _direction);

        if (math.abs(transform.position.x - _currentPoint.position.x)<= _minDistance)
        {
            SelectCurrentPoint();
        }
    }
    private void Rotate()
    {
        transform.rotation = Quaternion.Euler(0, -_direction * 90 + 90, 0);
    }

    TryFindPlayer()
    {
        _hit = Physics2D.Raycast(transform.position, transform.right * _viewDistance, Color.red);
    }
}
