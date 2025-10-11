using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    [SerializeField] private int _hpEnemy=5;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.CompareTag("AtackPlayer"))
        {
            _hpEnemy -= 1;
            Debug.Log(_hpEnemy);
        }
    }
}
