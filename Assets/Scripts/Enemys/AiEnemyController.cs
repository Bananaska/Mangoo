using UnityEngine;

namespace Teaching.Octopus
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class EnemyAIController : MonoBehaviour
    {
        private enum State
        {
            Patrol,
            Chase
        }

        [Header("Ссылки")]
        [SerializeField] private Rigidbody2D _body;
        [SerializeField] private Transform _player;
        [SerializeField] private Transform[] _patrolPoints;

        [Header("Скорости")]
        [SerializeField] private float _patrolSpeed = 2f;
        [SerializeField] private float _chaseSpeed = 4f;
        [SerializeField] private float _stopDistance = 0.1f;

        [Header("Обнаружение")]
        [SerializeField] private float _detectionRange = 5f;
        [SerializeField] private float _loseSightDelay = 1.5f;
        [SerializeField] private LayerMask _detectionMask;

        private State _state = State.Patrol;
        private int _currentPoint;
        private float _loseSightTimer;
        private Vector3 _startScale = Vector3.one;
        private float _facing = 1f;

        private void Awake()
        {
            _body ??= GetComponent<Rigidbody2D>();
            _startScale = transform.localScale;
        }

        private void Update()
        {
            UpdateDetection();
            HandleState();
        }

        private void HandleState()
        {
            switch (_state)
            {
                case State.Patrol:
                    PatrolMove();
                    break;
                case State.Chase:
                    ChaseMove();
                    break;
            }
        }

        private void UpdateDetection()
        {
            float dt = Time.deltaTime;
            bool seePlayer = false;
            if (_player != null)
            {
                Vector2 origin = transform.position;
                Vector2 dir = new Vector2(_facing, 0f);
                RaycastHit2D hit = Physics2D.Raycast(origin, dir, _detectionRange, _detectionMask);

                if (hit.collider != null && hit.collider.transform == _player)
                {
                    seePlayer = true;
                }

                Debug.DrawLine(origin, origin + dir * _detectionRange, seePlayer ? Color.red : Color.yellow);
            }

            if (seePlayer)
            {
                _state = State.Chase;
                _loseSightTimer = _loseSightDelay;
            }
            else if (_state == State.Chase)
            {
                _loseSightTimer -= dt;
                if (_loseSightTimer <= 0f)
                {
                    _state = State.Patrol;
                }
            }
        }

        private void PatrolMove()
        {
            if (_patrolPoints == null || _patrolPoints.Length == 0)
            {
                Stop();
                return;
            }

            Transform target = _patrolPoints[_currentPoint];

            Vector2 delta = target.position - transform.position;
            float distance = delta.magnitude;

            if (distance <= _stopDistance)
            {
                _currentPoint = GetNextRandomPoint();
                Stop();
                return;
            }
            float dt = Time.deltaTime;
            Vector2 nextPos = Vector2.MoveTowards(_body.position, target.position, _patrolSpeed * dt);
            _body.MovePosition(nextPos);

            if (Mathf.Abs(delta.x) > 0.01f)
            {
                Face(delta.x);
            }
        }

        private void ChaseMove()
        {
            Vector2 delta = _player.position - transform.position;
            if (delta.magnitude <= _stopDistance)
            {
                Stop();
                return;
            }

            MoveHorizontal(delta, _chaseSpeed);
        }

        private void MoveHorizontal(Vector2 delta, float speed)
        {
            if (_body == null)
            {
                return;
            }

            float direction = Mathf.Sign(delta.x);
            _body.linearVelocity = new Vector2(direction * speed, _body.linearVelocity.y);

            if (Mathf.Abs(direction) > 0.01f)
            {
                Face(direction);
            }
        }

        private void Stop()
        {
            if (_body == null)
            {
                return;
            }

            _body.linearVelocity = new Vector2(0f, _body.linearVelocity.y);
        }

        private int GetNextRandomPoint()
        {
            if (_patrolPoints == null || _patrolPoints.Length == 0 || _patrolPoints.Length == 1)
            {
                return 0;
            }

            int next = _currentPoint;
            while (next == _currentPoint)
            {
                next = Random.Range(0, _patrolPoints.Length);
            }

            return next;
        }

        private void Face(float direction)
        {
            _facing = Mathf.Sign(direction);

            Vector3 scale = _startScale;
            scale.x *= _facing;
            transform.localScale = scale;
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Vector3 origin = transform.position;
            Vector3 dir = new Vector3(_facing, 0f, 0f);
            // Gizmos.DrawLine(origin, origin + dir * _detectionRange);
            Gizmos.DrawWireSphere(origin + dir * _detectionRange, 0.1f);
        }
    }
}
