using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class MeleeWeapon : MonoBehaviour, IWeapon
{
    [SerializeField] private int _damage = 1;
    [SerializeField] private float _couldown = 1f;
    [SerializeField] private float _atackTime = 0.2f;
    [SerializeField] private GameObject _AtackField;
    [SerializeField] private bool _atack = false;
    [SerializeField] private bool _atackRecharging = false;
    public void Use()
    {
        
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && _atackRecharging == false)
        {
            _atack = true;
            _atackRecharging = true;
            StartCoroutine(AtackCouldown());
            StartCoroutine(AtackingTime());
            if (_atack == true)
            {
                _AtackField.SetActive(true);
            }
        }
    }


    private IEnumerator AtackingTime()
    {
        yield return new WaitForSeconds(_atackTime);
        _atack = false;
    }
    private IEnumerator AtackCouldown()
    {
        yield return new WaitForSeconds(_couldown);
        _atackRecharging = false;
        _AtackField.SetActive(false);
    }


}
