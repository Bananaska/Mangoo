using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker2D : MonoBehaviour
{
    [SerializeField] private Transform _point;
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _ground;
    public bool IsGrounded { get; private set; }
    private void Update()
    {
        Vector2 point = _point.position;
        IsGrounded = Physics2D.OverlapCircle(point, _radius, _ground);
    }
    
}
