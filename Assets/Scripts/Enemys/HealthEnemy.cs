using System;

using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    [SerializeField] private int _hpEnemy;
    [SerializeField] private Sprite _deathPictureEnemy;

    public event Action OnEnemyDamaged;

    private void Start()
    {
        //AddListener(EnemyDamaged);
    }

    private void EnemyDamaged()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);

        if (other.gameObject.CompareTag("AtackPlayer"));
        {
            _hpEnemy -= 1;
            Debug.Log(_hpEnemy);
        }
    }
    private void Update()
    {
        if(_hpEnemy<=0)
        {
            SoundManager.Instance.PlayEnemyDeathSound();
            Destroy(gameObject);            
        }
    }
}
