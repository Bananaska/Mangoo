using UnityEngine;

public class Collectables : MonoBehaviour
{
    [SerializeField] private Item _item;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_item != null)
        {
            if (collision.CompareTag("Player"))
            {
                Inventory.instance.Add(_item);                
            }
        }
        Destroy(gameObject);
    }
}
