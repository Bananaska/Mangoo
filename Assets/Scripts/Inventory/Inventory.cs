using System;
using System.Collections.Generic;
using UnityEngine;

// ����� ��������� ��� ���������� ����������
public class Inventory : MonoBehaviour
{
    public static Inventory instance; // �������� ��� �������� �������

    public List<Item> items = new List<Item>(); // ������ ��������� � ���������
    public int space = 20; // ������������ ���������� ���������

    // ������� ��� ����������� �� ���������� � ���������
    public event Action OnItemChanged;
 
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Inventory ��� ����������!");
            return;
        }
        instance = this;
    }

    // ����� ��� ���������� ��������
    public bool Add(Item item)
    {
        if (items.Count >= space)
        {
            Debug.Log("��� ����� � ���������!");
            return false;
        }

        items.Add(item);
        OnItemChanged?.Invoke(); // ���������� �� ����������
        return true;
    }

    // ����� ��� �������� ��������
    public void Remove(Item item)
    {
        items.Remove(item);
        OnItemChanged?.Invoke(); // ���������� �� ����������
    }
}