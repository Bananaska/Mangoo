using UnityEngine;
using Pathfinding;

public class FlyEnemy : MonoBehaviour
{
    private SpriteRenderer _sprite;
    [SerializeField] private AIPath _aiPath;
    [SerializeField] private AIDestinationSetter _destinationSetter;

    private void Awake()
    {
        _sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        _sprite.flipX = _aiPath.desiredVelocity.x <= 0.01f;
    }

    public void SetTarget(Transform target)
    {
        _destinationSetter.target = target;
    }
}
