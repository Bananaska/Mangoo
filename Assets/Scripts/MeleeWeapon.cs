using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class MeleeWeapon : MonoBehaviour, IWeapon
{
    [SerializeField] public int _plDamage;
    [SerializeField] private float _couldown;
    [SerializeField] private float _atackTime;
    [SerializeField] private GameObject _AtackField;
    [SerializeField] private bool _atack = false;
    [SerializeField] private bool _atackRecharging = false;

    public void Use()
    {
       
        if ( _atackRecharging == false) 
        {
            _atack = true;
            _atackRecharging = true;
            
            StartCoroutine(AtackCouldown());
            StartCoroutine(AtackingTime());
            SoundManager.Instance.PlayHitSound();

        }
    }
    private void Update()
    {
        if (_atack == true)
        {
            _AtackField.SetActive(true);
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
