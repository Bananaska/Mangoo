using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    [SerializeField] private int _hpEnemy=5;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("AtackPlayer"))
        {
            _hpEnemy -= 1;
            Debug.Log(_hpEnemy);
        }
    }
}
