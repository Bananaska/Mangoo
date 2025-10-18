using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/HealthItem")]
public class RefillHPItem : ScriptableObject
{
    public string itemName; // �������� ��������
    public Sprite icon;     // ������ ��������
    public bool isStackable; // ����� �� ���������� � ������
    public int healthCount;

    // �����, ������� ����� ���� ������������� ��� ���������� �������� � ���������
    public virtual void Use()
    {
        Debug.Log($"����������� �������: {itemName}");
    }

}
