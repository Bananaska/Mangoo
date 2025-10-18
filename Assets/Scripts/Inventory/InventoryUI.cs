using UnityEngine;

// ����� ��� ���������� UI ���������
public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent; // �������� ������
    public Inventory inventory;

    private InventorySlot[] slots; // ������ ������

    void Start()
    {
        inventory.onItemChangedCallback += UpdateUI; // ������������� �� ��������� ���������
        slots = itemsParent.GetComponentsInChildren<InventorySlot>(); // �������� ��� �����
    }

    // ����� ��� ���������� ����������
    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]); // ��������� ����
            }
            else
            {
                slots[i].ClearSlot(); // ������� ����
            }
        }
    }
}