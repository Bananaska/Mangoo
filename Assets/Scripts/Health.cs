using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour, IDamageable
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _health;

    private void Awake()
    {
        _health = _maxHealth;
    }
  
    public void TakeDamage()
    {
        if (_health < 0)
        {
            _health = 0;
        }


    }
}
