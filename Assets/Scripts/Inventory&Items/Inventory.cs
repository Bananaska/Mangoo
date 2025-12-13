using System;
using System.Collections.Generic;
using UnityEngine;

// Класс инвентаря для управления предметами
public class Inventory : MonoBehaviour
{
    public static Inventory instance; // Синглтон для удобного доступа

    public List<Item> items = new List<Item>(); // Список предметов в инвентаре
    public int space = 20; // Максимальное количество предметов

    // Делегат для уведомления об изменениях в инвентаре
    public event Action OnItemChanged;
 
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Inventory уже существует!");
            return;
        }
        instance = this;
    }

    // Метод для добавления предмета
    public bool Add(Item item)
    {
        if (items.Count >= space)
        {
            Debug.Log("Нет места в инвентаре!");
            return false;
        }

        items.Add(item);
        OnItemChanged?.Invoke(); // Уведомляем об изменениях
        return true;
    }

    // Метод для удаления предмета
    public void Remove(Item item)
    {
        Debug.Log("Предмет удалён" + item);
        items.Remove(item);
        OnItemChanged?.Invoke(); // Уведомляем об изменениях
    }
}