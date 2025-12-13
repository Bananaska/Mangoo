using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField] private int _amount;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Health.Instance.Change(_amount);
        }
    }

}
