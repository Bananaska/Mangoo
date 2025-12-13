using System;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/HealthItem")]
public class RefillHPItem : Item
{
    [SerializeField] private int _amount;

    public override void Use()
    {
        base.Use();
        Health.Instance.Change(_amount);
    }
}
