using UnityEngine;
using static UnityEditor.Progress;

// ScriptableObject ��� �������� ������� ������ ��������
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName; // �������� ��������
    public Sprite icon;     // ������ ��������
    public bool isStackable; // ����� �� ���������� � ������

    // �����, ������� ����� ���� ������������� ��� ���������� �������� � ���������
    public virtual void Use()
    {
        Debug.Log($"����������� �������: {itemName}");
        //Inventory.instance.Add(_item);
    }
}