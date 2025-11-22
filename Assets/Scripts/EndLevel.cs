using UnityEngine;

public class EndLevel : MonoBehaviour
{
    [SerializeField] private GameObject _menuEndLevel;
    [SerializeField] private GameObject _menuButton;

    private void OnTriggerEnter2D(Collider2D other)    
    {
        if (other.CompareTag("End"))
        {
            Debug.Log("Касание");
            _menuButton.SetActive(false);
            _menuEndLevel.SetActive(true);

        }
    }
}
