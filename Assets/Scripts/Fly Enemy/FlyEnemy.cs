using UnityEngine;
using Pathfinding;

public class FlyEnemy : MonoBehaviour
{
    private SpriteRenderer _sprite;
    [SerializeField] private AIPath _aiPath;

    private void Awake()
    {
        _sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        _sprite.flipX = _aiPath.desiredVelocity.x <= 0.01f;
    }
}
