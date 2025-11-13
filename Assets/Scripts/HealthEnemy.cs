using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    [SerializeField] private int _hpEnemy;
    [SerializeField] private Sprite _deathPictureEnemy;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.layer == LayerMask.NameToLayer("PlayerAttack"))
        {
            _hpEnemy -= 1;
            Debug.Log(_hpEnemy);
        }
    }
    private void Update()
    {
        if(_hpEnemy<=0)
        {
            Destroy(gameObject);
        }
    }
}
