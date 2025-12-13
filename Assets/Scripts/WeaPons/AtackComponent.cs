using UnityEngine;

public class AtackComponent : MonoBehaviour
{
    private MeleeWeapon _meleeWeapon;
    private InputResiver _inputResiver;

    private void Awake()
    {
        _meleeWeapon = GetComponent<MeleeWeapon>();
        _inputResiver = GetComponent<InputResiver>();
    }
    void Update()
    {
        if (_inputResiver.AtackPressed == true)
        {
            _meleeWeapon.Use();
        }
    }
}
