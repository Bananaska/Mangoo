using UnityEngine;

public class TrainingManecen : MonoBehaviour
{
    [SerializeField] private GameObject _FlyEnemy;
    [SerializeField] private GameObject _TT1;
    [SerializeField] private GameObject _TT2;
    //TT - training text
    private void OnDestroy()
    {
        _FlyEnemy.SetActive(true);
        _TT1.SetActive(false);
        _TT2.SetActive(true);
    }
}
