using UnityEngine;

// ScriptableObject ��� �������� ������� ������ ��������
[CreateAssetMenu(fileName = "ManGo", menuName = "Inventory/Item")]
public class MangoItem : ScriptableObject
{
    public string Mango; // �������� ��������
    public Sprite icon;     // ������ ��������
    public bool isStackable; // ����� �� ���������� � ������

    // �����, ������� ����� ���� ������������� ��� ���������� �������� � ���������
    public virtual void Use()
    {
        Debug.Log($"����������� �������: {Mango}");
    }
}