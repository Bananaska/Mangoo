using System;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour, IDamageable
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _health;

    public static Health Instance;

    public event Action OnDealth;
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


    private void Update()
    {
       
    }

    public void Change(int value)
    {
        _health += value;
        
        if (_health < 0)
        {
            OnDealth?.Invoke();
            _health = 0;
        }
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }
        OnChanged?.Invoke(_health);
    }
}
