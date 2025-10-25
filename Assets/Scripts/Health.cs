using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour, IDamageable
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _health;

    public static Health instanse;

    private void Awake()
    {
      if(instanse != null)
        {
            Debug.Log("Health уже существует");
            return;
        }
        instanse = this;
    }


    private void Update()
    {
       
    }

    public void Change(int value)
    {
        _health += value;
        
        if (_health < 0)
        {
            _health = 0;
        }
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }
    }
}
