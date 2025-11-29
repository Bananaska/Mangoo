using System;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour, IDamageable
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _health;

    public static Health Instance;

    public event Action OnDeath;
    public event Action<int> OnChanged;

    private void Awake()
    {
      if (Instance != null)
        {
            Debug.Log("Health уже существует");
            return;
       }
        Instance = this;
    }
    private void Start()
    {
        Change(_maxHealth);

    }

    private void Update()
    {
       
    }
    public void Death()
    {
        OnDeath?.Invoke();

    }

    public void Change(int value)
    {
        _health += value;
        
        if (_health < 0)
        {
            OnDeath?.Invoke();
            _health = 0;
        }
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }
        OnChanged?.Invoke(_health);
    }
}
