using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private HealthView _healthView;

    private void Start()
    {
        _health.OnChanged += _healthView.UpdateHealth;

    }
    private void OnDestroy()
    {
        _health.OnChanged -= _healthView.UpdateHealth;
    }
}
