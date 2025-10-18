using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/HealthItem")]
public class RefillHPItem : ScriptableObject
{
    public string itemName; // Название предмета
    public Sprite icon;     // Иконка предмета
    public bool isStackable; // Можно ли складывать в стопки
    public int healthCount;

    // Метод, который может быть переопределен для уникальных действий с предметом
    public virtual void Use()
    {
        Debug.Log($"Использован предмет: {itemName}");
    }

}
